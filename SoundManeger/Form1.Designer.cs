﻿namespace SoundManeger
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.favDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.FavlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ACButton = new System.Windows.Forms.Button();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameUpdateButton = new System.Windows.Forms.Button();
            this.FavAddButton = new System.Windows.Forms.Button();
            this.FavsAddButton = new System.Windows.Forms.Button();
            this.FavsCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.FavsNameTextBox = new System.Windows.Forms.TextBox();
            this.FCLBMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelFilDispItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.FCLBMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(242, 484);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(260, 122);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(90, 30);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(356, 122);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(90, 30);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favDropDown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(811, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // favDropDown
            // 
            this.favDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.favDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FavlistToolStripMenuItem});
            this.favDropDown.Image = ((System.Drawing.Image)(resources.GetObject("favDropDown.Image")));
            this.favDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.favDropDown.Name = "favDropDown";
            this.favDropDown.Size = new System.Drawing.Size(29, 22);
            this.favDropDown.Text = "toolStripDropDownButton1";
            // 
            // FavlistToolStripMenuItem
            // 
            this.FavlistToolStripMenuItem.Name = "FavlistToolStripMenuItem";
            this.FavlistToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.FavlistToolStripMenuItem.Text = "お気に入り設定";
            this.FavlistToolStripMenuItem.Click += new System.EventHandler(this.FavlistToolStripMenuItem_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(260, 71);
            this.trackBar1.Maximum = 256;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(186, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ACButton
            // 
            this.ACButton.Location = new System.Drawing.Point(260, 158);
            this.ACButton.Name = "ACButton";
            this.ACButton.Size = new System.Drawing.Size(90, 30);
            this.ACButton.TabIndex = 5;
            this.ACButton.Text = "All Clear";
            this.ACButton.UseVisualStyleBackColor = true;
            this.ACButton.Click += new System.EventHandler(this.ACButton_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(452, 122);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(214, 45);
            this.volumeBar.TabIndex = 6;
            this.volumeBar.Value = 100;
            this.volumeBar.ValueChanged += new System.EventHandler(this.volumeBar_ValueChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(260, 36);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(186, 19);
            this.NameTextBox.TabIndex = 7;
            // 
            // NameUpdateButton
            // 
            this.NameUpdateButton.Location = new System.Drawing.Point(452, 30);
            this.NameUpdateButton.Name = "NameUpdateButton";
            this.NameUpdateButton.Size = new System.Drawing.Size(90, 30);
            this.NameUpdateButton.TabIndex = 8;
            this.NameUpdateButton.Text = "更新";
            this.NameUpdateButton.UseVisualStyleBackColor = true;
            this.NameUpdateButton.Click += new System.EventHandler(this.NameUpdateButton_Click);
            // 
            // FavAddButton
            // 
            this.FavAddButton.Location = new System.Drawing.Point(260, 228);
            this.FavAddButton.Name = "FavAddButton";
            this.FavAddButton.Size = new System.Drawing.Size(90, 30);
            this.FavAddButton.TabIndex = 10;
            this.FavAddButton.Text = "追加";
            this.FavAddButton.UseVisualStyleBackColor = true;
            this.FavAddButton.Click += new System.EventHandler(this.FavAddButton_Click);
            // 
            // FavsAddButton
            // 
            this.FavsAddButton.Location = new System.Drawing.Point(356, 228);
            this.FavsAddButton.Name = "FavsAddButton";
            this.FavsAddButton.Size = new System.Drawing.Size(90, 30);
            this.FavsAddButton.TabIndex = 11;
            this.FavsAddButton.Text = "フィルター追加";
            this.FavsAddButton.UseVisualStyleBackColor = true;
            this.FavsAddButton.Click += new System.EventHandler(this.FavsAddButton_Click);
            // 
            // FavsCheckListBox
            // 
            this.FavsCheckListBox.FormattingEnabled = true;
            this.FavsCheckListBox.Location = new System.Drawing.Point(260, 264);
            this.FavsCheckListBox.Name = "FavsCheckListBox";
            this.FavsCheckListBox.Size = new System.Drawing.Size(186, 256);
            this.FavsCheckListBox.TabIndex = 13;
            // 
            // FavsNameTextBox
            // 
            this.FavsNameTextBox.Location = new System.Drawing.Point(260, 203);
            this.FavsNameTextBox.Name = "FavsNameTextBox";
            this.FavsNameTextBox.Size = new System.Drawing.Size(186, 19);
            this.FavsNameTextBox.TabIndex = 14;
            // 
            // FCLBMenuStrip
            // 
            this.FCLBMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelFilDispItem});
            this.FCLBMenuStrip.Name = "FCLBMenuStrip";
            this.FCLBMenuStrip.Size = new System.Drawing.Size(175, 26);
            // 
            // SelFilDispItem
            // 
            this.SelFilDispItem.Name = "SelFilDispItem";
            this.SelFilDispItem.Size = new System.Drawing.Size(180, 22);
            this.SelFilDispItem.Text = "選択フィルターの表示";
            this.SelFilDispItem.Click += new System.EventHandler(this.SelFilDispItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 527);
            this.Controls.Add(this.FavsNameTextBox);
            this.Controls.Add(this.FavsCheckListBox);
            this.Controls.Add(this.FavsAddButton);
            this.Controls.Add(this.FavAddButton);
            this.Controls.Add(this.NameUpdateButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.ACButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.listBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.FCLBMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button ACButton;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button NameUpdateButton;
        private System.Windows.Forms.Button FavAddButton;
        private System.Windows.Forms.ToolStripDropDownButton favDropDown;
        private System.Windows.Forms.ToolStripMenuItem FavlistToolStripMenuItem;
        private System.Windows.Forms.Button FavsAddButton;
        private System.Windows.Forms.CheckedListBox FavsCheckListBox;
        private System.Windows.Forms.TextBox FavsNameTextBox;
        private System.Windows.Forms.ContextMenuStrip FCLBMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SelFilDispItem;
    }
}

