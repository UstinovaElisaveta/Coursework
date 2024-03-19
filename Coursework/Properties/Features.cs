// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;

namespace Coursework.Properties
{
    public class Features
    {
        public static NetworkCredential Credentials = new NetworkCredential();
        public static string userName;
        public static string mail;
        public static string imapHost;
        public static string smtpHost;
        public static string sentFolder;
        public static AE.Net.Mail.Attachment attachment;
		public static AE.Net.Mail.Attachment attachment2;
		public static AE.Net.Mail.Attachment attachment3;
		public static AE.Net.Mail.Attachment attachment4;
		public static ICollection<AE.Net.Mail.Attachment> attachments;
		public static Lazy<AE.Net.Mail.MailMessage>[] uids;
        public static AE.Net.Mail.MailMessage[] uidsm;
        public static string uid;
        public static string mID;
        public static string Space(string Name)
        {
            int num = 30 - Name.Length;
            Name += " ";
            while(num > 0)
            {
                Name += "  ";
                num--;
            };
            return Name;
        }

		public static string encryption_v(string text, string key)
		{
			string new_text = "";
			string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890 @-_.\r\n";
			char letter1, letter2;
			string new_letter;
			int index;
			for (int i = 0; i < text.Length; i++)
			{
				int j = 0, k = 0;
				letter1 = text.ElementAt(i);
				letter2 = key.ElementAt(i % key.Length);
				while (letter1 != alphabet[j])
					j++;
				while (letter2 != alphabet[k])
					k++;
				index = (j + k) % 69;
				new_letter = alphabet[index].ToString();
				new_text += new_letter;
			}
			return new_text;
		}

		public static string decryption_v(string text, string key)
		{
			string new_text = "";
			string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890 @-_.\r\n";
			char letter1, letter2;
			string new_letter;
			int index;
			for (int i = 0; i < text.Length; i++)
			{
				int j = 0, k = 0;
				letter1 = text.ElementAt(i);
				letter2 = key.ElementAt(i % key.Length);
				while (letter1 != alphabet[j])
					j++;
				while (letter2 != alphabet[k])
					k++;
				index = (j - k + 69) % 69;
				new_letter = alphabet[index].ToString();
				new_text += new_letter;
			}
			return new_text;
		}

		public static void download(AE.Net.Mail.Attachment a)
		{
			string fileName = Path.GetFileName(a.Filename);

			string[] allFoundFiles = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\",
				fileName, SearchOption.AllDirectories);
			if (allFoundFiles.Length == 0)
			{
				a.Save(new System.IO.FileStream
				(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\" + fileName, System.IO.FileMode.Create));
			}
			else
			{
				int i = 0;
				while (allFoundFiles.Length != 0)
				{
					i++;
					allFoundFiles = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\",
						Path.GetFileNameWithoutExtension(a.Filename) + "-" + i.ToString() +
						Path.GetExtension(a.Filename), SearchOption.AllDirectories);
				}
				a.Save(new System.IO.FileStream
				(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\" +
					Path.GetFileNameWithoutExtension(a.Filename) + "-" + i.ToString() +
					Path.GetExtension(a.Filename), System.IO.FileMode.Create));
			}
		}
	}
}
