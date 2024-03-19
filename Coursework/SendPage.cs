// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Mail;
using Coursework.Properties;
using AE.Net.Mail;

namespace Coursework
{
    public partial class SendPage : Form //TODO: V3073 https://pvs-studio.com/en/docs/warnings/v3073/ Not all IDisposable members are properly disposed. Call 'Dispose' when disposing 'SendPage' class. Inspect: m.
    {
        public SendPage()
        {
            InitializeComponent();
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage m = new System.Net.Mail.MailMessage();
            MailAddress from = new MailAddress(Features.Credentials.UserName, Features.userName);
            MailAddress to = new MailAddress(tbTo.Text);
            m.To.Add(to);
            m.Bcc.Add(Features.Credentials.UserName);
            if (this.Text == "DoveMail: ответ на письмо")
            {
                m.ReplyToList.Add(to);
                m.Headers.Add("In-Reply-To", Features.mID);
                m.Headers.Add("References", Features.mID);
            }
            m.From = from;
            m.Subject = tbSubject.Text;
            m.Body = tbBody.Text;

            SmtpClient smtp = new SmtpClient(Features.smtpHost, 587);
            smtp.Credentials = Features.Credentials;
            smtp.EnableSsl = true;
            smtp.Send(m);
            smtp.Dispose();
            m.Dispose();

            ImapClient imap = new ImapClient(Features.imapHost, Features.Credentials.UserName, Features.Credentials.Password,
                AuthMethods.Login, 993, true);
            imap.SelectMailbox("INBOX");
            AE.Net.Mail.MailMessage mes = imap.GetMessage(imap.GetMessageCount() - 1);
            imap.Encoding = mes.Encoding;
            imap.AppendMail(mes, Features.sentFolder);
            imap.DeleteMessage(mes.Uid);
            imap.Dispose();

            DialogResult = DialogResult.OK;
        }

        private void bFile_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage m = new System.Net.Mail.MailMessage();
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog(this) == DialogResult.OK)
            {
                m.Attachments.Add(new System.Net.Mail.Attachment(ofd.FileName));
                if (!bStatusFile.Visible) {
                    bStatusFile.Text = ofd.SafeFileName;
                    bStatusFile.Visible = true;
                }
                else if(!bStatusFile2.Visible)
                {
                    bStatusFile2.Text = ofd.SafeFileName;
                    bStatusFile2.Visible = true;
                }
                else if (!bStatusFile3.Visible)
                {
                    bStatusFile3.Text = ofd.SafeFileName;
                    bStatusFile3.Visible = true;
                }
                else if (!bStatusFile4.Visible)
                {
                    bStatusFile4.Text = ofd.SafeFileName;
                    bStatusFile4.Visible = true;
                }
                else if (bStatusFile4.Visible)
                {
                    bStatusFile4.Text = bStatusFile4.Text + ", " + ofd.SafeFileName;
                }
            }
            m.Dispose();
        }

        private void tbTo_Click(object sender, EventArgs e)
        {
            tbTo.ForeColor = Color.Black;
            if (tbTo.Text == " Кому") 
            {
                tbTo.Text = "";
                tbTo.ForeColor = Color.Black;
            }
        }

        private void tbSubject_Click(object sender, EventArgs e)
        {
            tbSubject.ForeColor = Color.Black;
            if (tbSubject.Text == " Тема")
            {
                tbSubject.Text = "";
                tbSubject.ForeColor = Color.Black;
            }
        }

        private void tbBody_Click(object sender, EventArgs e)
        {
            tbBody.ForeColor = Color.Black;
            if (tbBody.Text == "Текст письма")
            {
                tbBody.Text = "";
                tbBody.ForeColor = Color.Black;
            }
        }

        public string strTo
        {
            get => tbTo.Text;
            set => tbTo.Text = value;
        }

        public string strSubject
        {
            get => tbSubject.Text;
            set => tbSubject.Text = value;
        }

        public string strBody
        {
            get => tbBody.Text;
            set => tbBody.Text = value;
        }

        public Color cTo
        {
            get => tbTo.ForeColor;
            set => tbTo.ForeColor = value;
        }

        public Color cSubject
        {
            get => tbSubject.ForeColor;
            set => tbSubject.ForeColor = value;
        }

        public Color cBody
        {
            get => tbBody.ForeColor;
            set => tbBody.ForeColor = value;
        }
    }
}
