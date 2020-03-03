namespace MFASB
{
    partial class GeneratePrimeNumbers
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboAlgorithms = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLowerLimitP = new System.Windows.Forms.TextBox();
            this.txtUpperLimitP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResultQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpperLimitQ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLowerLimitQ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGeneratePrimeNumbers = new System.Windows.Forms.Button();
            this.btnApplyPrimes = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the algorithm for testing the number primality";
            // 
            // cboAlgorithms
            // 
            this.cboAlgorithms.FormattingEnabled = true;
            this.cboAlgorithms.Location = new System.Drawing.Point(264, 10);
            this.cboAlgorithms.Name = "cboAlgorithms";
            this.cboAlgorithms.Size = new System.Drawing.Size(207, 21);
            this.cboAlgorithms.TabIndex = 1;
            this.cboAlgorithms.SelectedIndexChanged += new System.EventHandler(this.cboAlgorithms_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResultP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUpperLimitP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLowerLimitP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prime number p";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lower limit";
            // 
            // txtLowerLimitP
            // 
            this.txtLowerLimitP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLowerLimitP.Location = new System.Drawing.Point(68, 25);
            this.txtLowerLimitP.Name = "txtLowerLimitP";
            this.txtLowerLimitP.Size = new System.Drawing.Size(126, 20);
            this.txtLowerLimitP.TabIndex = 4;
            // 
            // txtUpperLimitP
            // 
            this.txtUpperLimitP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpperLimitP.Location = new System.Drawing.Point(68, 51);
            this.txtUpperLimitP.Name = "txtUpperLimitP";
            this.txtUpperLimitP.Size = new System.Drawing.Size(126, 20);
            this.txtUpperLimitP.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Upper limit";
            // 
            // txtResultP
            // 
            this.txtResultP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultP.Location = new System.Drawing.Point(68, 89);
            this.txtResultP.Name = "txtResultP";
            this.txtResultP.ReadOnly = true;
            this.txtResultP.Size = new System.Drawing.Size(126, 20);
            this.txtResultP.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Result";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResultQ);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtUpperLimitQ);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtLowerLimitQ);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(264, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 125);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prime number q";
            // 
            // txtResultQ
            // 
            this.txtResultQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultQ.Location = new System.Drawing.Point(68, 89);
            this.txtResultQ.Name = "txtResultQ";
            this.txtResultQ.ReadOnly = true;
            this.txtResultQ.Size = new System.Drawing.Size(126, 20);
            this.txtResultQ.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Result";
            // 
            // txtUpperLimitQ
            // 
            this.txtUpperLimitQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpperLimitQ.Location = new System.Drawing.Point(68, 51);
            this.txtUpperLimitQ.Name = "txtUpperLimitQ";
            this.txtUpperLimitQ.Size = new System.Drawing.Size(126, 20);
            this.txtUpperLimitQ.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Upper limit";
            // 
            // txtLowerLimitQ
            // 
            this.txtLowerLimitQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLowerLimitQ.Location = new System.Drawing.Point(68, 25);
            this.txtLowerLimitQ.Name = "txtLowerLimitQ";
            this.txtLowerLimitQ.Size = new System.Drawing.Size(126, 20);
            this.txtLowerLimitQ.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Lower limit";
            // 
            // btnGeneratePrimeNumbers
            // 
            this.btnGeneratePrimeNumbers.Location = new System.Drawing.Point(16, 195);
            this.btnGeneratePrimeNumbers.Name = "btnGeneratePrimeNumbers";
            this.btnGeneratePrimeNumbers.Size = new System.Drawing.Size(177, 30);
            this.btnGeneratePrimeNumbers.TabIndex = 10;
            this.btnGeneratePrimeNumbers.Text = "Generate prime numbers, p and q";
            this.btnGeneratePrimeNumbers.UseVisualStyleBackColor = true;
            this.btnGeneratePrimeNumbers.Click += new System.EventHandler(this.btnGeneratePrimeNumbers_Click);
            // 
            // btnApplyPrimes
            // 
            this.btnApplyPrimes.Location = new System.Drawing.Point(199, 195);
            this.btnApplyPrimes.Name = "btnApplyPrimes";
            this.btnApplyPrimes.Size = new System.Drawing.Size(90, 30);
            this.btnApplyPrimes.TabIndex = 11;
            this.btnApplyPrimes.Text = "Apply primes";
            this.btnApplyPrimes.UseVisualStyleBackColor = true;
            this.btnApplyPrimes.Click += new System.EventHandler(this.btnApplyPrimes_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(402, 195);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 30);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GeneratePrimeNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 247);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnApplyPrimes);
            this.Controls.Add(this.btnGeneratePrimeNumbers);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboAlgorithms);
            this.Controls.Add(this.label1);
            this.Name = "GeneratePrimeNumbers";
            this.Text = "GeneratePrimeNumbers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeneratePrimeNumbers_FormClosed);
            this.Load += new System.EventHandler(this.GeneratePrimeNumbers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAlgorithms;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResultP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUpperLimitP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLowerLimitP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtResultQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUpperLimitQ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLowerLimitQ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGeneratePrimeNumbers;
        private System.Windows.Forms.Button btnApplyPrimes;
        private System.Windows.Forms.Button btnClose;
    }
}