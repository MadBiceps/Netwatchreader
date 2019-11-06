namespace LogSearch2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.TextboxRawLog = new System.Windows.Forms.RichTextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TextboxOutput = new System.Windows.Forms.RichTextBox();
            this.selectFilter = new System.Windows.Forms.ComboBox();
            this.TextFrom = new System.Windows.Forms.TextBox();
            this.TextTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Datei Laden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnLoadFile);
            // 
            // TextboxRawLog
            // 
            this.TextboxRawLog.Location = new System.Drawing.Point(12, 12);
            this.TextboxRawLog.Name = "TextboxRawLog";
            this.TextboxRawLog.Size = new System.Drawing.Size(302, 453);
            this.TextboxRawLog.TabIndex = 2;
            this.TextboxRawLog.Text = "";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(330, 421);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(332, 44);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Speichern";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TextboxOutput
            // 
            this.TextboxOutput.Location = new System.Drawing.Point(684, 12);
            this.TextboxOutput.Name = "TextboxOutput";
            this.TextboxOutput.Size = new System.Drawing.Size(313, 453);
            this.TextboxOutput.TabIndex = 4;
            this.TextboxOutput.Text = "";
            // 
            // selectFilter
            // 
            this.selectFilter.FormattingEnabled = true;
            this.selectFilter.Location = new System.Drawing.Point(330, 123);
            this.selectFilter.Name = "selectFilter";
            this.selectFilter.Size = new System.Drawing.Size(332, 24);
            this.selectFilter.TabIndex = 5;
            this.selectFilter.SelectedIndexChanged += new System.EventHandler(this.ChangeFilter);
            // 
            // TextFrom
            // 
            this.TextFrom.Location = new System.Drawing.Point(330, 165);
            this.TextFrom.Name = "TextFrom";
            this.TextFrom.Size = new System.Drawing.Size(125, 22);
            this.TextFrom.TabIndex = 6;
            // 
            // TextTo
            // 
            this.TextTo.Location = new System.Drawing.Point(537, 165);
            this.TextTo.Name = "TextTo";
            this.TextTo.Size = new System.Drawing.Size(125, 22);
            this.TextTo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "und";
            // 
            // BtnConvert
            // 
            this.BtnConvert.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.BtnConvert.Location = new System.Drawing.Point(330, 206);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(332, 30);
            this.BtnConvert.TabIndex = 9;
            this.BtnConvert.Text = "Konvertieren";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 477);
            this.Controls.Add(this.BtnConvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextTo);
            this.Controls.Add(this.TextFrom);
            this.Controls.Add(this.selectFilter);
            this.Controls.Add(this.TextboxOutput);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TextboxRawLog);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox TextboxRawLog;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.RichTextBox TextboxOutput;
        private System.Windows.Forms.ComboBox selectFilter;
        private System.Windows.Forms.TextBox TextFrom;
        private System.Windows.Forms.TextBox TextTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConvert;
    }
}

