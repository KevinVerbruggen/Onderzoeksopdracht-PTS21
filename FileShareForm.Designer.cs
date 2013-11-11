namespace FileShare
{
    partial class FileShareForm
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
            this.ListBoxBestanden = new System.Windows.Forms.ListBox();
            this.buttonDownloaden = new System.Windows.Forms.Button();
            this.buttonVerwijder = new System.Windows.Forms.Button();
            this.buttonUpvote = new System.Windows.Forms.Button();
            this.buttonDownvote = new System.Windows.Forms.Button();
            this.buttonUploaden = new System.Windows.Forms.Button();
            this.listBoxCategorie = new System.Windows.Forms.ListBox();
            this.buttonVernieuwen = new System.Windows.Forms.Button();
            this.buttonVerwijderen2 = new System.Windows.Forms.Button();
            this.labelIngelogdAls = new System.Windows.Forms.Label();
            this.tcAlleBestanden = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ListBoxEigenBestanden = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ListBoxFlagBestanden = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ListBoxAlleGebruikers = new System.Windows.Forms.ListBox();
            this.buttonFlag = new System.Windows.Forms.Button();
            this.buttonGebruikerBlokkeren = new System.Windows.Forms.Button();
            this.tcAlleBestanden.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxBestanden
            // 
            this.ListBoxBestanden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxBestanden.Location = new System.Drawing.Point(3, 3);
            this.ListBoxBestanden.Margin = new System.Windows.Forms.Padding(1);
            this.ListBoxBestanden.Name = "ListBoxBestanden";
            this.ListBoxBestanden.Size = new System.Drawing.Size(544, 392);
            this.ListBoxBestanden.TabIndex = 0;
            // 
            // buttonDownloaden
            // 
            this.buttonDownloaden.Location = new System.Drawing.Point(591, 66);
            this.buttonDownloaden.Name = "buttonDownloaden";
            this.buttonDownloaden.Size = new System.Drawing.Size(185, 31);
            this.buttonDownloaden.TabIndex = 1;
            this.buttonDownloaden.Text = "Downloaden";
            this.buttonDownloaden.UseVisualStyleBackColor = true;
            this.buttonDownloaden.Click += new System.EventHandler(this.buttonDownloaden_Click);
            // 
            // buttonVerwijder
            // 
            this.buttonVerwijder.Location = new System.Drawing.Point(591, 221);
            this.buttonVerwijder.Name = "buttonVerwijder";
            this.buttonVerwijder.Size = new System.Drawing.Size(185, 31);
            this.buttonVerwijder.TabIndex = 2;
            this.buttonVerwijder.Text = "Bestand Verwijderen";
            this.buttonVerwijder.UseVisualStyleBackColor = true;
            this.buttonVerwijder.Click += new System.EventHandler(this.buttonVerwijder_Click);
            // 
            // buttonUpvote
            // 
            this.buttonUpvote.Location = new System.Drawing.Point(591, 111);
            this.buttonUpvote.Name = "buttonUpvote";
            this.buttonUpvote.Size = new System.Drawing.Size(92, 31);
            this.buttonUpvote.TabIndex = 4;
            this.buttonUpvote.Text = "Upvote";
            this.buttonUpvote.UseVisualStyleBackColor = true;
            this.buttonUpvote.Click += new System.EventHandler(this.buttonUpvote_Click);
            // 
            // buttonDownvote
            // 
            this.buttonDownvote.Location = new System.Drawing.Point(689, 111);
            this.buttonDownvote.Name = "buttonDownvote";
            this.buttonDownvote.Size = new System.Drawing.Size(87, 31);
            this.buttonDownvote.TabIndex = 5;
            this.buttonDownvote.Text = "Downvote";
            this.buttonDownvote.UseVisualStyleBackColor = true;
            this.buttonDownvote.Click += new System.EventHandler(this.buttonDownvote_Click);
            // 
            // buttonUploaden
            // 
            this.buttonUploaden.Location = new System.Drawing.Point(591, 29);
            this.buttonUploaden.Name = "buttonUploaden";
            this.buttonUploaden.Size = new System.Drawing.Size(185, 31);
            this.buttonUploaden.TabIndex = 6;
            this.buttonUploaden.Text = "Uploaden";
            this.buttonUploaden.UseVisualStyleBackColor = true;
            this.buttonUploaden.Click += new System.EventHandler(this.buttonUploaden_Click);
            // 
            // listBoxCategorie
            // 
            this.listBoxCategorie.FormattingEnabled = true;
            this.listBoxCategorie.Location = new System.Drawing.Point(591, 332);
            this.listBoxCategorie.Name = "listBoxCategorie";
            this.listBoxCategorie.Size = new System.Drawing.Size(185, 147);
            this.listBoxCategorie.TabIndex = 7;
            this.listBoxCategorie.SelectedIndexChanged += new System.EventHandler(this.listBoxCategorie_SelectedIndexChanged);
            // 
            // buttonVernieuwen
            // 
            this.buttonVernieuwen.Location = new System.Drawing.Point(591, 295);
            this.buttonVernieuwen.Name = "buttonVernieuwen";
            this.buttonVernieuwen.Size = new System.Drawing.Size(185, 31);
            this.buttonVernieuwen.TabIndex = 8;
            this.buttonVernieuwen.Text = "Lijst Vernieuwen";
            this.buttonVernieuwen.UseVisualStyleBackColor = true;
            this.buttonVernieuwen.Click += new System.EventHandler(this.buttonVernieuwen_Click);
            // 
            // buttonVerwijderen2
            // 
            this.buttonVerwijderen2.Location = new System.Drawing.Point(591, 258);
            this.buttonVerwijderen2.Name = "buttonVerwijderen2";
            this.buttonVerwijderen2.Size = new System.Drawing.Size(185, 31);
            this.buttonVerwijderen2.TabIndex = 9;
            this.buttonVerwijderen2.Text = "Categorie Verwijderen";
            this.buttonVerwijderen2.UseVisualStyleBackColor = true;
            this.buttonVerwijderen2.Click += new System.EventHandler(this.buttonVerwijderen2_Click);
            // 
            // labelIngelogdAls
            // 
            this.labelIngelogdAls.AutoSize = true;
            this.labelIngelogdAls.Location = new System.Drawing.Point(591, 10);
            this.labelIngelogdAls.Name = "labelIngelogdAls";
            this.labelIngelogdAls.Size = new System.Drawing.Size(70, 13);
            this.labelIngelogdAls.TabIndex = 10;
            this.labelIngelogdAls.Text = "Ingelogd als: ";
            // 
            // tcAlleBestanden
            // 
            this.tcAlleBestanden.Controls.Add(this.tabPage1);
            this.tcAlleBestanden.Controls.Add(this.tabPage2);
            this.tcAlleBestanden.Controls.Add(this.tabPage3);
            this.tcAlleBestanden.Controls.Add(this.tabPage4);
            this.tcAlleBestanden.Location = new System.Drawing.Point(12, 55);
            this.tcAlleBestanden.Name = "tcAlleBestanden";
            this.tcAlleBestanden.SelectedIndex = 0;
            this.tcAlleBestanden.Size = new System.Drawing.Size(558, 424);
            this.tcAlleBestanden.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ListBoxBestanden);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(550, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alle bestanden";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ListBoxEigenBestanden);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(550, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eigen bestanden";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ListBoxEigenBestanden
            // 
            this.ListBoxEigenBestanden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxEigenBestanden.FormattingEnabled = true;
            this.ListBoxEigenBestanden.Location = new System.Drawing.Point(3, 3);
            this.ListBoxEigenBestanden.Name = "ListBoxEigenBestanden";
            this.ListBoxEigenBestanden.Size = new System.Drawing.Size(544, 392);
            this.ListBoxEigenBestanden.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ListBoxFlagBestanden);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(550, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Geflagte bestanden";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ListBoxFlagBestanden
            // 
            this.ListBoxFlagBestanden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxFlagBestanden.FormattingEnabled = true;
            this.ListBoxFlagBestanden.Location = new System.Drawing.Point(3, 3);
            this.ListBoxFlagBestanden.Name = "ListBoxFlagBestanden";
            this.ListBoxFlagBestanden.Size = new System.Drawing.Size(544, 392);
            this.ListBoxFlagBestanden.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ListBoxAlleGebruikers);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(550, 398);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Alle gebruikers";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ListBoxAlleGebruikers
            // 
            this.ListBoxAlleGebruikers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxAlleGebruikers.FormattingEnabled = true;
            this.ListBoxAlleGebruikers.Location = new System.Drawing.Point(0, 0);
            this.ListBoxAlleGebruikers.Name = "ListBoxAlleGebruikers";
            this.ListBoxAlleGebruikers.Size = new System.Drawing.Size(550, 398);
            this.ListBoxAlleGebruikers.TabIndex = 0;
            // 
            // buttonFlag
            // 
            this.buttonFlag.Location = new System.Drawing.Point(591, 148);
            this.buttonFlag.Name = "buttonFlag";
            this.buttonFlag.Size = new System.Drawing.Size(185, 31);
            this.buttonFlag.TabIndex = 12;
            this.buttonFlag.Text = "Rapporteren";
            this.buttonFlag.UseVisualStyleBackColor = true;
            this.buttonFlag.Click += new System.EventHandler(this.buttonFlag_Click_1);
            // 
            // buttonGebruikerBlokkeren
            // 
            this.buttonGebruikerBlokkeren.Location = new System.Drawing.Point(441, 13);
            this.buttonGebruikerBlokkeren.Name = "buttonGebruikerBlokkeren";
            this.buttonGebruikerBlokkeren.Size = new System.Drawing.Size(129, 36);
            this.buttonGebruikerBlokkeren.TabIndex = 13;
            this.buttonGebruikerBlokkeren.Text = "Gebruiker blokkeren";
            this.buttonGebruikerBlokkeren.UseVisualStyleBackColor = true;
            this.buttonGebruikerBlokkeren.Click += new System.EventHandler(this.buttonGebruikerBlokkeren_Click);
            // 
            // FileShareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 491);
            this.Controls.Add(this.buttonGebruikerBlokkeren);
            this.Controls.Add(this.buttonFlag);
            this.Controls.Add(this.tcAlleBestanden);
            this.Controls.Add(this.labelIngelogdAls);
            this.Controls.Add(this.buttonVerwijderen2);
            this.Controls.Add(this.buttonVernieuwen);
            this.Controls.Add(this.listBoxCategorie);
            this.Controls.Add(this.buttonUploaden);
            this.Controls.Add(this.buttonDownvote);
            this.Controls.Add(this.buttonUpvote);
            this.Controls.Add(this.buttonVerwijder);
            this.Controls.Add(this.buttonDownloaden);
            this.Name = "FileShareForm";
            this.Text = "FileShare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileShareForm_FormClosing);
            this.tcAlleBestanden.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxBestanden;
        private System.Windows.Forms.Button buttonDownloaden;
        private System.Windows.Forms.Button buttonVerwijder;
        private System.Windows.Forms.Button buttonUpvote;
        private System.Windows.Forms.Button buttonDownvote;
        private System.Windows.Forms.Button buttonUploaden;
        private System.Windows.Forms.ListBox listBoxCategorie;
        private System.Windows.Forms.Button buttonVernieuwen;
        private System.Windows.Forms.Button buttonVerwijderen2;
        private System.Windows.Forms.Label labelIngelogdAls;
        private System.Windows.Forms.TabControl tcAlleBestanden;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox ListBoxEigenBestanden;
        private System.Windows.Forms.ListBox ListBoxFlagBestanden;
        private System.Windows.Forms.ListBox ListBoxAlleGebruikers;
        private System.Windows.Forms.Button buttonFlag;
        private System.Windows.Forms.Button buttonGebruikerBlokkeren;
    }
}

