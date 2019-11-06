using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogSearch2
{
    public partial class Form1 : Form
    {
        private static List<string> logLines = new List<string>();
        private static List<string> _output = new List<string>();

        public Form1()
        {
            InitializeComponent();

            selectFilter.Items.Add("Alle Auslastung zwischen");
            selectFilter.Items.Add("Alle Zeiträume zwischen");
            selectFilter.Items.Add("In CSV konvertieren");
        }

        private void BtnLoadFile(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                var fileStream = dialog.OpenFile();
                using(var reader = new StreamReader(fileStream))
                {
                    var myLog = reader.ReadToEnd();
                    logLines.AddRange(myLog.Split('\n').ToList());
                    SetRawLog();
                }
            }
        }

        private void SetRawLog()
        {
            TextboxRawLog.Text = string.Join("\n", logLines.ToArray());
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            var fromRes = int.TryParse(TextFrom.Text, out int from);
            var toRes = int.TryParse(TextTo.Text, out int to);
            if(selectFilter.SelectedIndex != 2)
            {
                if (!fromRes)
                {
                    from = int.MinValue;
                    fromRes = true;
                }
                    
                    
                if (!toRes)
                {
                    to = int.MaxValue;
                    toRes = true;
                }
                    
            }
            if ((!fromRes || !toRes) && selectFilter.SelectedIndex != 2)
                return;

            switch (selectFilter.SelectedIndex)
            {
                case 0:
                    var myRes = new List<string>();
                    myRes.AddRange(logLines.Where(x => int.Parse(x.Split('=')[1]) >= from && int.Parse(x.Split('=')[1]) <= to));
                    SetOutput(myRes);
                    break;

                case 1:
                    var myRes2 = new List<string>();
                    myRes2.AddRange(logLines.Where(x => int.Parse(x.Split('=')[0].Remove(0,1)) >= from && int.Parse(x.Split('=')[0].Remove(0, 1)) <= to));
                    SetOutput(myRes2);
                    break;

                case 2:
                    var myRes3 = new List<string>();
                    myRes3.Add("Time;Load");
                    myRes3.AddRange(logLines.Select(x => x.Replace('=', ';')));
                    SetOutput(myRes3);
                    break;

                default:
                    break;
            }
        }

        private void SetOutput(ICollection<string> output)
        {
            _output = output.ToList();
            TextboxOutput.Text = string.Join("\n", output);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var saveLog = new SaveFileDialog();
            saveLog.FileName = "Mein neuer Log.txt";

            if (saveLog.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveLog.FileName, string.Join("\n", _output.ToArray()));
        }

        private void ChangeFilter(object sender, EventArgs e)
        {
            TextFrom.Text = "";
            TextTo.Text = "";
            switch (selectFilter.SelectedIndex)
            {
                case 2:
                    TextFrom.Visible = false;
                    TextTo.Visible = false;
                    label1.Visible = false;
                    break;


                default:
                    TextFrom.Visible = true;
                    TextTo.Visible = true;
                    label1.Visible = true;
                    break;
            }
        }
    }
}
