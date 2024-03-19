// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Coursework.Properties;
using AE.Net.Mail;
using System.IO;
using Google.Authenticator;

namespace Coursework
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            Features.Credentials.UserName = tbEmail.Text;
            Features.Credentials.Password = tbPassword.Text;
            string FileLocation = Environment.CurrentDirectory + @"\Users.txt";
            string secretKey = "";
            DialogResult result = DialogResult.No;
            using (FileStream fstream = new System.IO.FileStream(FileLocation, System.IO.FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[fstream.Length];
                fstream.Read(buffer, 0, buffer.Length);
                string textFromFile = Features.decryption_v(Encoding.Default.GetString(buffer), "dream");
                string p = Encoding.Default.GetString(buffer);
                if (textFromFile.Contains(Features.Credentials.UserName))
                {
                    secretKey = textFromFile.Substring(textFromFile.IndexOf(Features.Credentials.UserName) 
                        + Features.Credentials.UserName.Length, 10);
                }
                else
                {
                    result = MessageBox.Show("У вас не подключена двухфакторная аутентификация. " +
                        "Без неё вы не сможете авторизироваться в почтовом клиенте. " +
                        "Настроить двухфакторную аутентификацию с использованием Google Authenticator?",
                        "Двухфакторная аутентификация", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }

            if (secretKey == "")
            if (result == DialogResult.Yes)
            {
                l2FA_Click(sender, e);
                return;
            }
            else if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }

            lEmail.Visible = false;
            tbEmail.Visible = false;
            lPassword.Visible = false;
            tbPassword.Visible = false;
            cbPassword.Visible = false;
            l2FA.Visible = false;
            bEnter.Visible = false;
            bNext.Visible = true;
            lCode.Visible = true;
            tbCode.Visible = true;
        }

        private void bYandex_Click(object sender, EventArgs e)
        {
            Features.mail = "yandex.ru";
            Features.imapHost = "imap.yandex.ru";
            Features.smtpHost = "smtp.yandex.ru";
            Features.sentFolder = "Sent";
            bYandex.Visible = false;
            bMailRu.Visible = false;
            bNSTU.Visible = false;
            lAuthentication.Text = "Авторизация";
            lEmail.Visible = true;
            tbEmail.Visible = true;
            lPassword.Visible = true;
            tbPassword.Visible = true;
            cbPassword.Visible = true;
            bEnter.Visible = true;
            l2FA.Visible = true;
        }

        private void bMailRu_Click(object sender, EventArgs e)
        {
            Features.mail = "mail.ru";
            Features.imapHost = "imap.mail.ru";
            Features.smtpHost = "smtp.mail.ru";
            Features.sentFolder = "Sent";
            bYandex.Visible = false;
            bMailRu.Visible = false;
            bNSTU.Visible = false;
            lAuthentication.Text = "Авторизация";
            lEmail.Visible = true;
            tbEmail.Visible = true;
            lPassword.Visible = true;
            tbPassword.Visible = true;
            cbPassword.Visible = true;
            bEnter.Visible = true;
            l2FA.Visible = true;
        }

        private void bNSTU_Click(object sender, EventArgs e)
        {
            Features.mail = "mail2.nstu.ru";
            Features.imapHost = "mail2.nstu.ru";
            Features.smtpHost = "mail2.nstu.ru";
            Features.sentFolder = "Sent Items";
            bYandex.Visible = false;
            bMailRu.Visible = false;
            bNSTU.Visible = false;
            lAuthentication.Text = "Авторизация";
            lEmail.Visible = true;
            tbEmail.Visible = true;
            lPassword.Visible = true;
            tbPassword.Visible = true;
            cbPassword.Visible = true;
            bEnter.Visible = true;
            l2FA.Visible = true;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text.Trim() != "" && tbEmail.Text.First() != ' ' && !tbEmail.Text.EndsWith(" ") &&
                   tbPassword.Text.Trim() != "" && tbPassword.Text.First() != ' ' && !tbPassword.Text.EndsWith(" "))
            {
                Features.userName = tbUserName.Text;

                MainWin f1 = new MainWin();


                ImapClient imap = new ImapClient();
                imap.Connect(Features.imapHost, 993, true, false);
                try
                {
                    imap.Login(Features.Credentials.UserName, Features.Credentials.Password);
                }
                catch
                {
                    DialogResult result = MessageBox.Show("Неверный логин или пароль.", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        DialogResult = DialogResult.Yes;
                    }
                    return;
                }
                if (imap.IsAuthenticated == false)
                {
                    DialogResult result = MessageBox.Show("Неверный логин или пароль.", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        DialogResult = DialogResult.Yes;
                    }
                    return;
                }


                imap.SelectMailbox("INBOX");
                f1.strIncoming += " " + imap.GetMessageCount().ToString();
                List<string> ListLetters = new List<string>();
                if (imap.GetMessageCount() > 0)
                {
                    MailMessage[] mm = imap.GetMessages(0, imap.GetMessageCount() - 1);
                    mm = mm.Reverse().ToArray();

                    foreach (MailMessage m in mm)
                    {
                        ListLetters.Add(Features.Space(m.From.DisplayName) + m.Subject + "\n");
                    }
                }
                f1.listLetters.Items.AddRange(ListLetters.ToArray());

                if (Features.imapHost != "imap.mail.ru")
                {
                    try
                    {
                        imap.SelectMailbox(Features.sentFolder);
                    }
                    catch
                    {
                        imap.SelectMailbox("Отправленные");
                    }
                    f1.strSent += " " + imap.GetMessageCount().ToString();
                }

                imap.Dispose();

                f1.strEmail = tbEmail.Text;
                this.Visible = false;

                DialogResult formDialogResult = f1.ShowDialog();
                if (formDialogResult == DialogResult.Yes)
                {
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Некорректный ввод данных.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbPassword.Checked) {
                tbPassword.UseSystemPasswordChar = true;
            }
            else if(cbPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            if(lAuthentication.Text == "Настройка электронной почты")
            {
                this.Close();
            }
            else if (bEnter.Visible == true)
            {
                bYandex.Visible = true;
                bMailRu.Visible = true;
                bNSTU.Visible = true;
                lAuthentication.Text = "Настройка электронной почты";
                lEmail.Visible = false;
                tbEmail.Visible = false;
                lPassword.Visible = false;
                tbPassword.Visible = false;
                cbPassword.Visible = false;
                bEnter.Visible = false;
                l2FA.Visible = false;
            }
            else if (bNext.Visible == true)
            {
                lEmail.Visible = true;
                tbEmail.Visible = true;
                lPassword.Visible = true;
                tbPassword.Visible = true;
                cbPassword.Visible = true;
                bEnter.Visible = true;
                l2FA.Visible = true;
                bSave.Visible = false;
                tbPassword.UseSystemPasswordChar = true;
                lCode.Visible = false;
                tbCode.Visible = false;
                bNext.Visible = false;
            }
            else if (bSave.Visible == true)
            {
                lCode.Visible = true;
                tbCode.Visible = true;
                bNext.Visible = true;
                bSave.Visible = false;
                lUserName.Visible = false;
                tbUserName.Visible = false;
                tbPassword.UseSystemPasswordChar = false;
            }
            else if (bNext2.Visible == true)
            {
                lAuthentication.Font = new Font(lAuthentication.Font.FontFamily, 16.2F);
                Size newSize = new Size(437, 360);
                this.MaximumSize = this.MinimumSize = newSize;
                this.Size = newSize;
                lAuthentication.Text = "Авторизация";
                lEmail.Visible = true;
                tbEmail.Visible = true;
                lPassword.Visible = true;
                tbPassword.Visible = true;
                cbPassword.Visible = true;
                bEnter.Visible = true;
                l2FA.Visible = true;
                tbPassword.UseSystemPasswordChar = true;
                lInstruction.Visible = false;
                tbCodeAu.Visible = false;
                lCodeAu.Visible = false;
                pbQRCode.Visible = false;
                bNext2.Visible = false;
            }
        }

        private void bNext_Click(object sender, EventArgs e)
        {

            string FileLocation = Environment.CurrentDirectory + @"\Users.txt";
            string secretKey;
            using (FileStream fstream = new System.IO.FileStream(FileLocation, System.IO.FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[fstream.Length];
                fstream.Read(buffer, 0, buffer.Length);
                string textFromFile = Features.decryption_v(Encoding.Default.GetString(buffer), "dream");
                secretKey = textFromFile.Substring(textFromFile.IndexOf(Features.Credentials.UserName) + Features.Credentials.UserName.Length, 10);
                
            }

            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();

            bool result = tfa.ValidateTwoFactorPIN(secretKey, tbCode.Text);
            if (result == false)
            {
                MessageBox.Show("Неверный код.", "Двухфакторная аутентификация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            lAuthentication.Font = new Font(lAuthentication.Font.FontFamily, 16.2F);
            Size newSize = new Size(437, 360);
            this.MaximumSize = this.MinimumSize = newSize;
            this.Size = newSize;
            lEmail.Visible = false;
            tbEmail.Visible = false;
            lPassword.Visible = false;
            tbPassword.Visible = false;
            cbPassword.Visible = false;
            bEnter.Visible = false;
            lCode.Visible = false;
            tbCode.Visible = false;
            bNext.Visible = false;


            bSave.Visible = true;
            lUserName.Visible = true;
            tbUserName.Visible = true;
        }

        private void l2FA_Click(object sender, EventArgs e)
        {
            Features.Credentials.UserName = tbEmail.Text;
            Features.Credentials.Password = tbPassword.Text;
            string FileLocation = Environment.CurrentDirectory + @"\Users.txt";

            string key = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10);

            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            SetupCode setupInfo = tfa.GenerateSetupCode("DoveMail", Features.Credentials.UserName, key, false, 3);

            string qrCodeImageUrl = setupInfo.QrCodeSetupImageUrl;
            string manualEntrySetupCode = setupInfo.ManualEntryKey;

            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(setupInfo.QrCodeSetupImageUrl.Replace("data:image/png;base64,", ""))))
                this.pbQRCode.Image = Image.FromStream(ms);

            tbCodeAu.Text = manualEntrySetupCode;

            using (FileStream fstream = new System.IO.FileStream(FileLocation, System.IO.FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[fstream.Length];
                fstream.Read(buffer, 0, buffer.Length);
                string textFromFile = Features.decryption_v(Encoding.Default.GetString(buffer), "dream");
                if (textFromFile.Contains('\n' + Features.Credentials.UserName))
                {
                    DialogResult result = MessageBox.Show("У вас уже подключена двухфакторная аутентификация.",
                        "Двухфакторная аутентификация",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        return;
                    }
                }
                else
                {
                    byte[] bufferW = Encoding.Default.GetBytes(Features.encryption_v(textFromFile + '\n' + Features.Credentials.UserName + key + '\n', "dream"));
                    fstream.SetLength(0);
                    fstream.Write(bufferW, 0, bufferW.Length);
                }

            }

            lAuthentication.Text = "Настройка приложения для аутентификации";
            lAuthentication.Font = new Font(lAuthentication.Font.FontFamily, 13.0F);
            Size newSize = new Size(437, 480);
            this.MaximumSize = this.MinimumSize = newSize;
            this.Size = newSize;
            lCodeAu.Location = new Point(57, 360);
            tbCodeAu.Location = new Point(56, 387);
            bNext2.Location = new Point(56, 425);

            lInstruction.Visible = true;
            tbCodeAu.Visible = true;
            lCodeAu.Visible = true;
            pbQRCode.Visible = true;
            bNext2.Visible = true;
            lEmail.Visible = false;
            tbEmail.Visible = false;
            lPassword.Visible = false;
            tbPassword.Visible = false;
            cbPassword.Visible = false;
            bEnter.Visible = false;
            l2FA.Visible = false;
        }

        private void l2FA_MouseEnter(object sender, EventArgs e)
        {
            l2FA.ForeColor = Color.DarkBlue;
        }

        private void l2FA_MouseLeave(object sender, EventArgs e)
        {
            l2FA.ForeColor = Color.Black;
        }

        private void bNext2_Click(object sender, EventArgs e)
        {
            lAuthentication.Text = "Авторизация";
            lAuthentication.Font = new Font(lAuthentication.Font.FontFamily, 16.2F);
            Size newSize = new Size(437, 360);
            this.MaximumSize = this.MinimumSize = newSize;
            this.Size = newSize;
            lCodeAu.Visible = false;
            lInstruction.Visible = false;
            pbQRCode.Visible = false;
            tbCodeAu.Visible = false;
            bNext2.Visible = false;
            bEnter_Click(sender, e);
        }

    }

}
