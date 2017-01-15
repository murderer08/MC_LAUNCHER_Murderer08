namespace MCLauncher
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_offline = new System.Windows.Forms.Button();
            this.btn_reg = new System.Windows.Forms.Button();
            this.btn_forum = new System.Windows.Forms.Button();
            this.btn_site = new System.Windows.Forms.Button();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_offline
            // 
            this.btn_offline.Enabled = false;
            this.btn_offline.Location = new System.Drawing.Point(45, 147);
            this.btn_offline.Name = "btn_offline";
            this.btn_offline.Size = new System.Drawing.Size(92, 46);
            this.btn_offline.TabIndex = 0;
            this.btn_offline.Text = "Play offline mode";
            this.btn_offline.UseVisualStyleBackColor = true;
            this.btn_offline.Click += new System.EventHandler(this.btn_offline_Click);
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(462, 143);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(107, 50);
            this.btn_reg.TabIndex = 1;
            this.btn_reg.Text = "Registration =>";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // btn_forum
            // 
            this.btn_forum.Location = new System.Drawing.Point(340, 92);
            this.btn_forum.Name = "btn_forum";
            this.btn_forum.Size = new System.Drawing.Size(229, 35);
            this.btn_forum.TabIndex = 2;
            this.btn_forum.Text = "Forum =>";
            this.btn_forum.UseVisualStyleBackColor = true;
            // 
            // btn_site
            // 
            this.btn_site.Location = new System.Drawing.Point(45, 92);
            this.btn_site.Name = "btn_site";
            this.btn_site.Size = new System.Drawing.Size(289, 35);
            this.btn_site.TabIndex = 3;
            this.btn_site.Text = "Site =>";
            this.btn_site.UseVisualStyleBackColor = true;
            // 
            // txt_login
            // 
            this.txt_login.BackColor = System.Drawing.Color.LightSalmon;
            this.txt_login.Location = new System.Drawing.Point(170, 147);
            this.txt_login.MaxLength = 255;
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(164, 20);
            this.txt_login.TabIndex = 4;
            this.txt_login.TextChanged += new System.EventHandler(this.txt_login_TextChanged);
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(170, 173);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.Size = new System.Drawing.Size(164, 20);
            this.txt_pw.TabIndex = 5;
            // 
            // btn_login
            // 
            this.btn_login.Enabled = false;
            this.btn_login.Location = new System.Drawing.Point(340, 143);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(116, 50);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MCLauncher.Properties.Resources.panel_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 302);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.btn_site);
            this.Controls.Add(this.btn_forum);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.btn_offline);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "MCLauncher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_offline;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Button btn_forum;
        private System.Windows.Forms.Button btn_site;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Button btn_login;
    }
}

