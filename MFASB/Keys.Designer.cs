namespace MFASB
{
    partial class Keys
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
            this.tvKeys = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeyContent = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Keys";
            // 
            // tvKeys
            // 
            this.tvKeys.Location = new System.Drawing.Point(16, 30);
            this.tvKeys.Name = "tvKeys";
            this.tvKeys.Size = new System.Drawing.Size(193, 402);
            this.tvKeys.TabIndex = 1;
            this.tvKeys.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tvKeys_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Key Content";
            // 
            // txtKeyContent
            // 
            this.txtKeyContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeyContent.Location = new System.Drawing.Point(228, 30);
            this.txtKeyContent.Multiline = true;
            this.txtKeyContent.Name = "txtKeyContent";
            this.txtKeyContent.ReadOnly = true;
            this.txtKeyContent.Size = new System.Drawing.Size(332, 402);
            this.txtKeyContent.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(485, 451);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(13, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(452, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Developed by Marius Iulian MIHAILESCU and Stefania Loredana NITA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(13, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "The 13th International Conference on Communications 2020";
            // 
            // Keys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 510);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtKeyContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tvKeys);
            this.Controls.Add(this.label1);
            this.Name = "Keys";
            this.Text = "Keys";
            this.Load += new System.EventHandler(this.Keys_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvKeys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKeyContent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}