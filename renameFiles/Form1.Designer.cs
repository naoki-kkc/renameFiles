namespace RenameCreatedateMd5
{
    partial class FileRename
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.renameExecButton = new System.Windows.Forms.Button();
            this.suffix00x = new System.Windows.Forms.RadioButton();
            this.dropLabel = new System.Windows.Forms.Label();
            this.ymdhmsMd5Radio = new System.Windows.Forms.RadioButton();
            this.renameRuleGroup = new System.Windows.Forms.GroupBox();
            this.seqRadio = new System.Windows.Forms.RadioButton();
            this.md5Radio = new System.Windows.Forms.RadioButton();
            this.ymdRadio = new System.Windows.Forms.RadioButton();
            this.ymdMd5Radio = new System.Windows.Forms.RadioButton();
            this.ymdhmsRadio = new System.Windows.Forms.RadioButton();
            this.suffixGroup = new System.Windows.Forms.GroupBox();
            this.suffixX = new System.Windows.Forms.RadioButton();
            this.showLogWindow = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressText = new System.Windows.Forms.Label();
            this.renameRuleGroup.SuspendLayout();
            this.suffixGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // renameExecButton
            // 
            this.renameExecButton.Enabled = false;
            this.renameExecButton.Location = new System.Drawing.Point(447, 151);
            this.renameExecButton.Name = "renameExecButton";
            this.renameExecButton.Size = new System.Drawing.Size(125, 118);
            this.renameExecButton.TabIndex = 1;
            this.renameExecButton.Text = "リネーム実行";
            this.renameExecButton.UseVisualStyleBackColor = true;
            this.renameExecButton.Click += new System.EventHandler(this.renameExecButton_Click);
            // 
            // suffix00x
            // 
            this.suffix00x.AutoSize = true;
            this.suffix00x.Checked = true;
            this.suffix00x.Location = new System.Drawing.Point(15, 24);
            this.suffix00x.Name = "suffix00x";
            this.suffix00x.Size = new System.Drawing.Size(45, 16);
            this.suffix00x.TabIndex = 3;
            this.suffix00x.TabStop = true;
            this.suffix00x.Text = "_00x";
            this.suffix00x.UseVisualStyleBackColor = true;
            // 
            // dropLabel
            // 
            this.dropLabel.AllowDrop = true;
            this.dropLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropLabel.Location = new System.Drawing.Point(12, 9);
            this.dropLabel.Name = "dropLabel";
            this.dropLabel.Size = new System.Drawing.Size(560, 129);
            this.dropLabel.TabIndex = 4;
            this.dropLabel.Text = "リネームするファイルが入ったフォルダをここにドラッグ...";
            this.dropLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dropLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropLabel_DragDrop);
            this.dropLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropLabel_DragEnter);
            // 
            // ymdhmsMd5Radio
            // 
            this.ymdhmsMd5Radio.Checked = true;
            this.ymdhmsMd5Radio.Location = new System.Drawing.Point(6, 24);
            this.ymdhmsMd5Radio.Name = "ymdhmsMd5Radio";
            this.ymdhmsMd5Radio.Size = new System.Drawing.Size(226, 16);
            this.ymdhmsMd5Radio.TabIndex = 11;
            this.ymdhmsMd5Radio.TabStop = true;
            this.ymdhmsMd5Radio.Text = "作成日時のyyyymmddhhmmss形式_md5";
            this.ymdhmsMd5Radio.UseVisualStyleBackColor = true;
            // 
            // renameRuleGroup
            // 
            this.renameRuleGroup.Controls.Add(this.seqRadio);
            this.renameRuleGroup.Controls.Add(this.md5Radio);
            this.renameRuleGroup.Controls.Add(this.ymdRadio);
            this.renameRuleGroup.Controls.Add(this.ymdMd5Radio);
            this.renameRuleGroup.Controls.Add(this.ymdhmsRadio);
            this.renameRuleGroup.Controls.Add(this.ymdhmsMd5Radio);
            this.renameRuleGroup.Location = new System.Drawing.Point(12, 151);
            this.renameRuleGroup.Name = "renameRuleGroup";
            this.renameRuleGroup.Size = new System.Drawing.Size(304, 162);
            this.renameRuleGroup.TabIndex = 12;
            this.renameRuleGroup.TabStop = false;
            this.renameRuleGroup.Text = "ファイル名変更ルール";
            // 
            // seqRadio
            // 
            this.seqRadio.Location = new System.Drawing.Point(6, 134);
            this.seqRadio.Name = "seqRadio";
            this.seqRadio.Size = new System.Drawing.Size(226, 16);
            this.seqRadio.TabIndex = 16;
            this.seqRadio.Text = "連番(6桁)";
            this.seqRadio.UseVisualStyleBackColor = true;
            // 
            // md5Radio
            // 
            this.md5Radio.Location = new System.Drawing.Point(6, 112);
            this.md5Radio.Name = "md5Radio";
            this.md5Radio.Size = new System.Drawing.Size(226, 16);
            this.md5Radio.TabIndex = 15;
            this.md5Radio.Text = "md5";
            this.md5Radio.UseVisualStyleBackColor = true;
            // 
            // ymdRadio
            // 
            this.ymdRadio.Location = new System.Drawing.Point(6, 90);
            this.ymdRadio.Name = "ymdRadio";
            this.ymdRadio.Size = new System.Drawing.Size(226, 16);
            this.ymdRadio.TabIndex = 14;
            this.ymdRadio.Text = "作成日時のyyyymmdd形式";
            this.ymdRadio.UseVisualStyleBackColor = true;
            // 
            // ymdMd5Radio
            // 
            this.ymdMd5Radio.Location = new System.Drawing.Point(6, 68);
            this.ymdMd5Radio.Name = "ymdMd5Radio";
            this.ymdMd5Radio.Size = new System.Drawing.Size(226, 16);
            this.ymdMd5Radio.TabIndex = 13;
            this.ymdMd5Radio.Text = "作成日時のyyyymmdd形式_md5";
            this.ymdMd5Radio.UseVisualStyleBackColor = true;
            // 
            // ymdhmsRadio
            // 
            this.ymdhmsRadio.Location = new System.Drawing.Point(6, 46);
            this.ymdhmsRadio.Name = "ymdhmsRadio";
            this.ymdhmsRadio.Size = new System.Drawing.Size(226, 16);
            this.ymdhmsRadio.TabIndex = 12;
            this.ymdhmsRadio.Text = "作成日時のyyyymmddhhmmss形式";
            this.ymdhmsRadio.UseVisualStyleBackColor = true;
            // 
            // suffixGroup
            // 
            this.suffixGroup.Controls.Add(this.suffixX);
            this.suffixGroup.Controls.Add(this.suffix00x);
            this.suffixGroup.Location = new System.Drawing.Point(322, 151);
            this.suffixGroup.Name = "suffixGroup";
            this.suffixGroup.Size = new System.Drawing.Size(119, 162);
            this.suffixGroup.TabIndex = 13;
            this.suffixGroup.TabStop = false;
            this.suffixGroup.Text = "重複時のサフィックス";
            // 
            // suffixX
            // 
            this.suffixX.AutoSize = true;
            this.suffixX.Location = new System.Drawing.Point(15, 46);
            this.suffixX.Name = "suffixX";
            this.suffixX.Size = new System.Drawing.Size(33, 16);
            this.suffixX.TabIndex = 4;
            this.suffixX.Text = "_x";
            this.suffixX.UseVisualStyleBackColor = true;
            // 
            // showLogWindow
            // 
            this.showLogWindow.Enabled = false;
            this.showLogWindow.Location = new System.Drawing.Point(447, 275);
            this.showLogWindow.Name = "showLogWindow";
            this.showLogWindow.Size = new System.Drawing.Size(125, 36);
            this.showLogWindow.TabIndex = 14;
            this.showLogWindow.Text = "実行ログ表示";
            this.showLogWindow.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 320);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(560, 23);
            this.progressBar.TabIndex = 15;
            // 
            // progressText
            // 
            this.progressText.Location = new System.Drawing.Point(448, 320);
            this.progressText.Name = "progressText";
            this.progressText.Size = new System.Drawing.Size(124, 23);
            this.progressText.TabIndex = 16;
            this.progressText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 352);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.showLogWindow);
            this.Controls.Add(this.suffixGroup);
            this.Controls.Add(this.renameRuleGroup);
            this.Controls.Add(this.dropLabel);
            this.Controls.Add(this.renameExecButton);
            this.Controls.Add(this.progressText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FileRename";
            this.Text = "renameFiles";
            this.renameRuleGroup.ResumeLayout(false);
            this.suffixGroup.ResumeLayout(false);
            this.suffixGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button renameExecButton;
        private System.Windows.Forms.RadioButton suffix00x;
        private System.Windows.Forms.Label dropLabel;
        private System.Windows.Forms.RadioButton ymdhmsMd5Radio;
        private System.Windows.Forms.GroupBox renameRuleGroup;
        private System.Windows.Forms.GroupBox suffixGroup;
        private System.Windows.Forms.RadioButton ymdRadio;
        private System.Windows.Forms.RadioButton ymdMd5Radio;
        private System.Windows.Forms.RadioButton ymdhmsRadio;
        private System.Windows.Forms.RadioButton suffixX;
        private System.Windows.Forms.Button showLogWindow;
        private System.Windows.Forms.RadioButton seqRadio;
        private System.Windows.Forms.RadioButton md5Radio;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressText;
    }
}

