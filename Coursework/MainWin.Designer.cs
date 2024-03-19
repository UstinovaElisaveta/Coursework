
namespace Coursework
{
    partial class MainWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.label1 = new System.Windows.Forms.Label();
            this.ilExit = new System.Windows.Forms.ImageList(this.components);
            this.lbLetters = new System.Windows.Forms.ListBox();
            this.tbTextLetter = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bReply = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bNewMessage = new System.Windows.Forms.Button();
            this.bIncoming = new System.Windows.Forms.Button();
            this.bSent = new System.Windows.Forms.Button();
            this.bInformation = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bAttachment = new System.Windows.Forms.Button();
            this.tbFromTo = new System.Windows.Forms.TextBox();
            this.bAttachment2 = new System.Windows.Forms.Button();
            this.bAttachment3 = new System.Windows.Forms.Button();
            this.bAttachment4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Liberation Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "DoveMail";
            // 
            // ilExit
            // 
            this.ilExit.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilExit.ImageStream")));
            this.ilExit.TransparentColor = System.Drawing.Color.Transparent;
            this.ilExit.Images.SetKeyName(0, "exit.ico");
            this.ilExit.Images.SetKeyName(1, "letter.ico");
            this.ilExit.Images.SetKeyName(2, "reply.ico");
            this.ilExit.Images.SetKeyName(3, "inbox_48030.ico");
            this.ilExit.Images.SetKeyName(4, "mailsent_104386.ico");
            this.ilExit.Images.SetKeyName(5, "output-onlinepngtools.png");
            this.ilExit.Images.SetKeyName(6, "output-onlinepngtools(2).png");
            this.ilExit.Images.SetKeyName(7, "output-onlinepngtools(1).png");
            this.ilExit.Images.SetKeyName(8, "output-onlinepngtools(3).png");
            this.ilExit.Images.SetKeyName(9, "delete_icon_149949.ico");
            // 
            // lbLetters
            // 
            this.lbLetters.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLetters.FormattingEnabled = true;
            this.lbLetters.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbLetters.ItemHeight = 22;
            this.lbLetters.Location = new System.Drawing.Point(290, 172);
            this.lbLetters.Name = "lbLetters";
            this.lbLetters.Size = new System.Drawing.Size(763, 488);
            this.lbLetters.TabIndex = 3;
            this.lbLetters.SelectedIndexChanged += new System.EventHandler(this.lbLetters_SelectedIndexChanged);
            // 
            // tbTextLetter
            // 
            this.tbTextLetter.BackColor = System.Drawing.SystemColors.Window;
            this.tbTextLetter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTextLetter.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTextLetter.Location = new System.Drawing.Point(290, 277);
            this.tbTextLetter.Multiline = true;
            this.tbTextLetter.Name = "tbTextLetter";
            this.tbTextLetter.ReadOnly = true;
            this.tbTextLetter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTextLetter.Size = new System.Drawing.Size(763, 383);
            this.tbTextLetter.TabIndex = 5;
            this.tbTextLetter.Visible = false;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEmail.Location = new System.Drawing.Point(0, 112);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(56, 22);
            this.lEmail.TabIndex = 6;
            this.lEmail.Text = "email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coursework.Properties.Resources.imgonline_com_ua_Replace_color_8TALiKCMk8L;
            this.pictureBox1.Location = new System.Drawing.Point(13, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // bReply
            // 
            this.bReply.BackColor = System.Drawing.Color.White;
            this.bReply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bReply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bReply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReply.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bReply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bReply.ImageIndex = 8;
            this.bReply.ImageList = this.ilExit;
            this.bReply.Location = new System.Drawing.Point(-1, 589);
            this.bReply.Name = "bReply";
            this.bReply.Size = new System.Drawing.Size(294, 36);
            this.bReply.TabIndex = 8;
            this.bReply.Text = "   Ответить";
            this.bReply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bReply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bReply.UseVisualStyleBackColor = false;
            this.bReply.Visible = false;
            this.bReply.Click += new System.EventHandler(this.bReply_Click);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.White;
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.ForeColor = System.Drawing.Color.Black;
            this.bExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bExit.ImageIndex = 6;
            this.bExit.ImageList = this.ilExit;
            this.bExit.Location = new System.Drawing.Point(-1, 589);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(294, 36);
            this.bExit.TabIndex = 7;
            this.bExit.Text = "   Выйти";
            this.bExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bNewMessage
            // 
            this.bNewMessage.BackColor = System.Drawing.Color.White;
            this.bNewMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNewMessage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bNewMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNewMessage.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bNewMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNewMessage.ImageIndex = 5;
            this.bNewMessage.ImageList = this.ilExit;
            this.bNewMessage.Location = new System.Drawing.Point(-1, 172);
            this.bNewMessage.Name = "bNewMessage";
            this.bNewMessage.Size = new System.Drawing.Size(294, 34);
            this.bNewMessage.TabIndex = 4;
            this.bNewMessage.Text = "   Написать";
            this.bNewMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNewMessage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bNewMessage.UseVisualStyleBackColor = false;
            this.bNewMessage.Click += new System.EventHandler(this.bNewMessage_Click);
            // 
            // bIncoming
            // 
            this.bIncoming.BackColor = System.Drawing.Color.White;
            this.bIncoming.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bIncoming.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bIncoming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIncoming.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bIncoming.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bIncoming.ImageIndex = 3;
            this.bIncoming.ImageList = this.ilExit;
            this.bIncoming.Location = new System.Drawing.Point(-1, 207);
            this.bIncoming.Name = "bIncoming";
            this.bIncoming.Size = new System.Drawing.Size(294, 34);
            this.bIncoming.TabIndex = 1;
            this.bIncoming.Text = "   Входящие";
            this.bIncoming.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bIncoming.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bIncoming.UseVisualStyleBackColor = false;
            this.bIncoming.Click += new System.EventHandler(this.bIncoming_Click);
            // 
            // bSent
            // 
            this.bSent.BackColor = System.Drawing.Color.White;
            this.bSent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bSent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSent.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSent.ImageIndex = 4;
            this.bSent.ImageList = this.ilExit;
            this.bSent.Location = new System.Drawing.Point(-1, 244);
            this.bSent.Name = "bSent";
            this.bSent.Size = new System.Drawing.Size(294, 34);
            this.bSent.TabIndex = 2;
            this.bSent.Text = "   Отправленные";
            this.bSent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bSent.UseVisualStyleBackColor = false;
            this.bSent.Click += new System.EventHandler(this.bSent_Click);
            // 
            // bInformation
            // 
            this.bInformation.BackColor = System.Drawing.Color.White;
            this.bInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bInformation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInformation.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bInformation.ForeColor = System.Drawing.Color.Black;
            this.bInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bInformation.ImageIndex = 7;
            this.bInformation.ImageList = this.ilExit;
            this.bInformation.Location = new System.Drawing.Point(-1, 625);
            this.bInformation.Name = "bInformation";
            this.bInformation.Size = new System.Drawing.Size(294, 36);
            this.bInformation.TabIndex = 10;
            this.bInformation.Text = "   Сведения о DoveMail";
            this.bInformation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bInformation.UseVisualStyleBackColor = false;
            this.bInformation.Click += new System.EventHandler(this.bInformation_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(290, 142);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(643, 30);
            this.tbSearch.TabIndex = 11;
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.White;
            this.bSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSearch.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSearch.ImageList = this.ilExit;
            this.bSearch.Location = new System.Drawing.Point(930, 142);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(128, 31);
            this.bSearch.TabIndex = 12;
            this.bSearch.Text = "Поиск";
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.White;
            this.bDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelete.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDelete.ImageIndex = 9;
            this.bDelete.ImageList = this.ilExit;
            this.bDelete.Location = new System.Drawing.Point(-1, 624);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(294, 36);
            this.bDelete.TabIndex = 13;
            this.bDelete.Text = "   Удалить";
            this.bDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Visible = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bAttachment
            // 
            this.bAttachment.AutoEllipsis = true;
            this.bAttachment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAttachment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bAttachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAttachment.Font = new System.Drawing.Font("Liberation Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAttachment.Location = new System.Drawing.Point(299, 623);
            this.bAttachment.MaximumSize = new System.Drawing.Size(183, 37);
            this.bAttachment.Name = "bAttachment";
            this.bAttachment.Size = new System.Drawing.Size(183, 37);
            this.bAttachment.TabIndex = 14;
            this.bAttachment.Text = "Attachments";
            this.bAttachment.UseVisualStyleBackColor = true;
            this.bAttachment.Visible = false;
            this.bAttachment.Click += new System.EventHandler(this.bAttachment_Click);
            // 
            // tbFromTo
            // 
            this.tbFromTo.BackColor = System.Drawing.SystemColors.Window;
            this.tbFromTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFromTo.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFromTo.Location = new System.Drawing.Point(290, 172);
            this.tbFromTo.Multiline = true;
            this.tbFromTo.Name = "tbFromTo";
            this.tbFromTo.ReadOnly = true;
            this.tbFromTo.Size = new System.Drawing.Size(768, 106);
            this.tbFromTo.TabIndex = 15;
            this.tbFromTo.TabStop = false;
            this.tbFromTo.Visible = false;
            // 
            // bAttachment2
            // 
            this.bAttachment2.AutoEllipsis = true;
            this.bAttachment2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAttachment2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bAttachment2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAttachment2.Font = new System.Drawing.Font("Liberation Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAttachment2.Location = new System.Drawing.Point(479, 623);
            this.bAttachment2.MaximumSize = new System.Drawing.Size(183, 37);
            this.bAttachment2.Name = "bAttachment2";
            this.bAttachment2.Size = new System.Drawing.Size(183, 37);
            this.bAttachment2.TabIndex = 16;
            this.bAttachment2.Text = "Attachments";
            this.bAttachment2.UseVisualStyleBackColor = true;
            this.bAttachment2.Visible = false;
            this.bAttachment2.Click += new System.EventHandler(this.bAttachment2_Click);
            // 
            // bAttachment3
            // 
            this.bAttachment3.AutoEllipsis = true;
            this.bAttachment3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAttachment3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bAttachment3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAttachment3.Font = new System.Drawing.Font("Liberation Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAttachment3.Location = new System.Drawing.Point(659, 623);
            this.bAttachment3.MaximumSize = new System.Drawing.Size(183, 37);
            this.bAttachment3.Name = "bAttachment3";
            this.bAttachment3.Size = new System.Drawing.Size(183, 37);
            this.bAttachment3.TabIndex = 17;
            this.bAttachment3.Text = "Attachments";
            this.bAttachment3.UseVisualStyleBackColor = true;
            this.bAttachment3.Visible = false;
            this.bAttachment3.Click += new System.EventHandler(this.bAttachment3_Click);
            // 
            // bAttachment4
            // 
            this.bAttachment4.AutoEllipsis = true;
            this.bAttachment4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAttachment4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bAttachment4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAttachment4.Font = new System.Drawing.Font("Liberation Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAttachment4.Location = new System.Drawing.Point(838, 623);
            this.bAttachment4.MaximumSize = new System.Drawing.Size(183, 37);
            this.bAttachment4.Name = "bAttachment4";
            this.bAttachment4.Size = new System.Drawing.Size(183, 37);
            this.bAttachment4.TabIndex = 18;
            this.bAttachment4.Text = "Attachments";
            this.bAttachment4.UseVisualStyleBackColor = true;
            this.bAttachment4.Visible = false;
            this.bAttachment4.Click += new System.EventHandler(this.bAttachment4_Click);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 683);
            this.Controls.Add(this.bAttachment4);
            this.Controls.Add(this.bAttachment3);
            this.Controls.Add(this.bAttachment2);
            this.Controls.Add(this.tbFromTo);
            this.Controls.Add(this.bAttachment);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTextLetter);
            this.Controls.Add(this.lbLetters);
            this.Controls.Add(this.bReply);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bInformation);
            this.Controls.Add(this.bSent);
            this.Controls.Add(this.bIncoming);
            this.Controls.Add(this.bNewMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1072, 730);
            this.MinimumSize = new System.Drawing.Size(1072, 730);
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoveMail: входящие";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bIncoming;
        private System.Windows.Forms.Button bSent;
        private System.Windows.Forms.ListBox lbLetters;
        private System.Windows.Forms.Button bNewMessage;
        private System.Windows.Forms.TextBox tbTextLetter;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.ImageList ilExit;
        private System.Windows.Forms.Button bReply;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bInformation;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bAttachment;
        private System.Windows.Forms.TextBox tbFromTo;
        private System.Windows.Forms.Button bAttachment2;
        private System.Windows.Forms.Button bAttachment3;
        private System.Windows.Forms.Button bAttachment4;
    }
}