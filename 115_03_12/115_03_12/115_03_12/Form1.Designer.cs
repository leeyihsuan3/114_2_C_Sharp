namespace _115_03_12
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtNum4;
        private System.Windows.Forms.TextBox txtNum5;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label lblTitle;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
                txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtNum3 = new TextBox();
            txtNum4 = new TextBox();
            txtNum5 = new TextBox();
            btnGenerate = new Button();
            btnDraw = new Button();
            btnExit = new Button();
            lstOutput = new ListBox();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Segoe UI", 10F);
            txtNum1.Location = new Point(24, 18);
            txtNum1.Name = "txtNum1";
            txtNum1.ReadOnly = true;
            txtNum1.Size = new Size(80, 34);
            txtNum1.TabIndex = 0;
            txtNum1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Segoe UI", 10F);
            txtNum2.Location = new Point(24, 18);
            txtNum2.Name = "txtNum2";
            txtNum2.ReadOnly = true;
            txtNum2.Size = new Size(80, 34);
            txtNum2.TabIndex = 1;
            txtNum2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNum3
            // 
            txtNum3.Font = new Font("Segoe UI", 10F);
            txtNum3.Location = new Point(24, 18);
            txtNum3.Name = "txtNum3";
            txtNum3.ReadOnly = true;
            txtNum3.Size = new Size(80, 34);
            txtNum3.TabIndex = 2;
            txtNum3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNum4
            // 
            txtNum4.Font = new Font("Segoe UI", 10F);
            txtNum4.Location = new Point(24, 18);
            txtNum4.Name = "txtNum4";
            txtNum4.ReadOnly = true;
            txtNum4.Size = new Size(80, 34);
            txtNum4.TabIndex = 3;
            txtNum4.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNum5
            // 
            txtNum5.Font = new Font("Segoe UI", 10F);
            txtNum5.Location = new Point(24, 18);
            txtNum5.Name = "txtNum5";
            txtNum5.ReadOnly = true;
            txtNum5.Size = new Size(80, 34);
            txtNum5.TabIndex = 4;
            txtNum5.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Segoe UI", 12F);
            btnGenerate.Location = new Point(40, 68);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(160, 48);
            btnGenerate.TabIndex = 5;
            btnGenerate.Text = "產生號碼";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnDraw
            // 
            btnDraw.Font = new Font("Segoe UI", 12F);
            btnDraw.Location = new Point(230, 68);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(160, 48);
            btnDraw.TabIndex = 6;
            btnDraw.Text = "開獎號碼";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F);
            btnExit.Location = new Point(420, 68);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(160, 48);
            btnExit.TabIndex = 7;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lstOutput
            // 
            lstOutput.Font = new Font("Segoe UI", 10F);
            lstOutput.ItemHeight = 28;
            lstOutput.Location = new Point(24, 150);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(560, 144);
            lstOutput.TabIndex = 9;
            lstOutput.SelectedIndexChanged += lstOutput_SelectedIndexChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 119);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(159, 28);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "本期開獎號碼：";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 531);
            Controls.Add(txtNum1);
            Controls.Add(txtNum2);
            Controls.Add(txtNum3);
            Controls.Add(txtNum4);
            Controls.Add(txtNum5);
            Controls.Add(btnGenerate);
            Controls.Add(btnDraw);
            Controls.Add(btnExit);
            Controls.Add(lblTitle);
            Controls.Add(lstOutput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "樂透號碼產生器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
