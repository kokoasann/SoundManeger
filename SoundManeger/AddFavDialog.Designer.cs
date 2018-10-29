namespace SoundManeger
{
    partial class AddFavDialog
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.FavCBL = new System.Windows.Forms.CheckedListBox();
            this.addfavButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 19);
            this.textBox1.TabIndex = 13;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(75, 34);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(57, 30);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "button2";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // FavCBL
            // 
            this.FavCBL.FormattingEnabled = true;
            this.FavCBL.Location = new System.Drawing.Point(12, 65);
            this.FavCBL.Name = "FavCBL";
            this.FavCBL.Size = new System.Drawing.Size(120, 242);
            this.FavCBL.TabIndex = 12;
            // 
            // addfavButton
            // 
            this.addfavButton.Location = new System.Drawing.Point(12, 34);
            this.addfavButton.Name = "addfavButton";
            this.addfavButton.Size = new System.Drawing.Size(57, 30);
            this.addfavButton.TabIndex = 14;
            this.addfavButton.Text = "button1";
            this.addfavButton.UseVisualStyleBackColor = true;
            // 
            // AddFavDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 313);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.FavCBL);
            this.Controls.Add(this.addfavButton);
            this.Name = "AddFavDialog";
            this.Text = "AddFavDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.CheckedListBox FavCBL;
        private System.Windows.Forms.Button addfavButton;
    }
}