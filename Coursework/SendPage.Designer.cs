
namespace Coursework
{
    partial class SendPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendPage));
            this.bSend = new System.Windows.Forms.Button();
            this.ilSend = new System.Windows.Forms.ImageList(this.components);
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.tbBody = new System.Windows.Forms.TextBox();
            this.bFile = new System.Windows.Forms.Button();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.bStatusFile = new System.Windows.Forms.Button();
            this.bStatusFile2 = new System.Windows.Forms.Button();
            this.bStatusFile3 = new System.Windows.Forms.Button();
            this.bStatusFile4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSend
            // 
            this.bSend.BackColor = System.Drawing.SystemColors.Window;
            this.bSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSend.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bSend.ImageIndex = 2;
            this.bSend.ImageList = this.ilSend;
            this.bSend.Location = new System.Drawing.Point(755, 29);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(66, 31);
            this.bSend.TabIndex = 0;
            this.bSend.UseVisualStyleBackColor = false;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // ilSend
            // 
            this.ilSend.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSend.ImageStream")));
            this.ilSend.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSend.Images.SetKeyName(0, "output-onlinepngtools(5).png");
            this.ilSend.Images.SetKeyName(1, "output-onlinepngtools(4).png");
            this.ilSend.Images.SetKeyName(2, "mailsent_104386.ico");
            // 
            // tbTo
            // 
            this.tbTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTo.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTo.ForeColor = System.Drawing.Color.Gray;
            this.tbTo.Location = new System.Drawing.Point(29, 60);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(792, 30);
            this.tbTo.TabIndex = 3;
            this.tbTo.Text = " Кому";
            this.tbTo.Click += new System.EventHandler(this.tbTo_Click);
            // 
            // tbSubject
            // 
            this.tbSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSubject.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSubject.ForeColor = System.Drawing.Color.Gray;
            this.tbSubject.Location = new System.Drawing.Point(29, 89);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(792, 30);
            this.tbSubject.TabIndex = 4;
            this.tbSubject.Text = " Тема";
            this.tbSubject.Click += new System.EventHandler(this.tbSubject_Click);
            // 
            // tbBody
            // 
            this.tbBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBody.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBody.ForeColor = System.Drawing.Color.Gray;
            this.tbBody.Location = new System.Drawing.Point(29, 117);
            this.tbBody.Multiline = true;
            this.tbBody.Name = "tbBody";
            this.tbBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbBody.Size = new System.Drawing.Size(792, 526);
            this.tbBody.TabIndex = 5;
            this.tbBody.Tag = "";
            this.tbBody.Text = "Текст письма";
            this.tbBody.Click += new System.EventHandler(this.tbBody_Click);
            // 
            // bFile
            // 
            this.bFile.BackColor = System.Drawing.Color.White;
            this.bFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFile.Font = new System.Drawing.Font("Liberation Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bFile.ForeColor = System.Drawing.Color.Black;
            this.bFile.ImageIndex = 1;
            this.bFile.ImageList = this.ilSend;
            this.bFile.Location = new System.Drawing.Point(692, 29);
            this.bFile.Name = "bFile";
            this.bFile.Size = new System.Drawing.Size(66, 31);
            this.bFile.TabIndex = 6;
            this.bFile.UseVisualStyleBackColor = false;
            this.bFile.Click += new System.EventHandler(this.bFile_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // bStatusFile
            // 
            this.bStatusFile.AutoEllipsis = true;
            this.bStatusFile.BackColor = System.Drawing.Color.White;
            this.bStatusFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bStatusFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bStatusFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStatusFile.Font = new System.Drawing.Font("Liberation Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStatusFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bStatusFile.ImageIndex = 0;
            this.bStatusFile.ImageList = this.ilSend;
            this.bStatusFile.Location = new System.Drawing.Point(29, 649);
            this.bStatusFile.MaximumSize = new System.Drawing.Size(183, 40);
            this.bStatusFile.Name = "bStatusFile";
            this.bStatusFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bStatusFile.Size = new System.Drawing.Size(183, 40);
            this.bStatusFile.TabIndex = 9;
            this.bStatusFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bStatusFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bStatusFile.UseVisualStyleBackColor = false;
            this.bStatusFile.Visible = false;
            // 
            // bStatusFile2
            // 
            this.bStatusFile2.AutoEllipsis = true;
            this.bStatusFile2.BackColor = System.Drawing.Color.White;
            this.bStatusFile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bStatusFile2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bStatusFile2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStatusFile2.Font = new System.Drawing.Font("Liberation Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStatusFile2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bStatusFile2.ImageIndex = 0;
            this.bStatusFile2.ImageList = this.ilSend;
            this.bStatusFile2.Location = new System.Drawing.Point(213, 649);
            this.bStatusFile2.MaximumSize = new System.Drawing.Size(183, 40);
            this.bStatusFile2.Name = "bStatusFile2";
            this.bStatusFile2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bStatusFile2.Size = new System.Drawing.Size(183, 40);
            this.bStatusFile2.TabIndex = 10;
            this.bStatusFile2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bStatusFile2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bStatusFile2.UseVisualStyleBackColor = false;
            this.bStatusFile2.Visible = false;
            // 
            // bStatusFile3
            // 
            this.bStatusFile3.AutoEllipsis = true;
            this.bStatusFile3.BackColor = System.Drawing.Color.White;
            this.bStatusFile3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bStatusFile3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bStatusFile3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStatusFile3.Font = new System.Drawing.Font("Liberation Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStatusFile3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bStatusFile3.ImageIndex = 0;
            this.bStatusFile3.ImageList = this.ilSend;
            this.bStatusFile3.Location = new System.Drawing.Point(396, 649);
            this.bStatusFile3.MaximumSize = new System.Drawing.Size(183, 40);
            this.bStatusFile3.Name = "bStatusFile3";
            this.bStatusFile3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bStatusFile3.Size = new System.Drawing.Size(183, 40);
            this.bStatusFile3.TabIndex = 11;
            this.bStatusFile3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bStatusFile3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bStatusFile3.UseVisualStyleBackColor = false;
            this.bStatusFile3.Visible = false;
            // 
            // bStatusFile4
            // 
            this.bStatusFile4.AutoEllipsis = true;
            this.bStatusFile4.BackColor = System.Drawing.Color.White;
            this.bStatusFile4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bStatusFile4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bStatusFile4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStatusFile4.Font = new System.Drawing.Font("Liberation Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStatusFile4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bStatusFile4.ImageIndex = 0;
            this.bStatusFile4.ImageList = this.ilSend;
            this.bStatusFile4.Location = new System.Drawing.Point(579, 649);
            this.bStatusFile4.MaximumSize = new System.Drawing.Size(183, 40);
            this.bStatusFile4.Name = "bStatusFile4";
            this.bStatusFile4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bStatusFile4.Size = new System.Drawing.Size(183, 40);
            this.bStatusFile4.TabIndex = 12;
            this.bStatusFile4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bStatusFile4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bStatusFile4.UseVisualStyleBackColor = false;
            this.bStatusFile4.Visible = false;
            // 
            // SendPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 693);
            this.Controls.Add(this.bStatusFile4);
            this.Controls.Add(this.bStatusFile3);
            this.Controls.Add(this.bStatusFile2);
            this.Controls.Add(this.bStatusFile);
            this.Controls.Add(this.bFile);
            this.Controls.Add(this.tbBody);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.bSend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(876, 740);
            this.MinimumSize = new System.Drawing.Size(876, 740);
            this.Name = "SendPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoveMail: новое письмо";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbBody;
        private System.Windows.Forms.Button bFile;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.Button bStatusFile;
        private System.Windows.Forms.ImageList ilSend;
        private System.Windows.Forms.Button bStatusFile2;
        private System.Windows.Forms.Button bStatusFile3;
        private System.Windows.Forms.Button bStatusFile4;
    }
}

