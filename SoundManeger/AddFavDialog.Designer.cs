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
            this.addfavButton = new System.Windows.Forms.Button();
            this.favListBox = new System.Windows.Forms.ListBox();
            this.favsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // addfavButton
            // 
            this.addfavButton.Location = new System.Drawing.Point(12, 34);
            this.addfavButton.Name = "addfavButton";
            this.addfavButton.Size = new System.Drawing.Size(57, 30);
            this.addfavButton.TabIndex = 14;
            this.addfavButton.Text = "Add";
            this.addfavButton.UseVisualStyleBackColor = true;
            // 
            // favListBox
            // 
            this.favListBox.FormattingEnabled = true;
            this.favListBox.HorizontalScrollbar = true;
            this.favListBox.ItemHeight = 12;
            this.favListBox.Location = new System.Drawing.Point(138, 87);
            this.favListBox.Name = "favListBox";
            this.favListBox.Size = new System.Drawing.Size(127, 220);
            this.favListBox.TabIndex = 16;
            // 
            // favsListBox
            // 
            this.favsListBox.FormattingEnabled = true;
            this.favsListBox.HorizontalScrollbar = true;
            this.favsListBox.ItemHeight = 12;
            this.favsListBox.Location = new System.Drawing.Point(12, 87);
            this.favsListBox.Name = "favsListBox";
            this.favsListBox.Size = new System.Drawing.Size(120, 220);
            this.favsListBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "filterList";
            // 
            // AddFavDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.favsListBox);
            this.Controls.Add(this.favListBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addfavButton);
            this.Name = "AddFavDialog";
            this.Text = "AddFavDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addfavButton;
        private System.Windows.Forms.ListBox favListBox;
        private System.Windows.Forms.ListBox favsListBox;
        private System.Windows.Forms.Label label1;
    }
}