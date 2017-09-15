namespace HotelServer_1
{
    partial class login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_user = new System.Windows.Forms.TextBox();
            this.login_pwd = new System.Windows.Forms.TextBox();
            this.but_login = new System.Windows.Forms.Button();
            this.but_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 354);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // login_user
            // 
            this.login_user.Location = new System.Drawing.Point(169, 202);
            this.login_user.Multiline = true;
            this.login_user.Name = "login_user";
            this.login_user.Size = new System.Drawing.Size(194, 34);
            this.login_user.TabIndex = 1;
            // 
            // login_pwd
            // 
            this.login_pwd.Location = new System.Drawing.Point(169, 263);
            this.login_pwd.Multiline = true;
            this.login_pwd.Name = "login_pwd";
            this.login_pwd.PasswordChar = '*';
            this.login_pwd.Size = new System.Drawing.Size(194, 34);
            this.login_pwd.TabIndex = 2;
            // 
            // but_login
            // 
            this.but_login.BackColor = System.Drawing.Color.Transparent;
            this.but_login.FlatAppearance.BorderSize = 0;
            this.but_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_login.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_login.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_login.Location = new System.Drawing.Point(383, 206);
            this.but_login.Name = "but_login";
            this.but_login.Size = new System.Drawing.Size(75, 34);
            this.but_login.TabIndex = 6;
            this.but_login.Text = "登录";
            this.but_login.UseVisualStyleBackColor = false;
            this.but_login.Click += new System.EventHandler(this.but_login_Click);
            // 
            // but_exit
            // 
            this.but_exit.BackColor = System.Drawing.Color.Transparent;
            this.but_exit.FlatAppearance.BorderSize = 0;
            this.but_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_exit.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_exit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_exit.Location = new System.Drawing.Point(383, 262);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(75, 31);
            this.but_exit.TabIndex = 7;
            this.but_exit.Text = "关闭";
            this.but_exit.UseVisualStyleBackColor = false;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click_1);
            // 
            // login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 353);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.but_login);
            this.Controls.Add(this.login_pwd);
            this.Controls.Add(this.login_user);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox login_user;
        private System.Windows.Forms.TextBox login_pwd;
        private System.Windows.Forms.Button but_login;
        private System.Windows.Forms.Button but_exit;
    }
}

