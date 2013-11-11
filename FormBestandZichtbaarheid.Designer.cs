namespace FileShare
{
    partial class FormBestandZichtbaarheid
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
            this.checkedListBoxZichtbaarheid = new System.Windows.Forms.CheckedListBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxZichtbaarheid
            // 
            this.checkedListBoxZichtbaarheid.FormattingEnabled = true;
            this.checkedListBoxZichtbaarheid.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxZichtbaarheid.Name = "checkedListBoxZichtbaarheid";
            this.checkedListBoxZichtbaarheid.Size = new System.Drawing.Size(260, 199);
            this.checkedListBoxZichtbaarheid.TabIndex = 0;
            this.checkedListBoxZichtbaarheid.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxZichtbaarheid_SelectedIndexChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 227);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormBestandZichtbaarheid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.checkedListBoxZichtbaarheid);
            this.Name = "FormBestandZichtbaarheid";
            this.Text = "Privacy-settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxZichtbaarheid;
        private System.Windows.Forms.Button buttonOK;
    }
}