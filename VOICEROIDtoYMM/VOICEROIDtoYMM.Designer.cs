namespace VOICEROIDtoYMM
{
    partial class VOICEROIDtoYMM
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.SendButton = new System.Windows.Forms.Button();
            this.VoiceRoidTitleBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.WaitBox = new System.Windows.Forms.TextBox();
            this.FolderSelectButton = new System.Windows.Forms.Button();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(126, 37);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(100, 69);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // VoiceRoidTitleBox
            // 
            this.VoiceRoidTitleBox.Location = new System.Drawing.Point(12, 12);
            this.VoiceRoidTitleBox.Name = "VoiceRoidTitleBox";
            this.VoiceRoidTitleBox.Size = new System.Drawing.Size(100, 19);
            this.VoiceRoidTitleBox.TabIndex = 1;
            this.VoiceRoidTitleBox.Text = "茜";
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(12, 62);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(100, 19);
            this.NumberBox.TabIndex = 2;
            this.NumberBox.Text = "0";
            // 
            // WaitBox
            // 
            this.WaitBox.BackColor = System.Drawing.SystemColors.Control;
            this.WaitBox.Location = new System.Drawing.Point(12, 87);
            this.WaitBox.Name = "WaitBox";
            this.WaitBox.Size = new System.Drawing.Size(100, 19);
            this.WaitBox.TabIndex = 3;
            this.WaitBox.Text = "100";
            // 
            // FolderSelectButton
            // 
            this.FolderSelectButton.Location = new System.Drawing.Point(126, 12);
            this.FolderSelectButton.Name = "FolderSelectButton";
            this.FolderSelectButton.Size = new System.Drawing.Size(100, 19);
            this.FolderSelectButton.TabIndex = 4;
            this.FolderSelectButton.Text = "フォルダ選択";
            this.FolderSelectButton.UseVisualStyleBackColor = true;
            this.FolderSelectButton.Click += new System.EventHandler(this.FolderSelectButton_Click);
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(12, 37);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(100, 19);
            this.FileNameBox.TabIndex = 5;
            this.FileNameBox.Text = "akane";
            // 
            // VOICEROIDtoYMM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 119);
            this.Controls.Add(this.FileNameBox);
            this.Controls.Add(this.FolderSelectButton);
            this.Controls.Add(this.WaitBox);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.VoiceRoidTitleBox);
            this.Controls.Add(this.SendButton);
            this.Name = "VOICEROIDtoYMM";
            this.Text = "VOICEROIDtoYMM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VOICEROIDtoYMM_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox VoiceRoidTitleBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox WaitBox;
        private System.Windows.Forms.Button FolderSelectButton;
        private System.Windows.Forms.TextBox FileNameBox;
    }
}

