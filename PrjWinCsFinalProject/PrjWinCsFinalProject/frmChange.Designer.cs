namespace PrjWinCsFinalProject
{
    partial class frmChange
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
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtInputValue = new System.Windows.Forms.TextBox();
            this.lblInputCurrency = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radConvertToDollar = new System.Windows.Forms.RadioButton();
            this.radConvertToCurrency = new System.Windows.Forms.RadioButton();
            this.lblValueDollar = new System.Windows.Forms.Label();
            this.lblValueCurrency = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCountry
            // 
            this.cboCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(68, 115);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(266, 28);
            this.cboCountry.TabIndex = 22;
            this.cboCountry.Text = "Select Country";
            this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.cboCountry_SelectedIndexChanged);
            // 
            // btnQuit
            // 
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(637, 338);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(110, 34);
            this.btnQuit.TabIndex = 21;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(637, 298);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 34);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(637, 256);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(110, 34);
            this.btnConvert.TabIndex = 19;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(53, 387);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(249, 33);
            this.lblOutput.TabIndex = 18;
            // 
            // txtInputValue
            // 
            this.txtInputValue.Location = new System.Drawing.Point(451, 291);
            this.txtInputValue.Name = "txtInputValue";
            this.txtInputValue.Size = new System.Drawing.Size(96, 22);
            this.txtInputValue.TabIndex = 17;
            this.txtInputValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputValue_KeyPress);
            // 
            // lblInputCurrency
            // 
            this.lblInputCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInputCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputCurrency.Location = new System.Drawing.Point(451, 247);
            this.lblInputCurrency.Name = "lblInputCurrency";
            this.lblInputCurrency.Size = new System.Drawing.Size(96, 28);
            this.lblInputCurrency.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radConvertToDollar);
            this.groupBox1.Controls.Add(this.radConvertToCurrency);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 135);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of conversion";
            // 
            // radConvertToDollar
            // 
            this.radConvertToDollar.AutoSize = true;
            this.radConvertToDollar.Location = new System.Drawing.Point(28, 79);
            this.radConvertToDollar.Name = "radConvertToDollar";
            this.radConvertToDollar.Size = new System.Drawing.Size(17, 16);
            this.radConvertToDollar.TabIndex = 1;
            this.radConvertToDollar.UseVisualStyleBackColor = true;
            // 
            // radConvertToCurrency
            // 
            this.radConvertToCurrency.AutoSize = true;
            this.radConvertToCurrency.Location = new System.Drawing.Point(28, 37);
            this.radConvertToCurrency.Name = "radConvertToCurrency";
            this.radConvertToCurrency.Size = new System.Drawing.Size(17, 16);
            this.radConvertToCurrency.TabIndex = 0;
            this.radConvertToCurrency.UseVisualStyleBackColor = true;
            // 
            // lblValueDollar
            // 
            this.lblValueDollar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValueDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueDollar.Location = new System.Drawing.Point(372, 179);
            this.lblValueDollar.Name = "lblValueDollar";
            this.lblValueDollar.Size = new System.Drawing.Size(350, 30);
            this.lblValueDollar.TabIndex = 14;
            // 
            // lblValueCurrency
            // 
            this.lblValueCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValueCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueCurrency.Location = new System.Drawing.Point(372, 130);
            this.lblValueCurrency.Name = "lblValueCurrency";
            this.lblValueCurrency.Size = new System.Drawing.Size(350, 30);
            this.lblValueCurrency.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "BUREAU -XCHANGE";
            // 
            // frmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtInputValue);
            this.Controls.Add(this.lblInputCurrency);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblValueDollar);
            this.Controls.Add(this.lblValueCurrency);
            this.Controls.Add(this.label1);
            this.Name = "frmChange";
            this.Text = "$ Bureau de change international";
            this.Load += new System.EventHandler(this.frmChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtInputValue;
        private System.Windows.Forms.Label lblInputCurrency;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radConvertToDollar;
        private System.Windows.Forms.RadioButton radConvertToCurrency;
        private System.Windows.Forms.Label lblValueDollar;
        private System.Windows.Forms.Label lblValueCurrency;
        private System.Windows.Forms.Label label1;
    }
}