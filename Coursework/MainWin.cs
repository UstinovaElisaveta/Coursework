// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Coursework.Properties;
using AE.Net.Mail;
using System.IO;

namespace Coursework
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private void bNewMessage_Click(object sender, EventArgs e)
        {
            SendPage fSent = new SendPage();
            DialogResult formDialogResult = fSent.ShowDialog();
            if (formDialogResult == DialogResult.OK)
            {
                fSent.Close();
            }
        }
        private void lbLetters_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImapClient imap = new ImapClient(Features.imapHost, Features.Credentials.UserName, Features.Credentials.Password,
                AuthMethods.Login, 993, true);
            if (this.Text == "DoveMail: входящие")
            {
                imap.SelectMailbox("INBOX");
            }
            else 
            {
                try
                {
                    imap.SelectMailbox(Features.sentFolder);
                }
                catch
                {
                    imap.SelectMailbox("Отправленные");
                }
            }

            AE.Net.Mail.MailMessage m;

            if (tbSearch.Text == "" || tbSearch.Text == null)
            {
                m = imap.GetMessage(imap.GetMessageCount() - 1 - lbLetters.SelectedIndex);
                Features.uid = m.Uid;
            }
            else
            {
                try
                {
                    m = imap.GetMessage(Features.uids.ElementAt(lbLetters.SelectedIndex).Value.Uid);
                    Features.uid = m.Uid;
                }
                catch
                {
                    m = imap.GetMessage(Features.uidsm.ElementAt(lbLetters.SelectedIndex).Uid);
                    Features.uid = m.Uid;
                }
            }

            imap.Dispose();

            ICollection<AE.Net.Mail.Attachment> a = m.Attachments;
            if (a.Count > 0)
            {
                bAttachment.Text = Path.GetFileName(a.ElementAt(0).Filename);
                Features.attachment = a.ElementAt(0);
                bAttachment.Visible = true;
                if (a.Count > 1)
                {
                    bAttachment2.Text = Path.GetFileName(a.ElementAt(1).Filename);
                    Features.attachment2 = a.ElementAt(1);
                    bAttachment2.Visible = true;
                    if (a.Count > 2)
                    {
                        bAttachment3.Text = Path.GetFileName(a.ElementAt(2).Filename);
                        Features.attachment3 = a.ElementAt(2);
                        bAttachment3.Visible = true;
                        if (a.Count == 4)
                        {
                            bAttachment4.Text = Path.GetFileName(a.ElementAt(2).Filename);
                            Features.attachment4 = a.ElementAt(3);
                            bAttachment4.Visible = true;
                        }
                        else if(a.Count > 4)
                        {
                            bAttachment4.Text = "Скачать всё (" + a.Count + ")";
                            Features.attachments = a;
                            bAttachment4.Visible = true;
                        }

                    }
                }
                
                tbTextLetter.Height = 255;
                lbLetters.Visible = false;
            }


            var doc = new HtmlAgilityPack.HtmlDocument();
            if (m.Body != null)
            {
                doc.LoadHtml(m.Body);
            }
            else
            {
                doc.LoadHtml("");
            }

            string innerText = doc.DocumentNode.InnerText;
            
            innerText = innerText.Replace("&#8202;", "\r\n");
            innerText = innerText.Replace("&lt;", "<");
            innerText = innerText.Replace("&gt;", ">");

            bool firstPass = false;
            string strTo = m.To.ElementAt(0).Address;
            foreach(var s in m.To)
            {
                if(firstPass)
                strTo += ", " + s.Address;
                firstPass = true;
            }

            tbFromTo.Text = "От: " + m.From.DisplayName + "  <" + m.From.Address + ">\r\n" +
                "Кому: " + strTo + "\r\n"+
                "Отправлено: " + m.Date + "\r\n" + 
                "Тема: " + m.Subject;
            tbTextLetter.Text = innerText.Replace("&nbsp;", "\r\n");
            tbTextLetter.Visible = true;
            tbFromTo.Visible = true;
            bReply.Visible = true;
            bExit.Visible = false;
            bInformation.Visible = false;
            bDelete.Visible = true;
            bSearch.Visible = false;
            tbSearch.Visible = false;
        }

        private void bIncoming_Click(object sender, EventArgs e)
        {
            this.Text = "DoveMail: входящие";
            ImapClient imap = new ImapClient(Features.imapHost, Features.Credentials.UserName, 
                Features.Credentials.Password, AuthMethods.Login, 993, true);
            imap.SelectMailbox("INBOX");
            bIncoming.Text = "   Входящие " + imap.GetMessageCount().ToString();
            List<string> ListLetters = new List<string>();
            if (imap.GetMessageCount() > 0)
            {
                AE.Net.Mail.MailMessage[] mm = imap.GetMessages(0, imap.GetMessageCount() - 1);
                mm = mm.Reverse().ToArray();
                foreach (AE.Net.Mail.MailMessage m in mm)
                {
                    ListLetters.Add(Features.Space(m.From.DisplayName) + m.Subject);
                }
            }

            imap.Dispose();

            lbLetters.Items.Clear();
            lbLetters.Items.AddRange(ListLetters.ToArray());
            tbSearch.Text = "";
            tbTextLetter.Visible = false;
            tbFromTo.Visible = false;
            bReply.Visible = false;
            bExit.Visible = true;
            bInformation.Visible = true;
            bDelete.Visible = false;
            bSearch.Visible = true;
            tbSearch.Visible = true;
            bAttachment.Visible = false;
            bAttachment2.Visible = false;
            bAttachment3.Visible = false;
            bAttachment4.Visible = false;
            lbLetters.Visible = true;
            tbTextLetter.Height = 310;
        }

        private void bSent_Click(object sender, EventArgs e)
        {
            this.Text = "DoveMail: отправленные";
            ImapClient imap = new ImapClient(Features.imapHost, Features.Credentials.UserName, Features.Credentials.Password,
                AuthMethods.Login, 993, true);
            bSent.Text = "   Отправленные ";
         
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
                bSent.Text += imap.GetMessageCount().ToString();
                List<string> ListLetters = new List<string>();
                if (imap.GetMessageCount() > 0)
                {
                    AE.Net.Mail.MailMessage[] mm = imap.GetMessages(0, imap.GetMessageCount() - 1);
                    mm = mm.Reverse().ToArray();
                    foreach (AE.Net.Mail.MailMessage m in mm)
                    {
                        ListLetters.Add(Features.Space(m.From.DisplayName) + m.Subject);
                    }
                }

                lbLetters.Items.Clear();
                lbLetters.Items.AddRange(ListLetters.ToArray());
            }
            imap.Dispose();

            tbSearch.Text = "";
            tbTextLetter.Visible = false;
            tbFromTo.Visible = false;
            bReply.Visible = false;
            bExit.Visible = true;
            bInformation.Visible = true;
            bDelete.Visible = false;
            bSearch.Visible = true;
            tbSearch.Visible = true;
            bAttachment.Visible = false;
            bAttachment2.Visible = false;
            bAttachment3.Visible = false;
            bAttachment4.Visible = false;
            lbLetters.Visible = true;
            tbTextLetter.Height = 310;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                DialogResult = DialogResult.Yes;
            }
        }

        private void bReply_Click(object sender, EventArgs e)
        {
            ImapClient imap = new ImapClient(Features.imapHost, Features.Credentials.UserName, Features.Credentials.Password,
                AuthMethods.Login, 993, true);
            SendPage fReply = new SendPage();
            AE.Net.Mail.MailMessage m = imap.GetMessage(Features.uid);
            imap.Dispose();
            bool firstPass = false;
            string sTo = m.To.ElementAt(0).Address;
            foreach (var s in m.To)
            {
                if (firstPass)
                    sTo += ", " + s.Address;
                firstPass = true;
            }
            fReply.Text = "DoveMail: ответ на письмо";
            fReply.strTo = m.From.Address;
            fReply.strSubject = "Re: " + m.Subject;
            fReply.strBody = "\r\n\r\n\r\n" + "______________________________" + "\r\n" +
                "От: " + m.From.DisplayName + "  <" + m.From.Address + ">\r\n" +
                "Кому: " + sTo + "\r\n" +
                "Отправлено: " + m.Date + "\r\n" +
                "Тема: " + m.Subject + "\r\n\r\n" + tbTextLetter.Text;
            fReply.cTo = Color.Black;
            fReply.cSubject = Color.Black;
            fReply.cBody = Color.Black;
            Features.mID = m.MessageID;

            DialogResult formDialogResult = fReply.ShowDialog();
            if (formDialogResult == DialogResult.OK)
            {
                fReply.Close();
            }
        }

        private void bAttachment_Click(object sender, EventArgs e)
        {
            Features.download(Features.attachment);
        }

        private void bAttachment2_Click(object sender, EventArgs e)
        {
            Features.download(Features.attachment2);
        }

        private void bAttachment3_Click(object sender, EventArgs e)
        {
            Features.download(Features.attachment3);
        }

        private void bAttachment4_Click(object sender, EventArgs e)
        {
            if (!bAttachment4.Text.Contains("Скачать"))
            {
                Features.download(Features.attachment4);
            }
            else
            {
                foreach (AE.Net.Mail.Attachment a in Features.attachments)
                {
                    Features.download(a);
                }
            }
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            ImapClient imap = new ImapClient(Features.imapHost, Features.Credentials.UserName, Features.Credentials.Password,
                AuthMethods.Login, 993, true);
            if (this.Text == "DoveMail: входящие")
            {
                imap.SelectMailbox("INBOX");
            }
            else
            {
                try
                {
                    imap.SelectMailbox(Features.sentFolder);
                }
                catch
                {
                    imap.SelectMailbox("Отправленные");
                }
                
            }

            List<string> ListLetters = new List<string>();
            if (imap.GetMessageCount() > 0)
            {

                try
                {
                    Lazy<AE.Net.Mail.MailMessage>[] mm = imap.SearchMessages(SearchCondition.Text(tbSearch.Text)).ToArray();
                    mm = mm.Reverse().ToArray();

                    Features.uids = mm;

                    foreach (var m in mm)
                    {
                        ListLetters.Add(Features.Space(m.Value.From.DisplayName) + m.Value.Subject);
                    }
                }
                catch
                {
                    AE.Net.Mail.MailMessage[] mes = imap.GetMessages(0, imap.GetMessageCount() - 1);
                    int i = 0, num = 0;

                    foreach (var m in mes)
                    {

                        if (m.Subject.Contains(tbSearch.Text))
                        {
                            num++;

                        }
                    }

                    AE.Net.Mail.MailMessage[] newMes = new AE.Net.Mail.MailMessage[num];

                    foreach (var m in mes)
                    {

                        if (m.Subject.Contains(tbSearch.Text))
                        {
                            newMes[i] = m;
                            i++;
                        }
                    }

                    Features.uidsm = newMes;

                    foreach (var m in newMes)
                    {
                        ListLetters.Add(Features.Space(m.From.DisplayName) + m.Subject);
                    }
                }
            }
            imap.Dispose();
                lbLetters.Items.Clear();
                lbLetters.Items.AddRange(ListLetters.ToArray());
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            ImapClient imap = new ImapClient(Features.imapHost, Features.Credentials.UserName, Features.Credentials.Password,
                AuthMethods.Login, 993, true);
            if (this.Text == "DoveMail: входящие")
            {
                imap.SelectMailbox("INBOX");
            }
            else
            {
                try
                {
                    imap.SelectMailbox(Features.sentFolder);
                }
                catch
                {
                    imap.SelectMailbox("Отправленные");
                }
            }
            imap.DeleteMessage(Features.uid);
            imap.Dispose();
            bIncoming_Click(sender, e);

        }

        private void bInformation_Click(object sender, EventArgs e)
        {
            this.Text = "DoveMail: сведения";
            tbFromTo.Text = "Сведения о DoveMail";
            tbTextLetter.Text = "   DoveMail - бесплатная почтовая программа для личной и корпоративной почты.\r\n\r\n" +
                "   Для Вашего удобства есть возможность работы с Yandex, Mail.ru и корпоративной почтой НГТУ с поддержкой IMAP и SMTP.\r\n\r\n" +
                "   Функции:\r\n" +
                "       • возможность получать, отправлять и удалять электронные письма;\r\n" +
                "       • способность отвечать на них;\r\n" +
                "       • распределение почты по папкам \"Входящие\" и \"Отправленные\";\r\n" +
                "       • поиск в выбранной папке.\r\n\r\n" +
                "   Благодарим, что пользуетесь нашим почтовым клиентом!\r\n\r\n" + 
                "   Создатель: Устинова Елизавета Олеговна.";
            tbTextLetter.Visible = true;
            tbFromTo.Visible = true;
            bExit.Visible = false;
            bInformation.Visible = false;
            bSearch.Visible = false;
            tbSearch.Visible = false;
        }

        public ListBox listLetters
        {
            get => lbLetters;
            set => lbLetters = value;
        }

        public string strIncoming
        {
            get => bIncoming.Text;
            set => bIncoming.Text = value;
        }
        public string strSent
        {
            get => bSent.Text;
            set => bSent.Text = value;
        }

        public string strEmail
        {
            get => lEmail.Text;
            set => lEmail.Text = value;
        }
    }
}
