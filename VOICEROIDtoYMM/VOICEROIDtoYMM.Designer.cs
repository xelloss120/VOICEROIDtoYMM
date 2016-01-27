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
            this.SendButton1 = new System.Windows.Forms.Button();
            this.VoiceRoidTitleBox1 = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.WaitBox = new System.Windows.Forms.TextBox();
            this.FolderSelectButton = new System.Windows.Forms.Button();
            this.VoiceRoidTitleBox2 = new System.Windows.Forms.TextBox();
            this.SendButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SendButton1
            // 
            this.SendButton1.Location = new System.Drawing.Point(124, 37);
            this.SendButton1.Name = "SendButton1";
            this.SendButton1.Size = new System.Drawing.Size(50, 19);
            this.SendButton1.TabIndex = 4;
            this.SendButton1.Text = "Send";
            this.SendButton1.UseVisualStyleBackColor = true;
            this.SendButton1.Click += new System.EventHandler(this.SendButton1_Click);
            // 
            // VoiceRoidTitleBox1
            // 
            this.VoiceRoidTitleBox1.Location = new System.Drawing.Point(12, 37);
            this.VoiceRoidTitleBox1.Name = "VoiceRoidTitleBox1";
            this.VoiceRoidTitleBox1.Size = new System.Drawing.Size(106, 19);
            this.VoiceRoidTitleBox1.TabIndex = 3;
            this.VoiceRoidTitleBox1.Text = "茜";
            this.VoiceRoidTitleBox1.TextChanged += new System.EventHandler(this.VoiceRoidTitleBox1_TextChanged);
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(12, 12);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(50, 19);
            this.NumberBox.TabIndex = 0;
            this.NumberBox.Text = "0";
            // 
            // WaitBox
            // 
            this.WaitBox.BackColor = System.Drawing.SystemColors.Control;
            this.WaitBox.Location = new System.Drawing.Point(68, 12);
            this.WaitBox.Name = "WaitBox";
            this.WaitBox.Size = new System.Drawing.Size(50, 19);
            this.WaitBox.TabIndex = 1;
            this.WaitBox.Text = "100";
            // 
            // FolderSelectButton
            // 
            this.FolderSelectButton.Location = new System.Drawing.Point(124, 12);
            this.FolderSelectButton.Name = "FolderSelectButton";
            this.FolderSelectButton.Size = new System.Drawing.Size(50, 19);
            this.FolderSelectButton.TabIndex = 2;
            this.FolderSelectButton.Text = "Out";
            this.FolderSelectButton.UseVisualStyleBackColor = true;
            this.FolderSelectButton.Click += new System.EventHandler(this.FolderSelectButton_Click);
            // 
            // VoiceRoidTitleBox2
            // 
            this.VoiceRoidTitleBox2.Location = new System.Drawing.Point(12, 62);
            this.VoiceRoidTitleBox2.Name = "VoiceRoidTitleBox2";
            this.VoiceRoidTitleBox2.Size = new System.Drawing.Size(106, 19);
            this.VoiceRoidTitleBox2.TabIndex = 5;
            this.VoiceRoidTitleBox2.Text = "葵";
            this.VoiceRoidTitleBox2.TextChanged += new System.EventHandler(this.VoiceRoidTitleBox2_TextChanged);
            // 
            // SendButton2
            // 
            this.SendButton2.Location = new System.Drawing.Point(124, 62);
            this.SendButton2.Name = "SendButton2";
            this.SendButton2.Size = new System.Drawing.Size(50, 19);
            this.SendButton2.TabIndex = 6;
            this.SendButton2.Text = "Send";
            this.SendButton2.UseVisualStyleBackColor = true;
            this.SendButton2.Click += new System.EventHandler(this.SendButton2_Click);
            // 
            // VOICEROIDtoYMM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 92);
            this.Controls.Add(this.VoiceRoidTitleBox2);
            this.Controls.Add(this.SendButton2);
            this.Controls.Add(this.FolderSelectButton);
            this.Controls.Add(this.WaitBox);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.VoiceRoidTitleBox1);
            this.Controls.Add(this.SendButton1);
            this.KeyPreview = true;
            this.Name = "VOICEROIDtoYMM";
            this.Text = "VOICEROIDtoYMM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VOICEROIDtoYMM_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VOICEROIDtoYMM_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton1;
        private System.Windows.Forms.TextBox VoiceRoidTitleBox1;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox WaitBox;
        private System.Windows.Forms.Button FolderSelectButton;
        private System.Windows.Forms.TextBox VoiceRoidTitleBox2;
        private System.Windows.Forms.Button SendButton2;
    }
}

