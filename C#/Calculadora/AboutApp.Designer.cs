namespace Calculadora
{
    partial class AboutApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutApp));
            this.Version = new System.Windows.Forms.TextBox();
            this.AppName = new System.Windows.Forms.TextBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FecharJanelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Copyright = new System.Windows.Forms.TextBox();
            this.AppIcon = new System.Windows.Forms.PictureBox();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Version
            // 
            this.Version.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Version.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(81)))));
            this.Version.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Version.CausesValidation = false;
            this.Version.Font = new System.Drawing.Font("Calibri", 10F);
            this.Version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.Version.Location = new System.Drawing.Point(12, 192);
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            this.Version.ShortcutsEnabled = false;
            this.Version.Size = new System.Drawing.Size(260, 17);
            this.Version.TabIndex = 40;
            this.Version.TabStop = false;
            this.Version.Text = "My.Application.Info.Version.ToString";
            this.Version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AppName
            // 
            this.AppName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(81)))));
            this.AppName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppName.CausesValidation = false;
            this.AppName.Font = new System.Drawing.Font("Calibri", 15F);
            this.AppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.AppName.Location = new System.Drawing.Point(12, 146);
            this.AppName.Name = "AppName";
            this.AppName.ReadOnly = true;
            this.AppName.ShortcutsEnabled = false;
            this.AppName.Size = new System.Drawing.Size(260, 25);
            this.AppName.TabIndex = 39;
            this.AppName.TabStop = false;
            this.AppName.Text = "My.Computer.Info.AssemblyName";
            this.AppName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FecharJanelaToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(284, 24);
            this.MenuStrip1.TabIndex = 42;
            this.MenuStrip1.Text = "MenuStrip1";
            this.MenuStrip1.Visible = false;
            // 
            // FecharJanelaToolStripMenuItem
            // 
            this.FecharJanelaToolStripMenuItem.Name = "FecharJanelaToolStripMenuItem";
            this.FecharJanelaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.FecharJanelaToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.FecharJanelaToolStripMenuItem.Text = "Fechar Janela...";
            this.FecharJanelaToolStripMenuItem.Click += new System.EventHandler(this.FecharJanelaToolStripMenuItem_Click);
            // 
            // Copyright
            // 
            this.Copyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Copyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(81)))));
            this.Copyright.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Copyright.CausesValidation = false;
            this.Copyright.Font = new System.Drawing.Font("Calibri", 10F);
            this.Copyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.Copyright.Location = new System.Drawing.Point(12, 215);
            this.Copyright.Multiline = true;
            this.Copyright.Name = "Copyright";
            this.Copyright.ReadOnly = true;
            this.Copyright.ShortcutsEnabled = false;
            this.Copyright.Size = new System.Drawing.Size(260, 34);
            this.Copyright.TabIndex = 41;
            this.Copyright.TabStop = false;
            this.Copyright.Text = "My.Application.Info.Copyright";
            this.Copyright.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AppIcon
            // 
            this.AppIcon.Image = ((System.Drawing.Image)(resources.GetObject("AppIcon.Image")));
            this.AppIcon.Location = new System.Drawing.Point(12, 12);
            this.AppIcon.Name = "AppIcon";
            this.AppIcon.Size = new System.Drawing.Size(260, 128);
            this.AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AppIcon.TabIndex = 38;
            this.AppIcon.TabStop = false;
            // 
            // AboutApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.AppIcon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "AboutApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre a Calculadora";
            this.Load += new System.EventHandler(this.AboutApp_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Version;
        public System.Windows.Forms.TextBox AppName;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FecharJanelaToolStripMenuItem;
        public System.Windows.Forms.TextBox Copyright;
        internal System.Windows.Forms.PictureBox AppIcon;
    }
}