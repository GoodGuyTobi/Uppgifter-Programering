namespace Forms_Kalkylator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.chkTrue = new System.Windows.Forms.CheckBox();
            this.lblText = new System.Windows.Forms.Label();
            this.cboLista = new System.Windows.Forms.ComboBox();
            this.gbRadio = new System.Windows.Forms.GroupBox();
            this.optRadio1 = new System.Windows.Forms.RadioButton();
            this.optRadio2 = new System.Windows.Forms.RadioButton();
            this.gbRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 293);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(417, 22);
            this.txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(52, 96);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(171, 22);
            this.txtOutput.TabIndex = 1;
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(164, 344);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(106, 36);
            this.btnOutput.TabIndex = 2;
            this.btnOutput.Text = "Click me";
            this.btnOutput.UseVisualStyleBackColor = true;
            // 
            // chkTrue
            // 
            this.chkTrue.AutoSize = true;
            this.chkTrue.Location = new System.Drawing.Point(52, 124);
            this.chkTrue.Name = "chkTrue";
            this.chkTrue.Size = new System.Drawing.Size(60, 21);
            this.chkTrue.TabIndex = 3;
            this.chkTrue.Text = "True";
            this.chkTrue.UseVisualStyleBackColor = true;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(49, 76);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(62, 17);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Fyll i text";
            // 
            // cboLista
            // 
            this.cboLista.FormattingEnabled = true;
            this.cboLista.Location = new System.Drawing.Point(52, 151);
            this.cboLista.Name = "cboLista";
            this.cboLista.Size = new System.Drawing.Size(171, 24);
            this.cboLista.TabIndex = 5;
            // 
            // gbRadio
            // 
            this.gbRadio.Controls.Add(this.optRadio2);
            this.gbRadio.Controls.Add(this.optRadio1);
            this.gbRadio.Location = new System.Drawing.Point(240, 96);
            this.gbRadio.Name = "gbRadio";
            this.gbRadio.Size = new System.Drawing.Size(200, 100);
            this.gbRadio.TabIndex = 6;
            this.gbRadio.TabStop = false;
            this.gbRadio.Text = "Radioknappar";
            // 
            // optRadio1
            // 
            this.optRadio1.AutoSize = true;
            this.optRadio1.Location = new System.Drawing.Point(31, 22);
            this.optRadio1.Name = "optRadio1";
            this.optRadio1.Size = new System.Drawing.Size(78, 21);
            this.optRadio1.TabIndex = 0;
            this.optRadio1.TabStop = true;
            this.optRadio1.Text = "Radio 1";
            this.optRadio1.UseVisualStyleBackColor = true;
            // 
            // optRadio2
            // 
            this.optRadio2.AutoSize = true;
            this.optRadio2.Location = new System.Drawing.Point(31, 50);
            this.optRadio2.Name = "optRadio2";
            this.optRadio2.Size = new System.Drawing.Size(78, 21);
            this.optRadio2.TabIndex = 1;
            this.optRadio2.TabStop = true;
            this.optRadio2.Text = "Radio 2";
            this.optRadio2.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 406);
            this.Controls.Add(this.gbRadio);
            this.Controls.Add(this.cboLista);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.chkTrue);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "frmMain";
            this.Text = "Forms Demo";
            this.gbRadio.ResumeLayout(false);
            this.gbRadio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.CheckBox chkTrue;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.ComboBox cboLista;
        private System.Windows.Forms.GroupBox gbRadio;
        private System.Windows.Forms.RadioButton optRadio2;
        private System.Windows.Forms.RadioButton optRadio1;
    }
}

