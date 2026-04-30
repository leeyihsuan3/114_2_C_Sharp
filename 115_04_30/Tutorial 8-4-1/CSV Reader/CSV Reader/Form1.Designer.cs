namespace CSV_Reader
{
    partial class Form1
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
        /// 
        /// 下列程式碼已將所有元件的文字改為繁體中文，
        /// 並將字型大小統一設定為 18pt（使用 Microsoft JhengHei / 微軟正黑體），
        /// 同時適度調整元件大小與位置以符合較大字型的顯示需求。
        /// 註解均以繁體中文說明每個主要設定項目與調整理由。
        /// </summary>
        private void InitializeComponent()
        {
            this.averagesListBox = new System.Windows.Forms.ListBox();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // averagesListBox
            // 
            // 設定清單框字型為繁體中文常用字型並將字級調為 18pt，便於閱讀
            this.averagesListBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 調整 ListBox 位置與尺寸以配合較大字級並預留按鈕下方空間
            this.averagesListBox.Location = new System.Drawing.Point(16, 16);
            this.averagesListBox.Name = "averagesListBox";
            this.averagesListBox.Size = new System.Drawing.Size(448, 260);
            this.averagesListBox.TabIndex = 0;
            // 
            // getScoresButton
            // 
            // 設定按鈕字型與文字（繁體中文）
            this.getScoresButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 變更按鈕大小與位置：放置於 ListBox 之下，置中靠左
            this.getScoresButton.Location = new System.Drawing.Point(96, 290);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(120, 44);
            this.getScoresButton.TabIndex = 1;
            this.getScoresButton.Text = "讀取分數";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // exitButton
            // 
            // 設定按鈕字型與文字（繁體中文）
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 變更按鈕大小與位置：放置於 ListBox 之下，置中靠右
            this.exitButton.Location = new System.Drawing.Point(264, 290);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 44);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 將整體表單的字型也設定為 18pt，確保一致性（設為預設字型以避免部分控制項繼承不同字型）
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // 調整表單客戶區大小以容納放大的控制項與適當外距
            this.ClientSize = new System.Drawing.Size(480, 352);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.averagesListBox);
            this.Name = "Form1";
            // 將表單標題改為繁體中文
            this.Text = "CSV 檔案讀取器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox averagesListBox;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button exitButton;
    }
}

