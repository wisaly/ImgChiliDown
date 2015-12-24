namespace imgChiliDown
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.editAlbums = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editLocal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editProxy = new System.Windows.Forms.TextBox();
            this.editLog = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(423, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editAlbums
            // 
            this.editAlbums.Location = new System.Drawing.Point(13, 36);
            this.editAlbums.Multiline = true;
            this.editAlbums.Name = "editAlbums";
            this.editAlbums.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.editAlbums.Size = new System.Drawing.Size(422, 164);
            this.editAlbums.TabIndex = 1;
            this.editAlbums.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Album列表（每行一个）：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "本地保存路径：";
            // 
            // editLocal
            // 
            this.editLocal.Location = new System.Drawing.Point(13, 242);
            this.editLocal.Name = "editLocal";
            this.editLocal.Size = new System.Drawing.Size(422, 21);
            this.editLocal.TabIndex = 4;
            this.editLocal.Text = "d:\\test\\a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "代理服务器地址（不使用留空）：";
            // 
            // editProxy
            // 
            this.editProxy.Location = new System.Drawing.Point(13, 286);
            this.editProxy.Name = "editProxy";
            this.editProxy.Size = new System.Drawing.Size(422, 21);
            this.editProxy.TabIndex = 6;
            this.editProxy.Text = "127.0.0.1:8087";
            // 
            // editLog
            // 
            this.editLog.Location = new System.Drawing.Point(17, 393);
            this.editLog.Multiline = true;
            this.editLog.Name = "editLog";
            this.editLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.editLog.Size = new System.Drawing.Size(418, 203);
            this.editLog.TabIndex = 9;
            this.editLog.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "日志（仅显示错误）：";
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.Location = new System.Drawing.Point(13, 360);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(0, 12);
            this.labelCurrent.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 608);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.editLog);
            this.Controls.Add(this.editProxy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editAlbums);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "ImgChilli Down";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox editAlbums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox editProxy;
        private System.Windows.Forms.TextBox editLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCurrent;
    }
}

