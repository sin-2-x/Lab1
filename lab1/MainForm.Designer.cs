
using System;

namespace Lab1 {
  partial class MainForm {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
      this.scrollPanel = new System.Windows.Forms.Panel();
      this.pictureBox = new System.Windows.Forms.PictureBox();
      this.tabControl = new System.Windows.Forms.TabControl();
      this.tabRandom = new System.Windows.Forms.TabPage();
      this.buttonRemoveRandom = new System.Windows.Forms.Button();
      this.buttonAddRandom = new System.Windows.Forms.Button();
      this.textRandomInput = new System.Windows.Forms.TextBox();
      this.labelRandom = new System.Windows.Forms.Label();
      this.buttonStartRandom = new System.Windows.Forms.Button();
      this.textRandomOutput = new System.Windows.Forms.TextBox();
      this.tabKeyboard = new System.Windows.Forms.TabPage();
      this.buttonRemoveKeyboard = new System.Windows.Forms.Button();
      this.labelKeyboard = new System.Windows.Forms.Label();
      this.buttonStartKeyboard = new System.Windows.Forms.Button();
      this.buttonAddKeyboard = new System.Windows.Forms.Button();
      this.textKeyboardInput = new System.Windows.Forms.TextBox();
      this.tabFile = new System.Windows.Forms.TabPage();
      this.buttonRemoveFile = new System.Windows.Forms.Button();
      this.buttonOpenFile = new System.Windows.Forms.Button();
      this.buttonStartFile = new System.Windows.Forms.Button();
      this.buttonAddFile = new System.Windows.Forms.Button();
      this.textFileOutput = new System.Windows.Forms.TextBox();
      this.cleanBtn = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveInnerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.showGreetingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.scrollPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
      this.tabControl.SuspendLayout();
      this.tabRandom.SuspendLayout();
      this.tabKeyboard.SuspendLayout();
      this.tabFile.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // scrollPanel
      // 
      this.scrollPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.scrollPanel.AutoScroll = true;
      this.scrollPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.scrollPanel.Controls.Add(this.pictureBox);
      this.scrollPanel.Location = new System.Drawing.Point(0, 129);
      this.scrollPanel.Margin = new System.Windows.Forms.Padding(0);
      this.scrollPanel.Name = "scrollPanel";
      this.scrollPanel.Size = new System.Drawing.Size(781, 360);
      this.scrollPanel.TabIndex = 7;
      this.scrollPanel.SizeChanged += new System.EventHandler(this.ScrollPanel_SizeChanged);
      // 
      // pictureBox
      // 
      this.pictureBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.pictureBox.Location = new System.Drawing.Point(0, 0);
      this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
      this.pictureBox.Name = "pictureBox";
      this.pictureBox.Size = new System.Drawing.Size(781, 360);
      this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox.TabIndex = 0;
      this.pictureBox.TabStop = false;
      this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
      this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
      this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
      this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
      // 
      // tabControl
      // 
      this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl.Controls.Add(this.tabRandom);
      this.tabControl.Controls.Add(this.tabKeyboard);
      this.tabControl.Controls.Add(this.tabFile);
      this.tabControl.Location = new System.Drawing.Point(12, 30);
      this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(694, 97);
      this.tabControl.TabIndex = 1;
      // 
      // tabRandom
      // 
      this.tabRandom.Controls.Add(this.buttonRemoveRandom);
      this.tabRandom.Controls.Add(this.buttonAddRandom);
      this.tabRandom.Controls.Add(this.textRandomInput);
      this.tabRandom.Controls.Add(this.labelRandom);
      this.tabRandom.Controls.Add(this.buttonStartRandom);
      this.tabRandom.Controls.Add(this.textRandomOutput);
      this.tabRandom.Location = new System.Drawing.Point(4, 25);
      this.tabRandom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabRandom.Name = "tabRandom";
      this.tabRandom.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabRandom.Size = new System.Drawing.Size(641, 71);
      this.tabRandom.TabIndex = 1;
      this.tabRandom.Text = "Random";
      this.tabRandom.UseVisualStyleBackColor = true;
      // 
      // buttonRemoveRandom
      // 
      this.buttonRemoveRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonRemoveRandom.Location = new System.Drawing.Point(467, 25);
      this.buttonRemoveRandom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonRemoveRandom.Name = "buttonRemoveRandom";
      this.buttonRemoveRandom.Size = new System.Drawing.Size(32, 23);
      this.buttonRemoveRandom.TabIndex = 15;
      this.buttonRemoveRandom.Text = "-";
      this.buttonRemoveRandom.UseVisualStyleBackColor = true;
      // 
      // buttonAddRandom
      // 
      this.buttonAddRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonAddRandom.Location = new System.Drawing.Point(504, 25);
      this.buttonAddRandom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonAddRandom.Name = "buttonAddRandom";
      this.buttonAddRandom.Size = new System.Drawing.Size(32, 23);
      this.buttonAddRandom.TabIndex = 5;
      this.buttonAddRandom.Text = "+";
      this.buttonAddRandom.UseVisualStyleBackColor = true;
      // 
      // textRandomInput
      // 
      this.textRandomInput.Location = new System.Drawing.Point(152, 25);
      this.textRandomInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textRandomInput.Name = "textRandomInput";
      this.textRandomInput.Size = new System.Drawing.Size(91, 22);
      this.textRandomInput.TabIndex = 4;
      this.textRandomInput.TextChanged += new System.EventHandler(this.TextRandomInput_TextChanged);
      // 
      // labelRandom
      // 
      this.labelRandom.AutoSize = true;
      this.labelRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelRandom.Location = new System.Drawing.Point(3, 25);
      this.labelRandom.Name = "labelRandom";
      this.labelRandom.Size = new System.Drawing.Size(141, 18);
      this.labelRandom.TabIndex = 3;
      this.labelRandom.Text = "Количество узлов:";
      // 
      // buttonStartRandom
      // 
      this.buttonStartRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonStartRandom.Location = new System.Drawing.Point(541, 25);
      this.buttonStartRandom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonStartRandom.Name = "buttonStartRandom";
      this.buttonStartRandom.Size = new System.Drawing.Size(75, 23);
      this.buttonStartRandom.TabIndex = 1;
      this.buttonStartRandom.Text = "Start";
      this.buttonStartRandom.UseVisualStyleBackColor = true;
      // 
      // textRandomOutput
      // 
      this.textRandomOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textRandomOutput.Location = new System.Drawing.Point(249, 25);
      this.textRandomOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textRandomOutput.Name = "textRandomOutput";
      this.textRandomOutput.Size = new System.Drawing.Size(211, 22);
      this.textRandomOutput.TabIndex = 0;
      this.textRandomOutput.TextChanged += new System.EventHandler(this.TextRandomOutput_TextChanged);
      // 
      // tabKeyboard
      // 
      this.tabKeyboard.Controls.Add(this.buttonRemoveKeyboard);
      this.tabKeyboard.Controls.Add(this.labelKeyboard);
      this.tabKeyboard.Controls.Add(this.buttonStartKeyboard);
      this.tabKeyboard.Controls.Add(this.buttonAddKeyboard);
      this.tabKeyboard.Controls.Add(this.textKeyboardInput);
      this.tabKeyboard.Location = new System.Drawing.Point(4, 25);
      this.tabKeyboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabKeyboard.Name = "tabKeyboard";
      this.tabKeyboard.Size = new System.Drawing.Size(686, 68);
      this.tabKeyboard.TabIndex = 2;
      this.tabKeyboard.Text = "Keyboard";
      this.tabKeyboard.UseVisualStyleBackColor = true;
      // 
      // buttonRemoveKeyboard
      // 
      this.buttonRemoveKeyboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonRemoveKeyboard.Location = new System.Drawing.Point(520, 25);
      this.buttonRemoveKeyboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonRemoveKeyboard.Name = "buttonRemoveKeyboard";
      this.buttonRemoveKeyboard.Size = new System.Drawing.Size(32, 23);
      this.buttonRemoveKeyboard.TabIndex = 15;
      this.buttonRemoveKeyboard.Text = "-";
      this.buttonRemoveKeyboard.UseVisualStyleBackColor = true;
      // 
      // labelKeyboard
      // 
      this.labelKeyboard.AutoSize = true;
      this.labelKeyboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelKeyboard.Location = new System.Drawing.Point(3, 25);
      this.labelKeyboard.Name = "labelKeyboard";
      this.labelKeyboard.Size = new System.Drawing.Size(123, 18);
      this.labelKeyboard.TabIndex = 8;
      this.labelKeyboard.Text = "Значения узлов:";
      // 
      // buttonStartKeyboard
      // 
      this.buttonStartKeyboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonStartKeyboard.Location = new System.Drawing.Point(594, 25);
      this.buttonStartKeyboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonStartKeyboard.Name = "buttonStartKeyboard";
      this.buttonStartKeyboard.Size = new System.Drawing.Size(75, 23);
      this.buttonStartKeyboard.TabIndex = 7;
      this.buttonStartKeyboard.Text = "Start";
      this.buttonStartKeyboard.UseVisualStyleBackColor = true;
      // 
      // buttonAddKeyboard
      // 
      this.buttonAddKeyboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonAddKeyboard.Location = new System.Drawing.Point(557, 25);
      this.buttonAddKeyboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonAddKeyboard.Name = "buttonAddKeyboard";
      this.buttonAddKeyboard.Size = new System.Drawing.Size(32, 23);
      this.buttonAddKeyboard.TabIndex = 6;
      this.buttonAddKeyboard.Text = "+";
      this.buttonAddKeyboard.UseVisualStyleBackColor = true;
      // 
      // textKeyboardInput
      // 
      this.textKeyboardInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textKeyboardInput.Location = new System.Drawing.Point(143, 25);
      this.textKeyboardInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textKeyboardInput.Name = "textKeyboardInput";
      this.textKeyboardInput.Size = new System.Drawing.Size(370, 22);
      this.textKeyboardInput.TabIndex = 0;
      this.textKeyboardInput.TextChanged += new System.EventHandler(this.TextKeyboardInput_TextChanged);
      // 
      // tabFile
      // 
      this.tabFile.Controls.Add(this.buttonRemoveFile);
      this.tabFile.Controls.Add(this.buttonOpenFile);
      this.tabFile.Controls.Add(this.buttonStartFile);
      this.tabFile.Controls.Add(this.buttonAddFile);
      this.tabFile.Controls.Add(this.textFileOutput);
      this.tabFile.Location = new System.Drawing.Point(4, 25);
      this.tabFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabFile.Name = "tabFile";
      this.tabFile.Size = new System.Drawing.Size(686, 68);
      this.tabFile.TabIndex = 3;
      this.tabFile.Text = "File";
      this.tabFile.UseVisualStyleBackColor = true;
      // 
      // buttonRemoveFile
      // 
      this.buttonRemoveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonRemoveFile.Location = new System.Drawing.Point(520, 25);
      this.buttonRemoveFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonRemoveFile.Name = "buttonRemoveFile";
      this.buttonRemoveFile.Size = new System.Drawing.Size(32, 23);
      this.buttonRemoveFile.TabIndex = 14;
      this.buttonRemoveFile.Text = "-";
      this.buttonRemoveFile.UseVisualStyleBackColor = true;
      // 
      // buttonOpenFile
      // 
      this.buttonOpenFile.Location = new System.Drawing.Point(12, 25);
      this.buttonOpenFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonOpenFile.Name = "buttonOpenFile";
      this.buttonOpenFile.Size = new System.Drawing.Size(85, 25);
      this.buttonOpenFile.TabIndex = 13;
      this.buttonOpenFile.Text = "Open file";
      this.buttonOpenFile.UseVisualStyleBackColor = true;
      this.buttonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
      // 
      // buttonStartFile
      // 
      this.buttonStartFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonStartFile.Location = new System.Drawing.Point(594, 25);
      this.buttonStartFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonStartFile.Name = "buttonStartFile";
      this.buttonStartFile.Size = new System.Drawing.Size(75, 23);
      this.buttonStartFile.TabIndex = 12;
      this.buttonStartFile.Text = "Start";
      this.buttonStartFile.UseVisualStyleBackColor = true;
      // 
      // buttonAddFile
      // 
      this.buttonAddFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonAddFile.Location = new System.Drawing.Point(557, 25);
      this.buttonAddFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonAddFile.Name = "buttonAddFile";
      this.buttonAddFile.Size = new System.Drawing.Size(32, 23);
      this.buttonAddFile.TabIndex = 11;
      this.buttonAddFile.Text = "+";
      this.buttonAddFile.UseVisualStyleBackColor = true;
      // 
      // textFileOutput
      // 
      this.textFileOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textFileOutput.Location = new System.Drawing.Point(103, 25);
      this.textFileOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textFileOutput.Name = "textFileOutput";
      this.textFileOutput.Size = new System.Drawing.Size(410, 22);
      this.textFileOutput.TabIndex = 10;
      // 
      // cleanBtn
      // 
      this.cleanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cleanBtn.Location = new System.Drawing.Point(706, 55);
      this.cleanBtn.Margin = new System.Windows.Forms.Padding(4);
      this.cleanBtn.Name = "cleanBtn";
      this.cleanBtn.Size = new System.Drawing.Size(71, 28);
      this.cleanBtn.TabIndex = 9;
      this.cleanBtn.Text = "Clean";
      this.cleanBtn.UseVisualStyleBackColor = true;
      this.cleanBtn.Click += new System.EventHandler(this.CleanBtn_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(781, 28);
      this.menuStrip1.TabIndex = 11;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveResultsToolStripMenuItem,
            this.saveInnerDataToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // saveResultsToolStripMenuItem
      // 
      this.saveResultsToolStripMenuItem.Name = "saveResultsToolStripMenuItem";
      this.saveResultsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.saveResultsToolStripMenuItem.Text = "Save results";
      // 
      // saveInnerDataToolStripMenuItem
      // 
      this.saveInnerDataToolStripMenuItem.Name = "saveInnerDataToolStripMenuItem";
      this.saveInnerDataToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.saveInnerDataToolStripMenuItem.Text = "Save inner data";
      // 
      // settingsToolStripMenuItem
      // 
      this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGreetingsToolStripMenuItem});
      this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
      this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
      this.settingsToolStripMenuItem.Text = "Settings";
      // 
      // showGreetingsToolStripMenuItem
      // 
      this.showGreetingsToolStripMenuItem.Checked = true;
      this.showGreetingsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.showGreetingsToolStripMenuItem.Name = "showGreetingsToolStripMenuItem";
      this.showGreetingsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.showGreetingsToolStripMenuItem.Text = "Show greetings";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
      this.aboutToolStripMenuItem.Text = "About";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.openToolStripMenuItem.Text = "Open";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(781, 489);
      this.Controls.Add(this.cleanBtn);
      this.Controls.Add(this.tabControl);
      this.Controls.Add(this.scrollPanel);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.MinimumSize = new System.Drawing.Size(698, 495);
      this.Name = "MainForm";
      this.Text = "Простое бинарное дерево";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.Shown += new System.EventHandler(this.ShowGreeting);
      this.scrollPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
      this.tabControl.ResumeLayout(false);
      this.tabRandom.ResumeLayout(false);
      this.tabRandom.PerformLayout();
      this.tabKeyboard.ResumeLayout(false);
      this.tabKeyboard.PerformLayout();
      this.tabFile.ResumeLayout(false);
      this.tabFile.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Panel scrollPanel;
    public System.Windows.Forms.PictureBox pictureBox;
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabRandom;
    private System.Windows.Forms.TabPage tabKeyboard;
    private System.Windows.Forms.TabPage tabFile;
    private System.Windows.Forms.Button buttonStartRandom;
    private System.Windows.Forms.TextBox textRandomOutput;
    private System.Windows.Forms.TextBox textKeyboardInput;
    private System.Windows.Forms.Label labelRandom;
    private System.Windows.Forms.Button buttonAddRandom;
    private System.Windows.Forms.TextBox textRandomInput;
    private System.Windows.Forms.Label labelKeyboard;
    private System.Windows.Forms.Button buttonStartKeyboard;
    private System.Windows.Forms.Button buttonAddKeyboard;
    private System.Windows.Forms.Button buttonOpenFile;
    private System.Windows.Forms.Button buttonStartFile;
    private System.Windows.Forms.Button buttonAddFile;
    private System.Windows.Forms.TextBox textFileOutput;
    private System.Windows.Forms.Button buttonRemoveRandom;
    private System.Windows.Forms.Button buttonRemoveKeyboard;
    private System.Windows.Forms.Button buttonRemoveFile;
    private System.Windows.Forms.Button cleanBtn;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveResultsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveInnerDataToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem showGreetingsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
  }
}

