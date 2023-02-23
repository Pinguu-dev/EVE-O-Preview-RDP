using System.Windows.Forms;

namespace EveOPreview.View
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

		/// <summary>s
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem RestoreWindowMenuItem;
            System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
            System.Windows.Forms.ToolStripMenuItem TitleMenuItem;
            System.Windows.Forms.ToolStripSeparator SeparatorMenuItem;
            Guna.UI2.WinForms.Guna2TabControl ContentTabControl;
            System.Windows.Forms.TabPage GeneralTabPage;
            System.Windows.Forms.Panel GeneralSettingsPanel;
            System.Windows.Forms.TabPage ThumbnailTabPage;
            System.Windows.Forms.Panel ThumbnailSettingsPanel;
            System.Windows.Forms.Label HeigthLabel;
            System.Windows.Forms.Label WidthLabel;
            System.Windows.Forms.Label OpacityLabel;
            System.Windows.Forms.Panel ZoomSettingsPanel;
            System.Windows.Forms.Label ZoomFactorLabel;
            System.Windows.Forms.Label ZoomAnchorLabel;
            System.Windows.Forms.TabPage OverlayTabPage;
            System.Windows.Forms.Panel OverlaySettingsPanel;
            System.Windows.Forms.TabPage ClientsTabPage;
            System.Windows.Forms.Panel ClientsPanel;
            System.Windows.Forms.Label ThumbnailsListLabel;
            System.Windows.Forms.TabPage AboutTabPage;
            System.Windows.Forms.Panel AboutPanel;
            System.Windows.Forms.Label NameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MinimizeToTrayCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.MinimizeInactiveClientsCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.HideActiveClientThumbnailCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ShowThumbnailsAlwaysOnTopCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.HideThumbnailsOnLostFocusCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.EnablePerClientThumbnailsLayoutsCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ThumbnailsWidthNumericEdit = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.ThumbnailsHeightNumericEdit = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.ThumbnailOpacityTrackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.ZoomTabPage = new System.Windows.Forms.TabPage();
            this.ThumbnailZoomFactorNumericEdit = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.ZoomAnchorPanel = new System.Windows.Forms.Panel();
            this.ZoomAanchorNWRadioButton = new System.Windows.Forms.RadioButton();
            this.ZoomAanchorNRadioButton = new System.Windows.Forms.RadioButton();
            this.ZoomAanchorNERadioButton = new System.Windows.Forms.RadioButton();
            this.ZoomAanchorWRadioButton = new System.Windows.Forms.RadioButton();
            this.ZoomAanchorSERadioButton = new System.Windows.Forms.RadioButton();
            this.ZoomAanchorCRadioButton = new System.Windows.Forms.RadioButton();
            this.ZoomAanchorSRadioButton = new System.Windows.Forms.RadioButton();
            this.ZoomAanchorERadioButton = new System.Windows.Forms.RadioButton();
            this.ZoomAanchorSWRadioButton = new System.Windows.Forms.RadioButton();
            this.EnableThumbnailZoomCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.HighlightColorLabel = new System.Windows.Forms.Label();
            this.ActiveClientHighlightColorButton = new System.Windows.Forms.Panel();
            this.EnableActiveClientHighlightCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ShowThumbnailOverlaysCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ShowThumbnailFramesCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ThumbnailsList = new System.Windows.Forms.CheckedListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            RestoreWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            TitleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            SeparatorMenuItem = new System.Windows.Forms.ToolStripSeparator();
            ContentTabControl = new Guna.UI2.WinForms.Guna2TabControl();
            GeneralTabPage = new System.Windows.Forms.TabPage();
            GeneralSettingsPanel = new System.Windows.Forms.Panel();
            ThumbnailTabPage = new System.Windows.Forms.TabPage();
            ThumbnailSettingsPanel = new System.Windows.Forms.Panel();
            HeigthLabel = new System.Windows.Forms.Label();
            WidthLabel = new System.Windows.Forms.Label();
            OpacityLabel = new System.Windows.Forms.Label();
            ZoomSettingsPanel = new System.Windows.Forms.Panel();
            ZoomFactorLabel = new System.Windows.Forms.Label();
            ZoomAnchorLabel = new System.Windows.Forms.Label();
            OverlayTabPage = new System.Windows.Forms.TabPage();
            OverlaySettingsPanel = new System.Windows.Forms.Panel();
            ClientsTabPage = new System.Windows.Forms.TabPage();
            ClientsPanel = new System.Windows.Forms.Panel();
            ThumbnailsListLabel = new System.Windows.Forms.Label();
            AboutTabPage = new System.Windows.Forms.TabPage();
            AboutPanel = new System.Windows.Forms.Panel();
            NameLabel = new System.Windows.Forms.Label();
            ContentTabControl.SuspendLayout();
            GeneralTabPage.SuspendLayout();
            GeneralSettingsPanel.SuspendLayout();
            ThumbnailTabPage.SuspendLayout();
            ThumbnailSettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailsWidthNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailsHeightNumericEdit)).BeginInit();
            this.ZoomTabPage.SuspendLayout();
            ZoomSettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailZoomFactorNumericEdit)).BeginInit();
            this.ZoomAnchorPanel.SuspendLayout();
            OverlayTabPage.SuspendLayout();
            OverlaySettingsPanel.SuspendLayout();
            ClientsTabPage.SuspendLayout();
            ClientsPanel.SuspendLayout();
            AboutTabPage.SuspendLayout();
            AboutPanel.SuspendLayout();
            this.TrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // RestoreWindowMenuItem
            // 
            RestoreWindowMenuItem.Name = "RestoreWindowMenuItem";
            RestoreWindowMenuItem.Size = new System.Drawing.Size(237, 22);
            RestoreWindowMenuItem.Text = "Restore";
            RestoreWindowMenuItem.Click += new System.EventHandler(this.RestoreMainForm_Handler);
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new System.Drawing.Size(237, 22);
            ExitMenuItem.Text = "Exit";
            ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItemClick_Handler);
            // 
            // TitleMenuItem
            // 
            TitleMenuItem.Enabled = false;
            TitleMenuItem.Name = "TitleMenuItem";
            TitleMenuItem.Size = new System.Drawing.Size(237, 22);
            TitleMenuItem.Text = "EVE-O Preview (Edit by Lumyx)";
            // 
            // SeparatorMenuItem
            // 
            SeparatorMenuItem.Name = "SeparatorMenuItem";
            SeparatorMenuItem.Size = new System.Drawing.Size(234, 6);
            // 
            // ContentTabControl
            // 
            ContentTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            ContentTabControl.Controls.Add(GeneralTabPage);
            ContentTabControl.Controls.Add(ThumbnailTabPage);
            ContentTabControl.Controls.Add(this.ZoomTabPage);
            ContentTabControl.Controls.Add(OverlayTabPage);
            ContentTabControl.Controls.Add(ClientsTabPage);
            ContentTabControl.Controls.Add(AboutTabPage);
            ContentTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            ContentTabControl.ItemSize = new System.Drawing.Size(150, 35);
            ContentTabControl.Location = new System.Drawing.Point(0, 0);
            ContentTabControl.Name = "ContentTabControl";
            ContentTabControl.SelectedIndex = 0;
            ContentTabControl.Size = new System.Drawing.Size(390, 218);
            ContentTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            ContentTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            ContentTabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            ContentTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            ContentTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            ContentTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            ContentTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            ContentTabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            ContentTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            ContentTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            ContentTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            ContentTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            ContentTabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            ContentTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            ContentTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            ContentTabControl.TabButtonSize = new System.Drawing.Size(150, 35);
            ContentTabControl.TabIndex = 6;
            ContentTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            ContentTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ContentTabControl_DrawItem);
            // 
            // GeneralTabPage
            // 
            GeneralTabPage.BackColor = System.Drawing.SystemColors.Control;
            GeneralTabPage.Controls.Add(GeneralSettingsPanel);
            GeneralTabPage.Location = new System.Drawing.Point(154, 4);
            GeneralTabPage.Name = "GeneralTabPage";
            GeneralTabPage.Padding = new System.Windows.Forms.Padding(3);
            GeneralTabPage.Size = new System.Drawing.Size(232, 210);
            GeneralTabPage.TabIndex = 0;
            GeneralTabPage.Text = "General";
            // 
            // GeneralSettingsPanel
            // 
            GeneralSettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            GeneralSettingsPanel.Controls.Add(this.MinimizeToTrayCheckBox);
            GeneralSettingsPanel.Controls.Add(this.MinimizeInactiveClientsCheckBox);
            GeneralSettingsPanel.Controls.Add(this.HideActiveClientThumbnailCheckBox);
            GeneralSettingsPanel.Controls.Add(this.ShowThumbnailsAlwaysOnTopCheckBox);
            GeneralSettingsPanel.Controls.Add(this.HideThumbnailsOnLostFocusCheckBox);
            GeneralSettingsPanel.Controls.Add(this.EnablePerClientThumbnailsLayoutsCheckBox);
            GeneralSettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            GeneralSettingsPanel.Location = new System.Drawing.Point(3, 3);
            GeneralSettingsPanel.Name = "GeneralSettingsPanel";
            GeneralSettingsPanel.Size = new System.Drawing.Size(226, 204);
            GeneralSettingsPanel.TabIndex = 18;
            GeneralSettingsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GeneralSettingsPanel_Paint);
            // 
            // MinimizeToTrayCheckBox
            // 
            this.MinimizeToTrayCheckBox.AutoSize = true;
            this.MinimizeToTrayCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MinimizeToTrayCheckBox.CheckedState.BorderRadius = 0;
            this.MinimizeToTrayCheckBox.CheckedState.BorderThickness = 0;
            this.MinimizeToTrayCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MinimizeToTrayCheckBox.Location = new System.Drawing.Point(8, 8);
            this.MinimizeToTrayCheckBox.Name = "MinimizeToTrayCheckBox";
            this.MinimizeToTrayCheckBox.Size = new System.Drawing.Size(139, 17);
            this.MinimizeToTrayCheckBox.TabIndex = 25;
            this.MinimizeToTrayCheckBox.Text = "Minimize to System Tray";
            this.MinimizeToTrayCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MinimizeToTrayCheckBox.UncheckedState.BorderRadius = 0;
            this.MinimizeToTrayCheckBox.UncheckedState.BorderThickness = 0;
            this.MinimizeToTrayCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // MinimizeInactiveClientsCheckBox
            // 
            this.MinimizeInactiveClientsCheckBox.AutoSize = true;
            this.MinimizeInactiveClientsCheckBox.CheckedState.BorderRadius = 0;
            this.MinimizeInactiveClientsCheckBox.CheckedState.BorderThickness = 0;
            this.MinimizeInactiveClientsCheckBox.Location = new System.Drawing.Point(8, 55);
            this.MinimizeInactiveClientsCheckBox.Name = "MinimizeInactiveClientsCheckBox";
            this.MinimizeInactiveClientsCheckBox.Size = new System.Drawing.Size(165, 17);
            this.MinimizeInactiveClientsCheckBox.TabIndex = 24;
            this.MinimizeInactiveClientsCheckBox.Text = "Minimize inactive RDP clients";
            this.MinimizeInactiveClientsCheckBox.UncheckedState.BorderRadius = 0;
            this.MinimizeInactiveClientsCheckBox.UncheckedState.BorderThickness = 0;
            this.MinimizeInactiveClientsCheckBox.UseVisualStyleBackColor = true;
            this.MinimizeInactiveClientsCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // HideActiveClientThumbnailCheckBox
            // 
            this.HideActiveClientThumbnailCheckBox.AutoSize = true;
            this.HideActiveClientThumbnailCheckBox.Checked = true;
            this.HideActiveClientThumbnailCheckBox.CheckedState.BorderRadius = 0;
            this.HideActiveClientThumbnailCheckBox.CheckedState.BorderThickness = 0;
            this.HideActiveClientThumbnailCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HideActiveClientThumbnailCheckBox.Location = new System.Drawing.Point(8, 31);
            this.HideActiveClientThumbnailCheckBox.Name = "HideActiveClientThumbnailCheckBox";
            this.HideActiveClientThumbnailCheckBox.Size = new System.Drawing.Size(186, 17);
            this.HideActiveClientThumbnailCheckBox.TabIndex = 20;
            this.HideActiveClientThumbnailCheckBox.Text = "Hide preview of active RDP client";
            this.HideActiveClientThumbnailCheckBox.UncheckedState.BorderRadius = 0;
            this.HideActiveClientThumbnailCheckBox.UncheckedState.BorderThickness = 0;
            this.HideActiveClientThumbnailCheckBox.UseVisualStyleBackColor = true;
            this.HideActiveClientThumbnailCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ShowThumbnailsAlwaysOnTopCheckBox
            // 
            this.ShowThumbnailsAlwaysOnTopCheckBox.AutoSize = true;
            this.ShowThumbnailsAlwaysOnTopCheckBox.Checked = true;
            this.ShowThumbnailsAlwaysOnTopCheckBox.CheckedState.BorderRadius = 0;
            this.ShowThumbnailsAlwaysOnTopCheckBox.CheckedState.BorderThickness = 0;
            this.ShowThumbnailsAlwaysOnTopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowThumbnailsAlwaysOnTopCheckBox.Location = new System.Drawing.Point(8, 79);
            this.ShowThumbnailsAlwaysOnTopCheckBox.Name = "ShowThumbnailsAlwaysOnTopCheckBox";
            this.ShowThumbnailsAlwaysOnTopCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowThumbnailsAlwaysOnTopCheckBox.Size = new System.Drawing.Size(137, 17);
            this.ShowThumbnailsAlwaysOnTopCheckBox.TabIndex = 21;
            this.ShowThumbnailsAlwaysOnTopCheckBox.Text = "Previews always on top";
            this.ShowThumbnailsAlwaysOnTopCheckBox.UncheckedState.BorderRadius = 0;
            this.ShowThumbnailsAlwaysOnTopCheckBox.UncheckedState.BorderThickness = 0;
            this.ShowThumbnailsAlwaysOnTopCheckBox.UseVisualStyleBackColor = true;
            this.ShowThumbnailsAlwaysOnTopCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // HideThumbnailsOnLostFocusCheckBox
            // 
            this.HideThumbnailsOnLostFocusCheckBox.AutoSize = true;
            this.HideThumbnailsOnLostFocusCheckBox.Checked = true;
            this.HideThumbnailsOnLostFocusCheckBox.CheckedState.BorderRadius = 0;
            this.HideThumbnailsOnLostFocusCheckBox.CheckedState.BorderThickness = 0;
            this.HideThumbnailsOnLostFocusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HideThumbnailsOnLostFocusCheckBox.Location = new System.Drawing.Point(8, 103);
            this.HideThumbnailsOnLostFocusCheckBox.Name = "HideThumbnailsOnLostFocusCheckBox";
            this.HideThumbnailsOnLostFocusCheckBox.Size = new System.Drawing.Size(215, 17);
            this.HideThumbnailsOnLostFocusCheckBox.TabIndex = 22;
            this.HideThumbnailsOnLostFocusCheckBox.Text = "Hide previews if RDP client is not active";
            this.HideThumbnailsOnLostFocusCheckBox.UncheckedState.BorderRadius = 0;
            this.HideThumbnailsOnLostFocusCheckBox.UncheckedState.BorderThickness = 0;
            this.HideThumbnailsOnLostFocusCheckBox.UseVisualStyleBackColor = true;
            this.HideThumbnailsOnLostFocusCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // EnablePerClientThumbnailsLayoutsCheckBox
            // 
            this.EnablePerClientThumbnailsLayoutsCheckBox.AutoSize = true;
            this.EnablePerClientThumbnailsLayoutsCheckBox.Checked = true;
            this.EnablePerClientThumbnailsLayoutsCheckBox.CheckedState.BorderRadius = 0;
            this.EnablePerClientThumbnailsLayoutsCheckBox.CheckedState.BorderThickness = 0;
            this.EnablePerClientThumbnailsLayoutsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnablePerClientThumbnailsLayoutsCheckBox.Location = new System.Drawing.Point(8, 127);
            this.EnablePerClientThumbnailsLayoutsCheckBox.Name = "EnablePerClientThumbnailsLayoutsCheckBox";
            this.EnablePerClientThumbnailsLayoutsCheckBox.Size = new System.Drawing.Size(187, 17);
            this.EnablePerClientThumbnailsLayoutsCheckBox.TabIndex = 23;
            this.EnablePerClientThumbnailsLayoutsCheckBox.Text = "Unique layout for each RDP client";
            this.EnablePerClientThumbnailsLayoutsCheckBox.UncheckedState.BorderRadius = 0;
            this.EnablePerClientThumbnailsLayoutsCheckBox.UncheckedState.BorderThickness = 0;
            this.EnablePerClientThumbnailsLayoutsCheckBox.UseVisualStyleBackColor = true;
            this.EnablePerClientThumbnailsLayoutsCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ThumbnailTabPage
            // 
            ThumbnailTabPage.BackColor = System.Drawing.SystemColors.Control;
            ThumbnailTabPage.Controls.Add(ThumbnailSettingsPanel);
            ThumbnailTabPage.Location = new System.Drawing.Point(154, 4);
            ThumbnailTabPage.Name = "ThumbnailTabPage";
            ThumbnailTabPage.Padding = new System.Windows.Forms.Padding(3);
            ThumbnailTabPage.Size = new System.Drawing.Size(232, 210);
            ThumbnailTabPage.TabIndex = 1;
            ThumbnailTabPage.Text = "Thumbnail";
            // 
            // ThumbnailSettingsPanel
            // 
            ThumbnailSettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ThumbnailSettingsPanel.Controls.Add(this.ThumbnailsWidthNumericEdit);
            ThumbnailSettingsPanel.Controls.Add(this.ThumbnailsHeightNumericEdit);
            ThumbnailSettingsPanel.Controls.Add(this.ThumbnailOpacityTrackBar);
            ThumbnailSettingsPanel.Controls.Add(HeigthLabel);
            ThumbnailSettingsPanel.Controls.Add(WidthLabel);
            ThumbnailSettingsPanel.Controls.Add(OpacityLabel);
            ThumbnailSettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ThumbnailSettingsPanel.Location = new System.Drawing.Point(3, 3);
            ThumbnailSettingsPanel.Name = "ThumbnailSettingsPanel";
            ThumbnailSettingsPanel.Size = new System.Drawing.Size(226, 204);
            ThumbnailSettingsPanel.TabIndex = 19;
            // 
            // ThumbnailsWidthNumericEdit
            // 
            this.ThumbnailsWidthNumericEdit.BackColor = System.Drawing.Color.Transparent;
            this.ThumbnailsWidthNumericEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ThumbnailsWidthNumericEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ThumbnailsWidthNumericEdit.Location = new System.Drawing.Point(123, 57);
            this.ThumbnailsWidthNumericEdit.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ThumbnailsWidthNumericEdit.Name = "ThumbnailsWidthNumericEdit";
            this.ThumbnailsWidthNumericEdit.Size = new System.Drawing.Size(74, 27);
            this.ThumbnailsWidthNumericEdit.TabIndex = 26;
            // 
            // ThumbnailsHeightNumericEdit
            // 
            this.ThumbnailsHeightNumericEdit.BackColor = System.Drawing.Color.Transparent;
            this.ThumbnailsHeightNumericEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ThumbnailsHeightNumericEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ThumbnailsHeightNumericEdit.Location = new System.Drawing.Point(123, 87);
            this.ThumbnailsHeightNumericEdit.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ThumbnailsHeightNumericEdit.Name = "ThumbnailsHeightNumericEdit";
            this.ThumbnailsHeightNumericEdit.Size = new System.Drawing.Size(74, 27);
            this.ThumbnailsHeightNumericEdit.TabIndex = 27;
            // 
            // ThumbnailOpacityTrackBar
            // 
            this.ThumbnailOpacityTrackBar.Location = new System.Drawing.Point(6, 22);
            this.ThumbnailOpacityTrackBar.Name = "ThumbnailOpacityTrackBar";
            this.ThumbnailOpacityTrackBar.Size = new System.Drawing.Size(191, 22);
            this.ThumbnailOpacityTrackBar.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.ThumbnailOpacityTrackBar.TabIndex = 25;
            this.ThumbnailOpacityTrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.ThumbnailOpacityTrackBar.Value = 20;
            this.ThumbnailOpacityTrackBar.ValueChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // HeigthLabel
            // 
            HeigthLabel.AutoSize = true;
            HeigthLabel.Location = new System.Drawing.Point(6, 94);
            HeigthLabel.Name = "HeigthLabel";
            HeigthLabel.Size = new System.Drawing.Size(90, 13);
            HeigthLabel.TabIndex = 24;
            HeigthLabel.Text = "Thumbnail Heigth";
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new System.Drawing.Point(6, 63);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new System.Drawing.Size(87, 13);
            WidthLabel.TabIndex = 23;
            WidthLabel.Text = "Thumbnail Width";
            // 
            // OpacityLabel
            // 
            OpacityLabel.AutoSize = true;
            OpacityLabel.Location = new System.Drawing.Point(3, 6);
            OpacityLabel.Name = "OpacityLabel";
            OpacityLabel.Size = new System.Drawing.Size(43, 13);
            OpacityLabel.TabIndex = 19;
            OpacityLabel.Text = "Opacity";
            // 
            // ZoomTabPage
            // 
            this.ZoomTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.ZoomTabPage.Controls.Add(ZoomSettingsPanel);
            this.ZoomTabPage.Location = new System.Drawing.Point(154, 4);
            this.ZoomTabPage.Name = "ZoomTabPage";
            this.ZoomTabPage.Size = new System.Drawing.Size(232, 210);
            this.ZoomTabPage.TabIndex = 2;
            this.ZoomTabPage.Text = "Zoom";
            // 
            // ZoomSettingsPanel
            // 
            ZoomSettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ZoomSettingsPanel.Controls.Add(this.ThumbnailZoomFactorNumericEdit);
            ZoomSettingsPanel.Controls.Add(ZoomFactorLabel);
            ZoomSettingsPanel.Controls.Add(this.ZoomAnchorPanel);
            ZoomSettingsPanel.Controls.Add(ZoomAnchorLabel);
            ZoomSettingsPanel.Controls.Add(this.EnableThumbnailZoomCheckBox);
            ZoomSettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ZoomSettingsPanel.Location = new System.Drawing.Point(0, 0);
            ZoomSettingsPanel.Name = "ZoomSettingsPanel";
            ZoomSettingsPanel.Size = new System.Drawing.Size(232, 210);
            ZoomSettingsPanel.TabIndex = 36;
            // 
            // ThumbnailZoomFactorNumericEdit
            // 
            this.ThumbnailZoomFactorNumericEdit.BackColor = System.Drawing.Color.Transparent;
            this.ThumbnailZoomFactorNumericEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ThumbnailZoomFactorNumericEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ThumbnailZoomFactorNumericEdit.Location = new System.Drawing.Point(81, 29);
            this.ThumbnailZoomFactorNumericEdit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ThumbnailZoomFactorNumericEdit.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ThumbnailZoomFactorNumericEdit.Name = "ThumbnailZoomFactorNumericEdit";
            this.ThumbnailZoomFactorNumericEdit.Size = new System.Drawing.Size(77, 20);
            this.ThumbnailZoomFactorNumericEdit.TabIndex = 41;
            this.ThumbnailZoomFactorNumericEdit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ThumbnailZoomFactorNumericEdit.ValueChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ZoomFactorLabel
            // 
            ZoomFactorLabel.AutoSize = true;
            ZoomFactorLabel.Location = new System.Drawing.Point(8, 33);
            ZoomFactorLabel.Name = "ZoomFactorLabel";
            ZoomFactorLabel.Size = new System.Drawing.Size(67, 13);
            ZoomFactorLabel.TabIndex = 39;
            ZoomFactorLabel.Text = "Zoom Factor";
            // 
            // ZoomAnchorPanel
            // 
            this.ZoomAnchorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorNWRadioButton);
            this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorNRadioButton);
            this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorNERadioButton);
            this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorWRadioButton);
            this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorSERadioButton);
            this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorCRadioButton);
            this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorSRadioButton);
            this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorERadioButton);
            this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorSWRadioButton);
            this.ZoomAnchorPanel.Location = new System.Drawing.Point(81, 54);
            this.ZoomAnchorPanel.Name = "ZoomAnchorPanel";
            this.ZoomAnchorPanel.Size = new System.Drawing.Size(77, 73);
            this.ZoomAnchorPanel.TabIndex = 38;
            // 
            // ZoomAanchorNWRadioButton
            // 
            this.ZoomAanchorNWRadioButton.AutoSize = true;
            this.ZoomAanchorNWRadioButton.Location = new System.Drawing.Point(3, 3);
            this.ZoomAanchorNWRadioButton.Name = "ZoomAanchorNWRadioButton";
            this.ZoomAanchorNWRadioButton.Size = new System.Drawing.Size(14, 13);
            this.ZoomAanchorNWRadioButton.TabIndex = 0;
            this.ZoomAanchorNWRadioButton.TabStop = true;
            this.ZoomAanchorNWRadioButton.UseVisualStyleBackColor = true;
            this.ZoomAanchorNWRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ZoomAanchorNRadioButton
            // 
            this.ZoomAanchorNRadioButton.AutoSize = true;
            this.ZoomAanchorNRadioButton.Location = new System.Drawing.Point(31, 3);
            this.ZoomAanchorNRadioButton.Name = "ZoomAanchorNRadioButton";
            this.ZoomAanchorNRadioButton.Size = new System.Drawing.Size(14, 13);
            this.ZoomAanchorNRadioButton.TabIndex = 1;
            this.ZoomAanchorNRadioButton.TabStop = true;
            this.ZoomAanchorNRadioButton.UseVisualStyleBackColor = true;
            this.ZoomAanchorNRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ZoomAanchorNERadioButton
            // 
            this.ZoomAanchorNERadioButton.AutoSize = true;
            this.ZoomAanchorNERadioButton.Location = new System.Drawing.Point(59, 3);
            this.ZoomAanchorNERadioButton.Name = "ZoomAanchorNERadioButton";
            this.ZoomAanchorNERadioButton.Size = new System.Drawing.Size(14, 13);
            this.ZoomAanchorNERadioButton.TabIndex = 2;
            this.ZoomAanchorNERadioButton.TabStop = true;
            this.ZoomAanchorNERadioButton.UseVisualStyleBackColor = true;
            this.ZoomAanchorNERadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ZoomAanchorWRadioButton
            // 
            this.ZoomAanchorWRadioButton.AutoSize = true;
            this.ZoomAanchorWRadioButton.Location = new System.Drawing.Point(3, 29);
            this.ZoomAanchorWRadioButton.Name = "ZoomAanchorWRadioButton";
            this.ZoomAanchorWRadioButton.Size = new System.Drawing.Size(14, 13);
            this.ZoomAanchorWRadioButton.TabIndex = 3;
            this.ZoomAanchorWRadioButton.TabStop = true;
            this.ZoomAanchorWRadioButton.UseVisualStyleBackColor = true;
            this.ZoomAanchorWRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ZoomAanchorSERadioButton
            // 
            this.ZoomAanchorSERadioButton.AutoSize = true;
            this.ZoomAanchorSERadioButton.Location = new System.Drawing.Point(59, 55);
            this.ZoomAanchorSERadioButton.Name = "ZoomAanchorSERadioButton";
            this.ZoomAanchorSERadioButton.Size = new System.Drawing.Size(14, 13);
            this.ZoomAanchorSERadioButton.TabIndex = 8;
            this.ZoomAanchorSERadioButton.TabStop = true;
            this.ZoomAanchorSERadioButton.UseVisualStyleBackColor = true;
            this.ZoomAanchorSERadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ZoomAanchorCRadioButton
            // 
            this.ZoomAanchorCRadioButton.AutoSize = true;
            this.ZoomAanchorCRadioButton.Location = new System.Drawing.Point(31, 29);
            this.ZoomAanchorCRadioButton.Name = "ZoomAanchorCRadioButton";
            this.ZoomAanchorCRadioButton.Size = new System.Drawing.Size(14, 13);
            this.ZoomAanchorCRadioButton.TabIndex = 4;
            this.ZoomAanchorCRadioButton.TabStop = true;
            this.ZoomAanchorCRadioButton.UseVisualStyleBackColor = true;
            this.ZoomAanchorCRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ZoomAanchorSRadioButton
            // 
            this.ZoomAanchorSRadioButton.AutoSize = true;
            this.ZoomAanchorSRadioButton.Location = new System.Drawing.Point(31, 55);
            this.ZoomAanchorSRadioButton.Name = "ZoomAanchorSRadioButton";
            this.ZoomAanchorSRadioButton.Size = new System.Drawing.Size(14, 13);
            this.ZoomAanchorSRadioButton.TabIndex = 7;
            this.ZoomAanchorSRadioButton.TabStop = true;
            this.ZoomAanchorSRadioButton.UseVisualStyleBackColor = true;
            this.ZoomAanchorSRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ZoomAanchorERadioButton
            // 
            this.ZoomAanchorERadioButton.AutoSize = true;
            this.ZoomAanchorERadioButton.Location = new System.Drawing.Point(59, 29);
            this.ZoomAanchorERadioButton.Name = "ZoomAanchorERadioButton";
            this.ZoomAanchorERadioButton.Size = new System.Drawing.Size(14, 13);
            this.ZoomAanchorERadioButton.TabIndex = 5;
            this.ZoomAanchorERadioButton.TabStop = true;
            this.ZoomAanchorERadioButton.UseVisualStyleBackColor = true;
            this.ZoomAanchorERadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ZoomAanchorSWRadioButton
            // 
            this.ZoomAanchorSWRadioButton.AutoSize = true;
            this.ZoomAanchorSWRadioButton.Location = new System.Drawing.Point(3, 55);
            this.ZoomAanchorSWRadioButton.Name = "ZoomAanchorSWRadioButton";
            this.ZoomAanchorSWRadioButton.Size = new System.Drawing.Size(14, 13);
            this.ZoomAanchorSWRadioButton.TabIndex = 6;
            this.ZoomAanchorSWRadioButton.TabStop = true;
            this.ZoomAanchorSWRadioButton.UseVisualStyleBackColor = true;
            this.ZoomAanchorSWRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ZoomAnchorLabel
            // 
            ZoomAnchorLabel.AutoSize = true;
            ZoomAnchorLabel.Location = new System.Drawing.Point(8, 57);
            ZoomAnchorLabel.Name = "ZoomAnchorLabel";
            ZoomAnchorLabel.Size = new System.Drawing.Size(41, 13);
            ZoomAnchorLabel.TabIndex = 40;
            ZoomAnchorLabel.Text = "Anchor";
            // 
            // EnableThumbnailZoomCheckBox
            // 
            this.EnableThumbnailZoomCheckBox.AutoSize = true;
            this.EnableThumbnailZoomCheckBox.Checked = true;
            this.EnableThumbnailZoomCheckBox.CheckedState.BorderRadius = 0;
            this.EnableThumbnailZoomCheckBox.CheckedState.BorderThickness = 0;
            this.EnableThumbnailZoomCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableThumbnailZoomCheckBox.Location = new System.Drawing.Point(8, 7);
            this.EnableThumbnailZoomCheckBox.Name = "EnableThumbnailZoomCheckBox";
            this.EnableThumbnailZoomCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EnableThumbnailZoomCheckBox.Size = new System.Drawing.Size(98, 17);
            this.EnableThumbnailZoomCheckBox.TabIndex = 36;
            this.EnableThumbnailZoomCheckBox.Text = "Zoom on hover";
            this.EnableThumbnailZoomCheckBox.UncheckedState.BorderRadius = 0;
            this.EnableThumbnailZoomCheckBox.UncheckedState.BorderThickness = 0;
            this.EnableThumbnailZoomCheckBox.UseVisualStyleBackColor = true;
            this.EnableThumbnailZoomCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // OverlayTabPage
            // 
            OverlayTabPage.BackColor = System.Drawing.SystemColors.Control;
            OverlayTabPage.Controls.Add(OverlaySettingsPanel);
            OverlayTabPage.Location = new System.Drawing.Point(154, 4);
            OverlayTabPage.Name = "OverlayTabPage";
            OverlayTabPage.Size = new System.Drawing.Size(232, 210);
            OverlayTabPage.TabIndex = 3;
            OverlayTabPage.Text = "Overlay";
            // 
            // OverlaySettingsPanel
            // 
            OverlaySettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            OverlaySettingsPanel.Controls.Add(this.HighlightColorLabel);
            OverlaySettingsPanel.Controls.Add(this.ActiveClientHighlightColorButton);
            OverlaySettingsPanel.Controls.Add(this.EnableActiveClientHighlightCheckBox);
            OverlaySettingsPanel.Controls.Add(this.ShowThumbnailOverlaysCheckBox);
            OverlaySettingsPanel.Controls.Add(this.ShowThumbnailFramesCheckBox);
            OverlaySettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            OverlaySettingsPanel.Location = new System.Drawing.Point(0, 0);
            OverlaySettingsPanel.Name = "OverlaySettingsPanel";
            OverlaySettingsPanel.Size = new System.Drawing.Size(232, 210);
            OverlaySettingsPanel.TabIndex = 25;
            // 
            // HighlightColorLabel
            // 
            this.HighlightColorLabel.AutoSize = true;
            this.HighlightColorLabel.Location = new System.Drawing.Point(5, 78);
            this.HighlightColorLabel.Name = "HighlightColorLabel";
            this.HighlightColorLabel.Size = new System.Drawing.Size(31, 13);
            this.HighlightColorLabel.TabIndex = 29;
            this.HighlightColorLabel.Text = "Color";
            // 
            // ActiveClientHighlightColorButton
            // 
            this.ActiveClientHighlightColorButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActiveClientHighlightColorButton.Location = new System.Drawing.Point(42, 77);
            this.ActiveClientHighlightColorButton.Name = "ActiveClientHighlightColorButton";
            this.ActiveClientHighlightColorButton.Size = new System.Drawing.Size(93, 17);
            this.ActiveClientHighlightColorButton.TabIndex = 28;
            this.ActiveClientHighlightColorButton.Click += new System.EventHandler(this.ActiveClientHighlightColorButton_Click);
            // 
            // EnableActiveClientHighlightCheckBox
            // 
            this.EnableActiveClientHighlightCheckBox.AutoSize = true;
            this.EnableActiveClientHighlightCheckBox.Checked = true;
            this.EnableActiveClientHighlightCheckBox.CheckedState.BorderRadius = 0;
            this.EnableActiveClientHighlightCheckBox.CheckedState.BorderThickness = 0;
            this.EnableActiveClientHighlightCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableActiveClientHighlightCheckBox.Location = new System.Drawing.Point(8, 55);
            this.EnableActiveClientHighlightCheckBox.Name = "EnableActiveClientHighlightCheckBox";
            this.EnableActiveClientHighlightCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EnableActiveClientHighlightCheckBox.Size = new System.Drawing.Size(127, 17);
            this.EnableActiveClientHighlightCheckBox.TabIndex = 27;
            this.EnableActiveClientHighlightCheckBox.Text = "Highlight active client";
            this.EnableActiveClientHighlightCheckBox.UncheckedState.BorderRadius = 0;
            this.EnableActiveClientHighlightCheckBox.UncheckedState.BorderThickness = 0;
            this.EnableActiveClientHighlightCheckBox.UseVisualStyleBackColor = true;
            this.EnableActiveClientHighlightCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ShowThumbnailOverlaysCheckBox
            // 
            this.ShowThumbnailOverlaysCheckBox.AutoSize = true;
            this.ShowThumbnailOverlaysCheckBox.Checked = true;
            this.ShowThumbnailOverlaysCheckBox.CheckedState.BorderRadius = 0;
            this.ShowThumbnailOverlaysCheckBox.CheckedState.BorderThickness = 0;
            this.ShowThumbnailOverlaysCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowThumbnailOverlaysCheckBox.Location = new System.Drawing.Point(8, 7);
            this.ShowThumbnailOverlaysCheckBox.Name = "ShowThumbnailOverlaysCheckBox";
            this.ShowThumbnailOverlaysCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowThumbnailOverlaysCheckBox.Size = new System.Drawing.Size(90, 17);
            this.ShowThumbnailOverlaysCheckBox.TabIndex = 25;
            this.ShowThumbnailOverlaysCheckBox.Text = "Show overlay";
            this.ShowThumbnailOverlaysCheckBox.UncheckedState.BorderRadius = 0;
            this.ShowThumbnailOverlaysCheckBox.UncheckedState.BorderThickness = 0;
            this.ShowThumbnailOverlaysCheckBox.UseVisualStyleBackColor = true;
            this.ShowThumbnailOverlaysCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ShowThumbnailFramesCheckBox
            // 
            this.ShowThumbnailFramesCheckBox.AutoSize = true;
            this.ShowThumbnailFramesCheckBox.Checked = true;
            this.ShowThumbnailFramesCheckBox.CheckedState.BorderRadius = 0;
            this.ShowThumbnailFramesCheckBox.CheckedState.BorderThickness = 0;
            this.ShowThumbnailFramesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowThumbnailFramesCheckBox.Location = new System.Drawing.Point(8, 31);
            this.ShowThumbnailFramesCheckBox.Name = "ShowThumbnailFramesCheckBox";
            this.ShowThumbnailFramesCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowThumbnailFramesCheckBox.Size = new System.Drawing.Size(87, 17);
            this.ShowThumbnailFramesCheckBox.TabIndex = 26;
            this.ShowThumbnailFramesCheckBox.Text = "Show frames";
            this.ShowThumbnailFramesCheckBox.UncheckedState.BorderRadius = 0;
            this.ShowThumbnailFramesCheckBox.UncheckedState.BorderThickness = 0;
            this.ShowThumbnailFramesCheckBox.UseVisualStyleBackColor = true;
            this.ShowThumbnailFramesCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ClientsTabPage
            // 
            ClientsTabPage.BackColor = System.Drawing.SystemColors.Control;
            ClientsTabPage.Controls.Add(ClientsPanel);
            ClientsTabPage.Location = new System.Drawing.Point(154, 4);
            ClientsTabPage.Name = "ClientsTabPage";
            ClientsTabPage.Size = new System.Drawing.Size(232, 210);
            ClientsTabPage.TabIndex = 4;
            ClientsTabPage.Text = "Active Clients";
            // 
            // ClientsPanel
            // 
            ClientsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ClientsPanel.Controls.Add(this.ThumbnailsList);
            ClientsPanel.Controls.Add(ThumbnailsListLabel);
            ClientsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ClientsPanel.Location = new System.Drawing.Point(0, 0);
            ClientsPanel.Name = "ClientsPanel";
            ClientsPanel.Size = new System.Drawing.Size(232, 210);
            ClientsPanel.TabIndex = 32;
            // 
            // ThumbnailsList
            // 
            this.ThumbnailsList.BackColor = System.Drawing.SystemColors.Window;
            this.ThumbnailsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThumbnailsList.CheckOnClick = true;
            this.ThumbnailsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ThumbnailsList.FormattingEnabled = true;
            this.ThumbnailsList.IntegralHeight = false;
            this.ThumbnailsList.Location = new System.Drawing.Point(0, 28);
            this.ThumbnailsList.Name = "ThumbnailsList";
            this.ThumbnailsList.Size = new System.Drawing.Size(230, 180);
            this.ThumbnailsList.TabIndex = 34;
            this.ThumbnailsList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ThumbnailsList_ItemCheck_Handler);
            // 
            // ThumbnailsListLabel
            // 
            ThumbnailsListLabel.AutoSize = true;
            ThumbnailsListLabel.Location = new System.Drawing.Point(8, 9);
            ThumbnailsListLabel.Name = "ThumbnailsListLabel";
            ThumbnailsListLabel.Size = new System.Drawing.Size(162, 13);
            ThumbnailsListLabel.TabIndex = 33;
            ThumbnailsListLabel.Text = "Thumbnails (check to force hide)";
            // 
            // AboutTabPage
            // 
            AboutTabPage.BackColor = System.Drawing.SystemColors.Control;
            AboutTabPage.Controls.Add(AboutPanel);
            AboutTabPage.Location = new System.Drawing.Point(154, 4);
            AboutTabPage.Name = "AboutTabPage";
            AboutTabPage.Size = new System.Drawing.Size(232, 210);
            AboutTabPage.TabIndex = 5;
            AboutTabPage.Text = "About";
            // 
            // AboutPanel
            // 
            AboutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            AboutPanel.Controls.Add(this.label14);
            AboutPanel.Controls.Add(this.label15);
            AboutPanel.Controls.Add(this.label16);
            AboutPanel.Controls.Add(this.label17);
            AboutPanel.Controls.Add(this.label18);
            AboutPanel.Controls.Add(this.label19);
            AboutPanel.Controls.Add(this.label20);
            AboutPanel.Controls.Add(this.label21);
            AboutPanel.Controls.Add(this.label22);
            AboutPanel.Controls.Add(this.label23);
            AboutPanel.Controls.Add(this.label24);
            AboutPanel.Controls.Add(this.label25);
            AboutPanel.Controls.Add(this.label11);
            AboutPanel.Controls.Add(this.label12);
            AboutPanel.Controls.Add(this.label13);
            AboutPanel.Controls.Add(this.label8);
            AboutPanel.Controls.Add(this.label9);
            AboutPanel.Controls.Add(this.label10);
            AboutPanel.Controls.Add(this.label5);
            AboutPanel.Controls.Add(this.label6);
            AboutPanel.Controls.Add(this.label7);
            AboutPanel.Controls.Add(this.label4);
            AboutPanel.Controls.Add(this.label3);
            AboutPanel.Controls.Add(this.label2);
            AboutPanel.Controls.Add(this.label1);
            AboutPanel.Controls.Add(this.VersionLabel);
            AboutPanel.Controls.Add(NameLabel);
            AboutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            AboutPanel.Location = new System.Drawing.Point(0, 0);
            AboutPanel.Name = "AboutPanel";
            AboutPanel.Size = new System.Drawing.Size(232, 210);
            AboutPanel.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(67, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Bla bla bla";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(67, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Bla bla bla";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(67, 182);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Bla bla bla";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(67, 169);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Bla bla bla";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(67, 156);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "Bla bla bla";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(67, 143);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "Bla bla bla";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 208);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "Bla bla bla";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 195);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 13);
            this.label21.TabIndex = 24;
            this.label21.Text = "Bla bla bla";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(5, 182);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 13);
            this.label22.TabIndex = 23;
            this.label22.Text = "Bla bla bla";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 169);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "Bla bla bla";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(5, 156);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 13);
            this.label24.TabIndex = 21;
            this.label24.Text = "Bla bla bla";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 143);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 13);
            this.label25.TabIndex = 20;
            this.label25.Text = "Bla bla bla";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Bla bla bla";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Bla bla bla";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(67, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Bla bla bla";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Bla bla bla";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Bla bla bla";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Bla bla bla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bla bla bla";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bla bla bla";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Bla bla bla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bla bla bla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bla bla bla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bla bla bla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Edited by Pinguu | EVE-Master Edition";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VersionLabel.Location = new System.Drawing.Point(133, 9);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(49, 20);
            this.VersionLabel.TabIndex = 4;
            this.VersionLabel.Text = "1.0.0";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            NameLabel.Location = new System.Drawing.Point(4, 9);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(130, 20);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "EVE-O Preview";
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.TrayMenu;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "EVE-O Preview";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RestoreMainForm_Handler);
            // 
            // TrayMenu
            // 
            this.TrayMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            TitleMenuItem,
            RestoreWindowMenuItem,
            SeparatorMenuItem,
            ExitMenuItem});
            this.TrayMenu.Name = "contextMenuStrip1";
            this.TrayMenu.Size = new System.Drawing.Size(238, 76);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(390, 218);
            this.Controls.Add(ContentTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "EVE-O Preview (EVE-Master Edition)";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing_Handler);
            this.Load += new System.EventHandler(this.MainFormResize_Handler);
            this.Resize += new System.EventHandler(this.MainFormResize_Handler);
            ContentTabControl.ResumeLayout(false);
            GeneralTabPage.ResumeLayout(false);
            GeneralSettingsPanel.ResumeLayout(false);
            GeneralSettingsPanel.PerformLayout();
            ThumbnailTabPage.ResumeLayout(false);
            ThumbnailSettingsPanel.ResumeLayout(false);
            ThumbnailSettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailsWidthNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailsHeightNumericEdit)).EndInit();
            this.ZoomTabPage.ResumeLayout(false);
            ZoomSettingsPanel.ResumeLayout(false);
            ZoomSettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailZoomFactorNumericEdit)).EndInit();
            this.ZoomAnchorPanel.ResumeLayout(false);
            this.ZoomAnchorPanel.PerformLayout();
            OverlayTabPage.ResumeLayout(false);
            OverlaySettingsPanel.ResumeLayout(false);
            OverlaySettingsPanel.PerformLayout();
            ClientsTabPage.ResumeLayout(false);
            ClientsPanel.ResumeLayout(false);
            ClientsPanel.PerformLayout();
            AboutTabPage.ResumeLayout(false);
            AboutPanel.ResumeLayout(false);
            AboutPanel.PerformLayout();
            this.TrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private NotifyIcon NotifyIcon;
		private ContextMenuStrip TrayMenu;
		private TabPage ZoomTabPage;
		private Guna.UI2.WinForms.Guna2CheckBox HideActiveClientThumbnailCheckBox;
		private Guna.UI2.WinForms.Guna2CheckBox ShowThumbnailsAlwaysOnTopCheckBox;
		private Guna.UI2.WinForms.Guna2CheckBox HideThumbnailsOnLostFocusCheckBox;
		private Guna.UI2.WinForms.Guna2CheckBox EnablePerClientThumbnailsLayoutsCheckBox;
		private Panel ZoomAnchorPanel;
		private RadioButton ZoomAanchorNWRadioButton;
		private RadioButton ZoomAanchorNRadioButton;
		private RadioButton ZoomAanchorNERadioButton;
		private RadioButton ZoomAanchorWRadioButton;
		private RadioButton ZoomAanchorSERadioButton;
		private RadioButton ZoomAanchorCRadioButton;
		private RadioButton ZoomAanchorSRadioButton;
		private RadioButton ZoomAanchorERadioButton;
		private RadioButton ZoomAanchorSWRadioButton;
		private Guna.UI2.WinForms.Guna2CheckBox EnableThumbnailZoomCheckBox;
		private Label HighlightColorLabel;
		private Panel ActiveClientHighlightColorButton;
		private Guna.UI2.WinForms.Guna2CheckBox EnableActiveClientHighlightCheckBox;
		private Guna.UI2.WinForms.Guna2CheckBox ShowThumbnailOverlaysCheckBox;
		private Guna.UI2.WinForms.Guna2CheckBox ShowThumbnailFramesCheckBox;
		private CheckedListBox ThumbnailsList;
		private Label VersionLabel;
		private Guna.UI2.WinForms.Guna2CheckBox MinimizeInactiveClientsCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox MinimizeToTrayCheckBox;
        private Guna.UI2.WinForms.Guna2TrackBar ThumbnailOpacityTrackBar;
        private Guna.UI2.WinForms.Guna2NumericUpDown ThumbnailsWidthNumericEdit;
        private Guna.UI2.WinForms.Guna2NumericUpDown ThumbnailsHeightNumericEdit;
        private Guna.UI2.WinForms.Guna2NumericUpDown ThumbnailZoomFactorNumericEdit;
        private Label label1;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}