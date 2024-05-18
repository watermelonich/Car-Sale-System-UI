namespace UniversalCarSaleSystem.Screens
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarStockButton = new System.Windows.Forms.Button();
            this.CustomerDetailsButton = new System.Windows.Forms.Button();
            this.CustomerHistoryButton = new System.Windows.Forms.Button();
            this.UpdateStockButton = new System.Windows.Forms.Button();
            this.CompanyDetailButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change P&assword";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.editToolStripMenuItem.Text = "&Stock";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.undoToolStripMenuItem.Text = "&Check Stock";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.redoToolStripMenuItem.Text = "&Update Stock";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(182, 6);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.toolsToolStripMenuItem.Text = "&Customer";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.customizeToolStripMenuItem.Text = "Customer D&etails";
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.optionsToolStripMenuItem.Text = "&Customer History";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutCompanyToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripMenuItem.Text = "&About";
            // 
            // aboutCompanyToolStripMenuItem
            // 
            this.aboutCompanyToolStripMenuItem.Name = "aboutCompanyToolStripMenuItem";
            this.aboutCompanyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.aboutCompanyToolStripMenuItem.Text = "Abou&t Company";
            this.aboutCompanyToolStripMenuItem.Click += new System.EventHandler(this.aboutCompanyToolStripMenuItem_Click);
            // 
            // CarStockButton
            // 
            this.CarStockButton.BackColor = System.Drawing.Color.Transparent;
            this.CarStockButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CarStockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CarStockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CarStockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarStockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarStockButton.Location = new System.Drawing.Point(12, 79);
            this.CarStockButton.Name = "CarStockButton";
            this.CarStockButton.Size = new System.Drawing.Size(266, 81);
            this.CarStockButton.TabIndex = 1;
            this.CarStockButton.Text = "Car Stock";
            this.CarStockButton.UseVisualStyleBackColor = false;
            this.CarStockButton.Click += new System.EventHandler(this.CarStockButton_Click);
            // 
            // CustomerDetailsButton
            // 
            this.CustomerDetailsButton.BackColor = System.Drawing.Color.Transparent;
            this.CustomerDetailsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CustomerDetailsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomerDetailsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CustomerDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDetailsButton.Location = new System.Drawing.Point(12, 185);
            this.CustomerDetailsButton.Name = "CustomerDetailsButton";
            this.CustomerDetailsButton.Size = new System.Drawing.Size(266, 81);
            this.CustomerDetailsButton.TabIndex = 1;
            this.CustomerDetailsButton.Text = "Customer Details";
            this.CustomerDetailsButton.UseVisualStyleBackColor = false;
            this.CustomerDetailsButton.Click += new System.EventHandler(this.CustomerDetailsButton_Click);
            // 
            // CustomerHistoryButton
            // 
            this.CustomerHistoryButton.BackColor = System.Drawing.Color.Transparent;
            this.CustomerHistoryButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CustomerHistoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomerHistoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CustomerHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerHistoryButton.Location = new System.Drawing.Point(110, 296);
            this.CustomerHistoryButton.Name = "CustomerHistoryButton";
            this.CustomerHistoryButton.Size = new System.Drawing.Size(482, 81);
            this.CustomerHistoryButton.TabIndex = 1;
            this.CustomerHistoryButton.Text = "Customer History  And Order Confirm";
            this.CustomerHistoryButton.UseVisualStyleBackColor = false;
            this.CustomerHistoryButton.Click += new System.EventHandler(this.CustomerHistoryButton_Click);
            // 
            // UpdateStockButton
            // 
            this.UpdateStockButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateStockButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.UpdateStockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UpdateStockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UpdateStockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateStockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateStockButton.Location = new System.Drawing.Point(415, 79);
            this.UpdateStockButton.Name = "UpdateStockButton";
            this.UpdateStockButton.Size = new System.Drawing.Size(266, 81);
            this.UpdateStockButton.TabIndex = 1;
            this.UpdateStockButton.Text = "Update Stock";
            this.UpdateStockButton.UseVisualStyleBackColor = false;
            this.UpdateStockButton.Click += new System.EventHandler(this.UpdateStockButton_Click);
            // 
            // CompanyDetailButton
            // 
            this.CompanyDetailButton.BackColor = System.Drawing.Color.Transparent;
            this.CompanyDetailButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CompanyDetailButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CompanyDetailButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CompanyDetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompanyDetailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyDetailButton.Location = new System.Drawing.Point(415, 185);
            this.CompanyDetailButton.Name = "CompanyDetailButton";
            this.CompanyDetailButton.Size = new System.Drawing.Size(266, 81);
            this.CompanyDetailButton.TabIndex = 1;
            this.CompanyDetailButton.Text = "Company Detail";
            this.CompanyDetailButton.UseVisualStyleBackColor = false;
            this.CompanyDetailButton.Click += new System.EventHandler(this.CompanyDetailButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(703, 399);
            this.Controls.Add(this.CompanyDetailButton);
            this.Controls.Add(this.CustomerHistoryButton);
            this.Controls.Add(this.UpdateStockButton);
            this.Controls.Add(this.CustomerDetailsButton);
            this.Controls.Add(this.CarStockButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Universal Car Sale System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button CarStockButton;
        private System.Windows.Forms.Button CustomerDetailsButton;
        private System.Windows.Forms.Button CustomerHistoryButton;
        private System.Windows.Forms.Button UpdateStockButton;
        private System.Windows.Forms.Button CompanyDetailButton;
        private System.Windows.Forms.ToolStripMenuItem aboutCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}