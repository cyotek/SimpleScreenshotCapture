namespace Cyotek.Demo.SimpleScreenshotCapture
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
      this.components = new System.ComponentModel.Container();
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.previewGroupBox = new Cyotek.Windows.Forms.GroupBox();
      this.previewImageBox = new Cyotek.Windows.Forms.ImageBox();
      this.setupGroupBox = new Cyotek.Windows.Forms.GroupBox();
      this.workingAreaCheckBox = new System.Windows.Forms.CheckBox();
      this.line = new Cyotek.Windows.Forms.Line();
      this.desktopRadioButton = new System.Windows.Forms.RadioButton();
      this.monitorComboBox = new System.Windows.Forms.ComboBox();
      this.monitorRadioButton = new System.Windows.Forms.RadioButton();
      this.currentMonitorRadioButton = new System.Windows.Forms.RadioButton();
      this.currentWindowRadioButton = new System.Windows.Forms.RadioButton();
      this.label1 = new System.Windows.Forms.Label();
      this.splitContainer = new System.Windows.Forms.SplitContainer();
      this.toolStrip = new System.Windows.Forms.ToolStrip();
      this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
      this.captureToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.delayCaptureToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.delayCaptureTimer = new System.Windows.Forms.Timer(this.components);
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.timerToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.menuStrip.SuspendLayout();
      this.previewGroupBox.SuspendLayout();
      this.setupGroupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
      this.splitContainer.Panel1.SuspendLayout();
      this.splitContainer.Panel2.SuspendLayout();
      this.splitContainer.SuspendLayout();
      this.toolStrip.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(867, 24);
      this.menuStrip.TabIndex = 0;
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // captureToolStripMenuItem
      // 
      this.captureToolStripMenuItem.Image = global::Cyotek.Demo.SimpleScreenshotCapture.Properties.Resources.Capture;
      this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
      this.captureToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
      this.captureToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.captureToolStripMenuItem.Text = "&Capture";
      this.captureToolStripMenuItem.Click += new System.EventHandler(this.captureToolStripMenuItem_Click);
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Image = global::Cyotek.Demo.SimpleScreenshotCapture.Properties.Resources.Save;
      this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.saveToolStripMenuItem.Text = "&Save...";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editToolStripMenuItem.Text = "&Edit";
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.Image = global::Cyotek.Demo.SimpleScreenshotCapture.Properties.Resources.Copy;
      this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.copyToolStripMenuItem.Text = "&Copy";
      this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
      this.aboutToolStripMenuItem.Text = "&About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // previewGroupBox
      // 
      this.previewGroupBox.Controls.Add(this.previewImageBox);
      this.previewGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.previewGroupBox.Location = new System.Drawing.Point(0, 0);
      this.previewGroupBox.Name = "previewGroupBox";
      this.previewGroupBox.Size = new System.Drawing.Size(558, 316);
      this.previewGroupBox.TabIndex = 0;
      this.previewGroupBox.TabStop = false;
      this.previewGroupBox.Text = "Preview";
      // 
      // previewImageBox
      // 
      this.previewImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.previewImageBox.Location = new System.Drawing.Point(6, 19);
      this.previewImageBox.Name = "previewImageBox";
      this.previewImageBox.Size = new System.Drawing.Size(546, 291);
      this.previewImageBox.TabIndex = 0;
      this.previewImageBox.TabStop = false;
      this.previewImageBox.Zoomed += new System.EventHandler<Cyotek.Windows.Forms.ImageBoxZoomEventArgs>(this.previewImageBox_Zoomed);
      // 
      // setupGroupBox
      // 
      this.setupGroupBox.Controls.Add(this.workingAreaCheckBox);
      this.setupGroupBox.Controls.Add(this.line);
      this.setupGroupBox.Controls.Add(this.desktopRadioButton);
      this.setupGroupBox.Controls.Add(this.monitorComboBox);
      this.setupGroupBox.Controls.Add(this.monitorRadioButton);
      this.setupGroupBox.Controls.Add(this.currentMonitorRadioButton);
      this.setupGroupBox.Controls.Add(this.currentWindowRadioButton);
      this.setupGroupBox.Controls.Add(this.label1);
      this.setupGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.setupGroupBox.Location = new System.Drawing.Point(0, 0);
      this.setupGroupBox.Name = "setupGroupBox";
      this.setupGroupBox.Size = new System.Drawing.Size(281, 316);
      this.setupGroupBox.TabIndex = 0;
      this.setupGroupBox.TabStop = false;
      this.setupGroupBox.Text = "Capture Setup";
      // 
      // workingAreaCheckBox
      // 
      this.workingAreaCheckBox.AutoSize = true;
      this.workingAreaCheckBox.Location = new System.Drawing.Point(6, 167);
      this.workingAreaCheckBox.Name = "workingAreaCheckBox";
      this.workingAreaCheckBox.Size = new System.Drawing.Size(115, 17);
      this.workingAreaCheckBox.TabIndex = 6;
      this.workingAreaCheckBox.Text = "&Working Area Only";
      this.workingAreaCheckBox.UseVisualStyleBackColor = true;
      // 
      // line
      // 
      this.line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.line.Location = new System.Drawing.Point(6, 151);
      this.line.Name = "line";
      this.line.Size = new System.Drawing.Size(269, 10);
      this.line.Text = "label2";
      // 
      // desktopRadioButton
      // 
      this.desktopRadioButton.AutoSize = true;
      this.desktopRadioButton.Location = new System.Drawing.Point(6, 128);
      this.desktopRadioButton.Name = "desktopRadioButton";
      this.desktopRadioButton.Size = new System.Drawing.Size(95, 17);
      this.desktopRadioButton.TabIndex = 5;
      this.desktopRadioButton.Text = "Entire &Desktop";
      this.desktopRadioButton.UseVisualStyleBackColor = true;
      // 
      // monitorComboBox
      // 
      this.monitorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.monitorComboBox.FormattingEnabled = true;
      this.monitorComboBox.Location = new System.Drawing.Point(22, 101);
      this.monitorComboBox.Name = "monitorComboBox";
      this.monitorComboBox.Size = new System.Drawing.Size(121, 21);
      this.monitorComboBox.TabIndex = 4;
      this.monitorComboBox.SelectedIndexChanged += new System.EventHandler(this.monitorComboBox_SelectedIndexChanged);
      // 
      // monitorRadioButton
      // 
      this.monitorRadioButton.AutoSize = true;
      this.monitorRadioButton.Location = new System.Drawing.Point(6, 78);
      this.monitorRadioButton.Name = "monitorRadioButton";
      this.monitorRadioButton.Size = new System.Drawing.Size(98, 17);
      this.monitorRadioButton.TabIndex = 3;
      this.monitorRadioButton.Text = "Custom M&onitor";
      this.monitorRadioButton.UseVisualStyleBackColor = true;
      // 
      // currentMonitorRadioButton
      // 
      this.currentMonitorRadioButton.AutoSize = true;
      this.currentMonitorRadioButton.Location = new System.Drawing.Point(6, 55);
      this.currentMonitorRadioButton.Name = "currentMonitorRadioButton";
      this.currentMonitorRadioButton.Size = new System.Drawing.Size(97, 17);
      this.currentMonitorRadioButton.TabIndex = 2;
      this.currentMonitorRadioButton.Text = "Current &Monitor";
      this.currentMonitorRadioButton.UseVisualStyleBackColor = true;
      // 
      // currentWindowRadioButton
      // 
      this.currentWindowRadioButton.AutoSize = true;
      this.currentWindowRadioButton.Checked = true;
      this.currentWindowRadioButton.Location = new System.Drawing.Point(6, 32);
      this.currentWindowRadioButton.Name = "currentWindowRadioButton";
      this.currentWindowRadioButton.Size = new System.Drawing.Size(101, 17);
      this.currentWindowRadioButton.TabIndex = 1;
      this.currentWindowRadioButton.TabStop = true;
      this.currentWindowRadioButton.Text = "Current &Window";
      this.currentWindowRadioButton.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(160, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "What would you like to capture?";
      // 
      // splitContainer
      // 
      this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.splitContainer.Location = new System.Drawing.Point(12, 52);
      this.splitContainer.Name = "splitContainer";
      // 
      // splitContainer.Panel1
      // 
      this.splitContainer.Panel1.Controls.Add(this.setupGroupBox);
      // 
      // splitContainer.Panel2
      // 
      this.splitContainer.Panel2.Controls.Add(this.previewGroupBox);
      this.splitContainer.Size = new System.Drawing.Size(843, 316);
      this.splitContainer.SplitterDistance = 281;
      this.splitContainer.TabIndex = 2;
      // 
      // toolStrip
      // 
      this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.copyToolStripButton,
            this.toolStripSeparator7,
            this.captureToolStripButton,
            this.delayCaptureToolStripButton});
      this.toolStrip.Location = new System.Drawing.Point(0, 24);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new System.Drawing.Size(867, 25);
      this.toolStrip.TabIndex = 1;
      // 
      // saveToolStripButton
      // 
      this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.saveToolStripButton.Image = global::Cyotek.Demo.SimpleScreenshotCapture.Properties.Resources.Save;
      this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripButton.Name = "saveToolStripButton";
      this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.saveToolStripButton.Text = "&Save";
      this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // toolStripSeparator6
      // 
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
      // 
      // copyToolStripButton
      // 
      this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.copyToolStripButton.Image = global::Cyotek.Demo.SimpleScreenshotCapture.Properties.Resources.Copy;
      this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyToolStripButton.Name = "copyToolStripButton";
      this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.copyToolStripButton.Text = "&Copy";
      this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
      // 
      // toolStripSeparator7
      // 
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
      // 
      // captureToolStripButton
      // 
      this.captureToolStripButton.Image = global::Cyotek.Demo.SimpleScreenshotCapture.Properties.Resources.Capture;
      this.captureToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.captureToolStripButton.Name = "captureToolStripButton";
      this.captureToolStripButton.Size = new System.Drawing.Size(69, 22);
      this.captureToolStripButton.Text = "&Capture";
      this.captureToolStripButton.Click += new System.EventHandler(this.captureToolStripMenuItem_Click);
      // 
      // delayCaptureToolStripButton
      // 
      this.delayCaptureToolStripButton.Image = global::Cyotek.Demo.SimpleScreenshotCapture.Properties.Resources.Timer;
      this.delayCaptureToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.delayCaptureToolStripButton.Name = "delayCaptureToolStripButton";
      this.delayCaptureToolStripButton.Size = new System.Drawing.Size(101, 22);
      this.delayCaptureToolStripButton.Text = "&Delay Capture";
      this.delayCaptureToolStripButton.Click += new System.EventHandler(this.delayCaptureToolStripButton_Click);
      // 
      // delayCaptureTimer
      // 
      this.delayCaptureTimer.Interval = 1000;
      this.delayCaptureTimer.Tick += new System.EventHandler(this.delayCaptureTimer_Tick);
      // 
      // statusStrip
      // 
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.timerToolStripStatusLabel});
      this.statusStrip.Location = new System.Drawing.Point(0, 371);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new System.Drawing.Size(867, 22);
      this.statusStrip.TabIndex = 3;
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(852, 17);
      this.toolStripStatusLabel1.Spring = true;
      this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // timerToolStripStatusLabel
      // 
      this.timerToolStripStatusLabel.Name = "timerToolStripStatusLabel";
      this.timerToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(867, 393);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.toolStrip);
      this.Controls.Add(this.splitContainer);
      this.Controls.Add(this.menuStrip);
      this.MainMenuStrip = this.menuStrip;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Simple Screenshot Capture";
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.previewGroupBox.ResumeLayout(false);
      this.setupGroupBox.ResumeLayout(false);
      this.setupGroupBox.PerformLayout();
      this.splitContainer.Panel1.ResumeLayout(false);
      this.splitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
      this.splitContainer.ResumeLayout(false);
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private Cyotek.Windows.Forms.ImageBox previewImageBox;
    private Cyotek.Windows.Forms.GroupBox setupGroupBox;
    private System.Windows.Forms.RadioButton desktopRadioButton;
    private System.Windows.Forms.ComboBox monitorComboBox;
    private System.Windows.Forms.RadioButton monitorRadioButton;
    private System.Windows.Forms.RadioButton currentMonitorRadioButton;
    private System.Windows.Forms.RadioButton currentWindowRadioButton;
    private System.Windows.Forms.Label label1;
    private Cyotek.Windows.Forms.GroupBox previewGroupBox;
    private Cyotek.Windows.Forms.Line line;
    private System.Windows.Forms.CheckBox workingAreaCheckBox;
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.SplitContainer splitContainer;
    private System.Windows.Forms.ToolStrip toolStrip;
    private System.Windows.Forms.ToolStripButton saveToolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripButton copyToolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    private System.Windows.Forms.ToolStripButton captureToolStripButton;
    private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripButton delayCaptureToolStripButton;
    private System.Windows.Forms.Timer delayCaptureTimer;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel timerToolStripStatusLabel;
  }
}

