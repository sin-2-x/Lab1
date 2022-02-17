
namespace lab1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.scrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabRandom.SuspendLayout();
            this.tabKeyboard.SuspendLayout();
            this.tabFile.SuspendLayout();
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
            this.scrollPanel.Location = new System.Drawing.Point(0, 84);
            this.scrollPanel.Margin = new System.Windows.Forms.Padding(0);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(586, 314);
            this.scrollPanel.TabIndex = 7;
            this.scrollPanel.SizeChanged += new System.EventHandler(this.scrollPanel_SizeChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(586, 314);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabRandom);
            this.tabControl.Controls.Add(this.tabKeyboard);
            this.tabControl.Controls.Add(this.tabFile);
            this.tabControl.Location = new System.Drawing.Point(48, 1);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(493, 81);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabRandom
            // 
            this.tabRandom.Controls.Add(this.buttonRemoveRandom);
            this.tabRandom.Controls.Add(this.buttonAddRandom);
            this.tabRandom.Controls.Add(this.textRandomInput);
            this.tabRandom.Controls.Add(this.labelRandom);
            this.tabRandom.Controls.Add(this.buttonStartRandom);
            this.tabRandom.Controls.Add(this.textRandomOutput);
            this.tabRandom.Location = new System.Drawing.Point(4, 22);
            this.tabRandom.Margin = new System.Windows.Forms.Padding(2);
            this.tabRandom.Name = "tabRandom";
            this.tabRandom.Padding = new System.Windows.Forms.Padding(2);
            this.tabRandom.Size = new System.Drawing.Size(485, 55);
            this.tabRandom.TabIndex = 1;
            this.tabRandom.Text = "Random";
            this.tabRandom.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveRandom
            // 
            this.buttonRemoveRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveRandom.Location = new System.Drawing.Point(356, 20);
            this.buttonRemoveRandom.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoveRandom.Name = "buttonRemoveRandom";
            this.buttonRemoveRandom.Size = new System.Drawing.Size(24, 19);
            this.buttonRemoveRandom.TabIndex = 15;
            this.buttonRemoveRandom.Text = "-";
            this.buttonRemoveRandom.UseVisualStyleBackColor = true;
            // 
            // buttonAddRandom
            // 
            this.buttonAddRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddRandom.Location = new System.Drawing.Point(384, 20);
            this.buttonAddRandom.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddRandom.Name = "buttonAddRandom";
            this.buttonAddRandom.Size = new System.Drawing.Size(24, 19);
            this.buttonAddRandom.TabIndex = 5;
            this.buttonAddRandom.Text = "+";
            this.buttonAddRandom.UseVisualStyleBackColor = true;
            // 
            // textRandomInput
            // 
            this.textRandomInput.Location = new System.Drawing.Point(114, 20);
            this.textRandomInput.Margin = new System.Windows.Forms.Padding(2);
            this.textRandomInput.Name = "textRandomInput";
            this.textRandomInput.Size = new System.Drawing.Size(69, 20);
            this.textRandomInput.TabIndex = 4;
            this.textRandomInput.TextChanged += new System.EventHandler(this.textRandomInput_TextChanged);
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRandom.Location = new System.Drawing.Point(2, 20);
            this.labelRandom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(114, 15);
            this.labelRandom.TabIndex = 3;
            this.labelRandom.Text = "Количество узлов:";
            // 
            // buttonStartRandom
            // 
            this.buttonStartRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartRandom.Location = new System.Drawing.Point(412, 20);
            this.buttonStartRandom.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStartRandom.Name = "buttonStartRandom";
            this.buttonStartRandom.Size = new System.Drawing.Size(56, 19);
            this.buttonStartRandom.TabIndex = 1;
            this.buttonStartRandom.Text = "Start";
            this.buttonStartRandom.UseVisualStyleBackColor = true;
            // 
            // textRandomOutput
            // 
            this.textRandomOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textRandomOutput.Location = new System.Drawing.Point(187, 20);
            this.textRandomOutput.Margin = new System.Windows.Forms.Padding(2);
            this.textRandomOutput.Name = "textRandomOutput";
            this.textRandomOutput.Size = new System.Drawing.Size(165, 20);
            this.textRandomOutput.TabIndex = 0;
            // 
            // tabKeyboard
            // 
            this.tabKeyboard.Controls.Add(this.buttonRemoveKeyboard);
            this.tabKeyboard.Controls.Add(this.labelKeyboard);
            this.tabKeyboard.Controls.Add(this.buttonStartKeyboard);
            this.tabKeyboard.Controls.Add(this.buttonAddKeyboard);
            this.tabKeyboard.Controls.Add(this.textKeyboardInput);
            this.tabKeyboard.Location = new System.Drawing.Point(4, 22);
            this.tabKeyboard.Margin = new System.Windows.Forms.Padding(2);
            this.tabKeyboard.Name = "tabKeyboard";
            this.tabKeyboard.Size = new System.Drawing.Size(485, 55);
            this.tabKeyboard.TabIndex = 2;
            this.tabKeyboard.Text = "Keyboard";
            this.tabKeyboard.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveKeyboard
            // 
            this.buttonRemoveKeyboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveKeyboard.Location = new System.Drawing.Point(356, 20);
            this.buttonRemoveKeyboard.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoveKeyboard.Name = "buttonRemoveKeyboard";
            this.buttonRemoveKeyboard.Size = new System.Drawing.Size(24, 19);
            this.buttonRemoveKeyboard.TabIndex = 15;
            this.buttonRemoveKeyboard.Text = "-";
            this.buttonRemoveKeyboard.UseVisualStyleBackColor = true;
            // 
            // labelKeyboard
            // 
            this.labelKeyboard.AutoSize = true;
            this.labelKeyboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKeyboard.Location = new System.Drawing.Point(2, 20);
            this.labelKeyboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKeyboard.Name = "labelKeyboard";
            this.labelKeyboard.Size = new System.Drawing.Size(101, 15);
            this.labelKeyboard.TabIndex = 8;
            this.labelKeyboard.Text = "Значения узлов:";
            // 
            // buttonStartKeyboard
            // 
            this.buttonStartKeyboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartKeyboard.Location = new System.Drawing.Point(412, 20);
            this.buttonStartKeyboard.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStartKeyboard.Name = "buttonStartKeyboard";
            this.buttonStartKeyboard.Size = new System.Drawing.Size(56, 19);
            this.buttonStartKeyboard.TabIndex = 7;
            this.buttonStartKeyboard.Text = "Start";
            this.buttonStartKeyboard.UseVisualStyleBackColor = true;
            // 
            // buttonAddKeyboard
            // 
            this.buttonAddKeyboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddKeyboard.Location = new System.Drawing.Point(384, 20);
            this.buttonAddKeyboard.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddKeyboard.Name = "buttonAddKeyboard";
            this.buttonAddKeyboard.Size = new System.Drawing.Size(24, 19);
            this.buttonAddKeyboard.TabIndex = 6;
            this.buttonAddKeyboard.Text = "+";
            this.buttonAddKeyboard.UseVisualStyleBackColor = true;
            // 
            // textKeyboardInput
            // 
            this.textKeyboardInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textKeyboardInput.Location = new System.Drawing.Point(107, 20);
            this.textKeyboardInput.Margin = new System.Windows.Forms.Padding(2);
            this.textKeyboardInput.Name = "textKeyboardInput";
            this.textKeyboardInput.Size = new System.Drawing.Size(245, 20);
            this.textKeyboardInput.TabIndex = 0;
            this.textKeyboardInput.TextChanged += new System.EventHandler(this.textKeyboardInput_TextChanged);
            // 
            // tabFile
            // 
            this.tabFile.Controls.Add(this.buttonRemoveFile);
            this.tabFile.Controls.Add(this.buttonOpenFile);
            this.tabFile.Controls.Add(this.buttonStartFile);
            this.tabFile.Controls.Add(this.buttonAddFile);
            this.tabFile.Controls.Add(this.textFileOutput);
            this.tabFile.Location = new System.Drawing.Point(4, 22);
            this.tabFile.Margin = new System.Windows.Forms.Padding(2);
            this.tabFile.Name = "tabFile";
            this.tabFile.Size = new System.Drawing.Size(485, 55);
            this.tabFile.TabIndex = 3;
            this.tabFile.Text = "File";
            this.tabFile.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveFile
            // 
            this.buttonRemoveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveFile.Location = new System.Drawing.Point(356, 20);
            this.buttonRemoveFile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoveFile.Name = "buttonRemoveFile";
            this.buttonRemoveFile.Size = new System.Drawing.Size(24, 19);
            this.buttonRemoveFile.TabIndex = 14;
            this.buttonRemoveFile.Text = "-";
            this.buttonRemoveFile.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(9, 20);
            this.buttonOpenFile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(64, 20);
            this.buttonOpenFile.TabIndex = 13;
            this.buttonOpenFile.Text = "Open file";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonStartFile
            // 
            this.buttonStartFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartFile.Location = new System.Drawing.Point(412, 20);
            this.buttonStartFile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStartFile.Name = "buttonStartFile";
            this.buttonStartFile.Size = new System.Drawing.Size(56, 19);
            this.buttonStartFile.TabIndex = 12;
            this.buttonStartFile.Text = "Start";
            this.buttonStartFile.UseVisualStyleBackColor = true;
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddFile.Location = new System.Drawing.Point(384, 20);
            this.buttonAddFile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(24, 19);
            this.buttonAddFile.TabIndex = 11;
            this.buttonAddFile.Text = "+";
            this.buttonAddFile.UseVisualStyleBackColor = true;
            // 
            // textFileOutput
            // 
            this.textFileOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFileOutput.Location = new System.Drawing.Point(77, 20);
            this.textFileOutput.Margin = new System.Windows.Forms.Padding(2);
            this.textFileOutput.Name = "textFileOutput";
            this.textFileOutput.Size = new System.Drawing.Size(275, 20);
            this.textFileOutput.TabIndex = 10;
            this.textFileOutput.TextChanged += new System.EventHandler(this.textFileOutput_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(4, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(43, 23);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // cleanBtn
            // 
            this.cleanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cleanBtn.Location = new System.Drawing.Point(540, 12);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(44, 23);
            this.cleanBtn.TabIndex = 9;
            this.cleanBtn.Text = "Clean";
            this.cleanBtn.UseVisualStyleBackColor = true;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 397);
            this.Controls.Add(this.cleanBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.scrollPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(528, 413);
            this.Name = "Form1";
            this.Text = "Простое бинарное дерево";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.scrollPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabRandom.ResumeLayout(false);
            this.tabRandom.PerformLayout();
            this.tabKeyboard.ResumeLayout(false);
            this.tabKeyboard.PerformLayout();
            this.tabFile.ResumeLayout(false);
            this.tabFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    private System.Windows.Forms.Panel scrollPanel;
    private System.Windows.Forms.PictureBox pictureBox;
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
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cleanBtn;
    }
}

