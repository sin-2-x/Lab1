
namespace lab1
{
    partial class Form1
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
      this.sequenceTextBox = new System.Windows.Forms.TextBox();
      this.randomBtn = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.startBtn = new System.Windows.Forms.Button();
      this.scrollPanel = new System.Windows.Forms.Panel();
      this.pictureBox = new System.Windows.Forms.PictureBox();
      this.scrollPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // sequenceTextBox
      // 
      this.sequenceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.sequenceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.sequenceTextBox.Location = new System.Drawing.Point(186, 21);
      this.sequenceTextBox.Margin = new System.Windows.Forms.Padding(999);
      this.sequenceTextBox.MinimumSize = new System.Drawing.Size(100, 4);
      this.sequenceTextBox.Multiline = true;
      this.sequenceTextBox.Name = "sequenceTextBox";
      this.sequenceTextBox.Size = new System.Drawing.Size(409, 58);
      this.sequenceTextBox.TabIndex = 1;
      this.sequenceTextBox.TextChanged += new System.EventHandler(this.sequenceTextBoxChanged);
      // 
      // randomBtn
      // 
      this.randomBtn.AutoSize = true;
      this.randomBtn.Location = new System.Drawing.Point(88, 19);
      this.randomBtn.MinimumSize = new System.Drawing.Size(80, 0);
      this.randomBtn.Name = "randomBtn";
      this.randomBtn.Size = new System.Drawing.Size(80, 27);
      this.randomBtn.TabIndex = 4;
      this.randomBtn.Text = "Random";
      this.randomBtn.UseVisualStyleBackColor = true;
      this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
      // 
      // button2
      // 
      this.button2.AutoSize = true;
      this.button2.Location = new System.Drawing.Point(88, 52);
      this.button2.MinimumSize = new System.Drawing.Size(80, 0);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(80, 27);
      this.button2.TabIndex = 5;
      this.button2.Text = "Open file";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // startBtn
      // 
      this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.startBtn.Location = new System.Drawing.Point(606, 21);
      this.startBtn.Name = "startBtn";
      this.startBtn.Size = new System.Drawing.Size(75, 58);
      this.startBtn.TabIndex = 6;
      this.startBtn.Text = "Start";
      this.startBtn.UseVisualStyleBackColor = true;
      this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
      // 
      // scrollPanel
      // 
      this.scrollPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.scrollPanel.AutoScroll = true;
      this.scrollPanel.BackColor = System.Drawing.SystemColors.Highlight;
      this.scrollPanel.Controls.Add(this.pictureBox);
      this.scrollPanel.Location = new System.Drawing.Point(0, 100);
      this.scrollPanel.Name = "scrollPanel";
      this.scrollPanel.Size = new System.Drawing.Size(782, 354);
      this.scrollPanel.TabIndex = 7;
      // 
      // pictureBox
      // 
      this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pictureBox.Location = new System.Drawing.Point(0, 0);
      this.pictureBox.Name = "pictureBox";
      this.pictureBox.Size = new System.Drawing.Size(782, 354);
      this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox.TabIndex = 0;
      this.pictureBox.TabStop = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(782, 453);
      this.Controls.Add(this.scrollPanel);
      this.Controls.Add(this.startBtn);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.randomBtn);
      this.Controls.Add(this.sequenceTextBox);
      this.MinimumSize = new System.Drawing.Size(500, 500);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.scrollPanel.ResumeLayout(false);
      this.scrollPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sequenceTextBox;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button startBtn;
    private System.Windows.Forms.Panel scrollPanel;
    private System.Windows.Forms.PictureBox pictureBox;
  }
}

