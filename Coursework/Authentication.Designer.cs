
namespace Coursework
{
    partial class Authentication
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.lAuthentication = new System.Windows.Forms.Label();
            this.bEnter = new System.Windows.Forms.Button();
            this.lUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.ilAuthentication = new System.Windows.Forms.ImageList(this.components);
            this.cbPassword = new System.Windows.Forms.CheckBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.bNSTU = new System.Windows.Forms.Button();
            this.bMailRu = new System.Windows.Forms.Button();
            this.bYandex = new System.Windows.Forms.Button();
            this.pbDove = new System.Windows.Forms.PictureBox();
            this.bNext = new System.Windows.Forms.Button();
            this.l2FA = new System.Windows.Forms.Label();
            this.lCode = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lInstruction = new System.Windows.Forms.Label();
            this.pbQRCode = new System.Windows.Forms.PictureBox();
            this.tbCodeAu = new System.Windows.Forms.TextBox();
            this.lCodeAu = new System.Windows.Forms.Label();
            this.bNext2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Font = new System.Drawing.Font("Liberation Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmail.Location = new System.Drawing.Point(75, 176);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(436, 34);
            this.tbEmail.TabIndex = 0;
            this.tbEmail.Text = "elizavetaustinova19@yandex.ru";
            this.tbEmail.Visible = false;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Liberation Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(75, 269);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(436, 34);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Text = "wcvgybdyjavtkumx";
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.Visible = false;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Liberation Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lEmail.Location = new System.Drawing.Point(70, 135);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(78, 27);
            this.lEmail.TabIndex = 2;
            this.lEmail.Text = "Почта";
            this.lEmail.Visible = false;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Font = new System.Drawing.Font("Liberation Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lPassword.Location = new System.Drawing.Point(70, 229);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(95, 27);
            this.lPassword.TabIndex = 3;
            this.lPassword.Text = "Пароль";
            this.lPassword.Visible = false;
            // 
            // lAuthentication
            // 
            this.lAuthentication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lAuthentication.AutoSize = true;
            this.lAuthentication.Font = new System.Drawing.Font("Liberation Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAuthentication.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lAuthentication.Location = new System.Drawing.Point(62, 73);
            this.lAuthentication.Name = "lAuthentication";
            this.lAuthentication.Size = new System.Drawing.Size(405, 31);
            this.lAuthentication.TabIndex = 4;
            this.lAuthentication.Text = "Настройка электронной почты";
            // 
            // bEnter
            // 
            this.bEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEnter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnter.Font = new System.Drawing.Font("Liberation Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEnter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bEnter.Location = new System.Drawing.Point(75, 366);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(436, 55);
            this.bEnter.TabIndex = 6;
            this.bEnter.Text = "Войти";
            this.bEnter.UseVisualStyleBackColor = true;
            this.bEnter.Visible = false;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Font = new System.Drawing.Font("Liberation Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lUserName.Location = new System.Drawing.Point(70, 135);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(444, 27);
            this.lUserName.TabIndex = 8;
            this.lUserName.Text = "Ваше имя (для исходящих сообщений)";
            this.lUserName.Visible = false;
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.White;
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserName.Font = new System.Drawing.Font("Liberation Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserName.Location = new System.Drawing.Point(75, 176);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(436, 34);
            this.tbUserName.TabIndex = 7;
            this.tbUserName.Text = "Устинова Елизавета";
            this.tbUserName.Visible = false;
            // 
            // ilAuthentication
            // 
            this.ilAuthentication.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilAuthentication.ImageStream")));
            this.ilAuthentication.TransparentColor = System.Drawing.Color.Transparent;
            this.ilAuthentication.Images.SetKeyName(0, "icons8-yandex-a-russian-multinational-corporation-specializing-in-internet-relate" +
        "d-products-and-services-96.png");
            this.ilAuthentication.Images.SetKeyName(1, "mail_ru_logo_icon_147267.ico");
            this.ilAuthentication.Images.SetKeyName(2, "1 ЦВЕТ (2)_edited.jpg");
            this.ilAuthentication.Images.SetKeyName(3, "gtkgobackltr_104397.ico");
            // 
            // cbPassword
            // 
            this.cbPassword.AutoSize = true;
            this.cbPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPassword.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPassword.Location = new System.Drawing.Point(75, 308);
            this.cbPassword.Name = "cbPassword";
            this.cbPassword.Size = new System.Drawing.Size(187, 26);
            this.cbPassword.TabIndex = 13;
            this.cbPassword.Text = "Показать пароль";
            this.cbPassword.UseVisualStyleBackColor = true;
            this.cbPassword.Visible = false;
            this.cbPassword.CheckedChanged += new System.EventHandler(this.cbPassword_CheckedChanged);
            // 
            // bSave
            // 
            this.bSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Font = new System.Drawing.Font("Liberation Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bSave.Location = new System.Drawing.Point(75, 366);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(436, 55);
            this.bSave.TabIndex = 14;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Visible = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bBack
            // 
            this.bBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.Font = new System.Drawing.Font("Liberation Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bBack.ImageIndex = 3;
            this.bBack.ImageList = this.ilAuthentication;
            this.bBack.Location = new System.Drawing.Point(0, 0);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(50, 50);
            this.bBack.TabIndex = 15;
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bNSTU
            // 
            this.bNSTU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNSTU.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.bNSTU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNSTU.Font = new System.Drawing.Font("Liberation Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bNSTU.ForeColor = System.Drawing.Color.Black;
            this.bNSTU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNSTU.ImageIndex = 2;
            this.bNSTU.ImageList = this.ilAuthentication;
            this.bNSTU.Location = new System.Drawing.Point(75, 296);
            this.bNSTU.Name = "bNSTU";
            this.bNSTU.Size = new System.Drawing.Size(436, 66);
            this.bNSTU.TabIndex = 12;
            this.bNSTU.Text = "   Корпоративная почта НГТУ";
            this.bNSTU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNSTU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bNSTU.UseVisualStyleBackColor = true;
            this.bNSTU.Click += new System.EventHandler(this.bNSTU_Click);
            // 
            // bMailRu
            // 
            this.bMailRu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bMailRu.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.bMailRu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMailRu.Font = new System.Drawing.Font("Liberation Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bMailRu.ForeColor = System.Drawing.Color.Black;
            this.bMailRu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMailRu.ImageIndex = 1;
            this.bMailRu.ImageList = this.ilAuthentication;
            this.bMailRu.Location = new System.Drawing.Point(75, 225);
            this.bMailRu.Name = "bMailRu";
            this.bMailRu.Size = new System.Drawing.Size(436, 66);
            this.bMailRu.TabIndex = 11;
            this.bMailRu.Text = "   Mail.ru";
            this.bMailRu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMailRu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bMailRu.UseVisualStyleBackColor = true;
            this.bMailRu.Click += new System.EventHandler(this.bMailRu_Click);
            // 
            // bYandex
            // 
            this.bYandex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bYandex.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.bYandex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bYandex.Font = new System.Drawing.Font("Liberation Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bYandex.ForeColor = System.Drawing.Color.Black;
            this.bYandex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bYandex.ImageIndex = 0;
            this.bYandex.ImageList = this.ilAuthentication;
            this.bYandex.Location = new System.Drawing.Point(75, 156);
            this.bYandex.Name = "bYandex";
            this.bYandex.Size = new System.Drawing.Size(436, 66);
            this.bYandex.TabIndex = 10;
            this.bYandex.Text = "   Яндекс";
            this.bYandex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bYandex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bYandex.UseVisualStyleBackColor = true;
            this.bYandex.Click += new System.EventHandler(this.bYandex_Click);
            // 
            // pbDove
            // 
            this.pbDove.Image = global::Coursework.Properties.Resources.peacemaker4x_87000;
            this.pbDove.Location = new System.Drawing.Point(22, 70);
            this.pbDove.Name = "pbDove";
            this.pbDove.Size = new System.Drawing.Size(34, 32);
            this.pbDove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDove.TabIndex = 9;
            this.pbDove.TabStop = false;
            // 
            // bNext
            // 
            this.bNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNext.Font = new System.Drawing.Font("Liberation Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bNext.Location = new System.Drawing.Point(75, 368);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(436, 55);
            this.bNext.TabIndex = 16;
            this.bNext.Text = "Далее";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Visible = false;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // l2FA
            // 
            this.l2FA.AutoSize = true;
            this.l2FA.BackColor = System.Drawing.Color.Transparent;
            this.l2FA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l2FA.Font = new System.Drawing.Font("Liberation Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l2FA.Location = new System.Drawing.Point(71, 343);
            this.l2FA.Name = "l2FA";
            this.l2FA.Size = new System.Drawing.Size(366, 19);
            this.l2FA.TabIndex = 17;
            this.l2FA.Text = "Подключить двухфакторную аутентификацию";
            this.l2FA.Visible = false;
            this.l2FA.Click += new System.EventHandler(this.l2FA_Click);
            this.l2FA.MouseEnter += new System.EventHandler(this.l2FA_MouseEnter);
            this.l2FA.MouseLeave += new System.EventHandler(this.l2FA_MouseLeave);
            // 
            // lCode
            // 
            this.lCode.AutoSize = true;
            this.lCode.Font = new System.Drawing.Font("Liberation Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lCode.Location = new System.Drawing.Point(70, 135);
            this.lCode.Name = "lCode";
            this.lCode.Size = new System.Drawing.Size(441, 27);
            this.lCode.TabIndex = 18;
            this.lCode.Text = "Введите 6-значный код из приложения";
            this.lCode.Visible = false;
            // 
            // tbCode
            // 
            this.tbCode.BackColor = System.Drawing.Color.White;
            this.tbCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCode.Font = new System.Drawing.Font("Liberation Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCode.Location = new System.Drawing.Point(75, 176);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(436, 34);
            this.tbCode.TabIndex = 19;
            this.tbCode.Visible = false;
            // 
            // lInstruction
            // 
            this.lInstruction.AutoSize = true;
            this.lInstruction.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lInstruction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lInstruction.Location = new System.Drawing.Point(76, 134);
            this.lInstruction.Name = "lInstruction";
            this.lInstruction.Size = new System.Drawing.Size(428, 110);
            this.lInstruction.TabIndex = 20;
            this.lInstruction.Text = "• В приложении Google Authenticator нажмите \r\n  на значок +.\r\n\r\n• Выберите Отскан" +
    "ировать QR-код или \r\n  Ввести ключ настройки.";
            this.lInstruction.Visible = false;
            // 
            // pbQRCode
            // 
            this.pbQRCode.Location = new System.Drawing.Point(204, 254);
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.Size = new System.Drawing.Size(170, 170);
            this.pbQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQRCode.TabIndex = 21;
            this.pbQRCode.TabStop = false;
            this.pbQRCode.Visible = false;
            // 
            // tbCodeAu
            // 
            this.tbCodeAu.BackColor = System.Drawing.Color.White;
            this.tbCodeAu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCodeAu.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCodeAu.Location = new System.Drawing.Point(75, 389);
            this.tbCodeAu.Name = "tbCodeAu";
            this.tbCodeAu.ReadOnly = true;
            this.tbCodeAu.Size = new System.Drawing.Size(436, 30);
            this.tbCodeAu.TabIndex = 22;
            this.tbCodeAu.Visible = false;
            // 
            // lCodeAu
            // 
            this.lCodeAu.AutoSize = true;
            this.lCodeAu.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCodeAu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lCodeAu.Location = new System.Drawing.Point(76, 355);
            this.lCodeAu.Name = "lCodeAu";
            this.lCodeAu.Size = new System.Drawing.Size(148, 22);
            this.lCodeAu.TabIndex = 23;
            this.lCodeAu.Text = "Код настройки:";
            this.lCodeAu.Visible = false;
            // 
            // bNext2
            // 
            this.bNext2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNext2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bNext2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNext2.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bNext2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bNext2.Location = new System.Drawing.Point(75, 368);
            this.bNext2.Name = "bNext2";
            this.bNext2.Size = new System.Drawing.Size(436, 55);
            this.bNext2.TabIndex = 24;
            this.bNext2.Text = "Далее";
            this.bNext2.UseVisualStyleBackColor = true;
            this.bNext2.Visible = false;
            this.bNext2.Click += new System.EventHandler(this.bNext2_Click);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 445);
            this.Controls.Add(this.bNext2);
            this.Controls.Add(this.lCodeAu);
            this.Controls.Add(this.tbCodeAu);
            this.Controls.Add(this.pbQRCode);
            this.Controls.Add(this.lInstruction);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.lCode);
            this.Controls.Add(this.l2FA);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lUserName);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.cbPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.bNSTU);
            this.Controls.Add(this.bMailRu);
            this.Controls.Add(this.bYandex);
            this.Controls.Add(this.pbDove);
            this.Controls.Add(this.lAuthentication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoveMail: авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pbDove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lAuthentication;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.PictureBox pbDove;
        private System.Windows.Forms.Button bYandex;
        private System.Windows.Forms.ImageList ilAuthentication;
        private System.Windows.Forms.Button bMailRu;
        private System.Windows.Forms.Button bNSTU;
        private System.Windows.Forms.CheckBox cbPassword;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Label l2FA;
        private System.Windows.Forms.Label lCode;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label lInstruction;
        private System.Windows.Forms.PictureBox pbQRCode;
        private System.Windows.Forms.TextBox tbCodeAu;
        private System.Windows.Forms.Label lCodeAu;
        private System.Windows.Forms.Button bNext2;
    }
}