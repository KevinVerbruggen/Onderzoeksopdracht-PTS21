namespace FileShare
{
    partial class CategorienForm
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
            this.buttonNieuweCategorie = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAnnuleren = new System.Windows.Forms.Button();
            this.textBoxNieuweCategorie = new System.Windows.Forms.TextBox();
            this.labelUitleg = new System.Windows.Forms.Label();
            this.checkedListBoxCategorien = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // buttonNieuweCategorie
            // 
            this.buttonNieuweCategorie.Location = new System.Drawing.Point(177, 204);
            this.buttonNieuweCategorie.Name = "buttonNieuweCategorie";
            this.buttonNieuweCategorie.Size = new System.Drawing.Size(89, 23);
            this.buttonNieuweCategorie.TabIndex = 2;
            this.buttonNieuweCategorie.Text = "Toevoegen";
            this.buttonNieuweCategorie.UseVisualStyleBackColor = true;
            this.buttonNieuweCategorie.Click += new System.EventHandler(this.buttonNieuweCategorie_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 233);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAnnuleren
            // 
            this.buttonAnnuleren.Location = new System.Drawing.Point(93, 233);
            this.buttonAnnuleren.Name = "buttonAnnuleren";
            this.buttonAnnuleren.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuleren.TabIndex = 4;
            this.buttonAnnuleren.Text = "Annuleren";
            this.buttonAnnuleren.UseVisualStyleBackColor = true;
            this.buttonAnnuleren.Click += new System.EventHandler(this.buttonAnnuleren_Click);
            // 
            // textBoxNieuweCategorie
            // 
            this.textBoxNieuweCategorie.Location = new System.Drawing.Point(13, 204);
            this.textBoxNieuweCategorie.Name = "textBoxNieuweCategorie";
            this.textBoxNieuweCategorie.Size = new System.Drawing.Size(155, 20);
            this.textBoxNieuweCategorie.TabIndex = 5;
            this.textBoxNieuweCategorie.Text = " Nieuwe Categorie";
            this.textBoxNieuweCategorie.TextChanged += new System.EventHandler(this.textBoxNieuweCategorie_TextChanged);
            // 
            // labelUitleg
            // 
            this.labelUitleg.Location = new System.Drawing.Point(9, 167);
            this.labelUitleg.Name = "labelUitleg";
            this.labelUitleg.Size = new System.Drawing.Size(254, 34);
            this.labelUitleg.TabIndex = 6;
            this.labelUitleg.Text = "Kies 1 categorie en druk op de knop \'Toevoegen\' om een sub-categorie te maken.";
            // 
            // checkedListBoxCategorien
            // 
            this.checkedListBoxCategorien.FormattingEnabled = true;
            this.checkedListBoxCategorien.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxCategorien.Name = "checkedListBoxCategorien";
            this.checkedListBoxCategorien.Size = new System.Drawing.Size(260, 154);
            this.checkedListBoxCategorien.TabIndex = 7;
            this.checkedListBoxCategorien.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxCategorien_SelectedIndexChanged);
            // 
            // CategorienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.checkedListBoxCategorien);
            this.Controls.Add(this.labelUitleg);
            this.Controls.Add(this.textBoxNieuweCategorie);
            this.Controls.Add(this.buttonAnnuleren);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonNieuweCategorie);
            this.Name = "CategorienForm";
            this.Text = "Categoriën Kiezen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNieuweCategorie;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAnnuleren;
        private System.Windows.Forms.TextBox textBoxNieuweCategorie;
        private System.Windows.Forms.Label labelUitleg;
        private System.Windows.Forms.CheckedListBox checkedListBoxCategorien;
    }
}