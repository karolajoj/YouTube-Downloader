namespace YouTube_Downloader {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ButtonMaximize = new FontAwesome.Sharp.IconButton();
            this.ButtonMinimize = new FontAwesome.Sharp.IconButton();
            this.ButtonSettings2 = new FontAwesome.Sharp.IconButton();
            this.ButtonExit = new FontAwesome.Sharp.IconButton();
            this.ButtonPasteURL = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 661);
            this.LeftPanel.TabIndex = 4;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TopPanel.Controls.Add(this.ButtonMaximize);
            this.TopPanel.Controls.Add(this.ButtonMinimize);
            this.TopPanel.Controls.Add(this.ButtonSettings2);
            this.TopPanel.Controls.Add(this.ButtonExit);
            this.TopPanel.Controls.Add(this.ButtonPasteURL);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(200, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(854, 100);
            this.TopPanel.TabIndex = 5;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // ButtonMaximize
            // 
            this.ButtonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.ButtonMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ButtonMaximize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ButtonMaximize.IconSize = 16;
            this.ButtonMaximize.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ButtonMaximize.Location = new System.Drawing.Point(796, 3);
            this.ButtonMaximize.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonMaximize.Name = "ButtonMaximize";
            this.ButtonMaximize.Size = new System.Drawing.Size(26, 22);
            this.ButtonMaximize.TabIndex = 5;
            this.ButtonMaximize.UseVisualStyleBackColor = true;
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.ButtonMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ButtonMinimize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ButtonMinimize.IconSize = 16;
            this.ButtonMinimize.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ButtonMinimize.Location = new System.Drawing.Point(767, 3);
            this.ButtonMinimize.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(26, 22);
            this.ButtonMinimize.TabIndex = 4;
            this.ButtonMinimize.UseVisualStyleBackColor = true;
            // 
            // ButtonSettings2
            // 
            this.ButtonSettings2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSettings2.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.ButtonSettings2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ButtonSettings2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ButtonSettings2.IconSize = 16;
            this.ButtonSettings2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ButtonSettings2.Location = new System.Drawing.Point(738, 3);
            this.ButtonSettings2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonSettings2.Name = "ButtonSettings2";
            this.ButtonSettings2.Size = new System.Drawing.Size(26, 22);
            this.ButtonSettings2.TabIndex = 3;
            this.ButtonSettings2.UseVisualStyleBackColor = true;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.ButtonExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ButtonExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ButtonExit.IconSize = 16;
            this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ButtonExit.Location = new System.Drawing.Point(825, 3);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(26, 22);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.UseVisualStyleBackColor = true;
            // 
            // ButtonPasteURL
            // 
            this.ButtonPasteURL.Location = new System.Drawing.Point(24, 35);
            this.ButtonPasteURL.Margin = new System.Windows.Forms.Padding(21, 35, 3, 35);
            this.ButtonPasteURL.Name = "ButtonPasteURL";
            this.ButtonPasteURL.Size = new System.Drawing.Size(85, 30);
            this.ButtonPasteURL.TabIndex = 0;
            this.ButtonPasteURL.Text = "Paste URL";
            this.ButtonPasteURL.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 661);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "MainWindow";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Video Downloader";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button ButtonPasteURL;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private FontAwesome.Sharp.IconButton ButtonExit;
        private FontAwesome.Sharp.IconButton ButtonMaximize;
        private FontAwesome.Sharp.IconButton ButtonMinimize;
        private FontAwesome.Sharp.IconButton ButtonSettings2;
    }
}