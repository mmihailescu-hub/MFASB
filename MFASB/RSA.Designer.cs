namespace MFASB
{
    partial class RSA
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGeneratePrimeNumber = new System.Windows.Forms.Button();
            this.txtPrimeNumberQ = new System.Windows.Forms.TextBox();
            this.txtPrimeNumberP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPhiN = new System.Windows.Forms.TextBox();
            this.txtModulusN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.numberToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sieveOfEratosthenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGeneratePrimeNumber);
            this.groupBox1.Controls.Add(this.txtPrimeNumberQ);
            this.groupBox1.Controls.Add(this.txtPrimeNumberP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate p and q";
            // 
            // btnGeneratePrimeNumber
            // 
            this.btnGeneratePrimeNumber.Location = new System.Drawing.Point(325, 26);
            this.btnGeneratePrimeNumber.Name = "btnGeneratePrimeNumber";
            this.btnGeneratePrimeNumber.Size = new System.Drawing.Size(144, 48);
            this.btnGeneratePrimeNumber.TabIndex = 4;
            this.btnGeneratePrimeNumber.Text = "Generate Prime Number";
            this.btnGeneratePrimeNumber.UseVisualStyleBackColor = true;
            this.btnGeneratePrimeNumber.Click += new System.EventHandler(this.btnGeneratePrimeNumber_Click);
            // 
            // txtPrimeNumberQ
            // 
            this.txtPrimeNumberQ.Location = new System.Drawing.Point(92, 54);
            this.txtPrimeNumberQ.Name = "txtPrimeNumberQ";
            this.txtPrimeNumberQ.Size = new System.Drawing.Size(227, 20);
            this.txtPrimeNumberQ.TabIndex = 3;
            // 
            // txtPrimeNumberP
            // 
            this.txtPrimeNumberP.Location = new System.Drawing.Point(92, 26);
            this.txtPrimeNumberP.Name = "txtPrimeNumberP";
            this.txtPrimeNumberP.Size = new System.Drawing.Size(227, 20);
            this.txtPrimeNumberP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prime number q";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prime number p";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPhiN);
            this.groupBox2.Controls.Add(this.txtModulusN);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 130);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Computing RSA Parameters";
            // 
            // txtPhiN
            // 
            this.txtPhiN.Location = new System.Drawing.Point(92, 54);
            this.txtPhiN.Name = "txtPhiN";
            this.txtPhiN.Size = new System.Drawing.Size(377, 20);
            this.txtPhiN.TabIndex = 3;
            // 
            // txtModulusN
            // 
            this.txtModulusN.Location = new System.Drawing.Point(92, 26);
            this.txtModulusN.Name = "txtModulusN";
            this.txtModulusN.Size = new System.Drawing.Size(377, 20);
            this.txtModulusN.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "phi(N)=(p-1)(q-1)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "RSA Modulus N";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberToolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // numberToolsToolStripMenuItem
            // 
            this.numberToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sieveOfEratosthenesToolStripMenuItem});
            this.numberToolsToolStripMenuItem.Name = "numberToolsToolStripMenuItem";
            this.numberToolsToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.numberToolsToolStripMenuItem.Text = "Numbers tools";
            // 
            // sieveOfEratosthenesToolStripMenuItem
            // 
            this.sieveOfEratosthenesToolStripMenuItem.Name = "sieveOfEratosthenesToolStripMenuItem";
            this.sieveOfEratosthenesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.sieveOfEratosthenesToolStripMenuItem.Text = "Sieve of Eratosthenes";
            this.sieveOfEratosthenesToolStripMenuItem.Click += new System.EventHandler(this.sieveOfEratosthenesToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(421, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 441);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RSA";
            this.Text = "RSA";
            this.Load += new System.EventHandler(this.RSA_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrimeNumberQ;
        private System.Windows.Forms.TextBox txtPrimeNumberP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeneratePrimeNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPhiN;
        private System.Windows.Forms.TextBox txtModulusN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem numberToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sieveOfEratosthenesToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
    }
}