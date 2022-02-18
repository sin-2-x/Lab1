
namespace Lab1 {
  partial class AddRemoveForm {

    private System.ComponentModel.IContainer components = null;

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
            this.addLabel = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textAddNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addLabel
            // 
            this.addLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addLabel.AutoSize = true;
            this.addLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addLabel.Location = new System.Drawing.Point(52, 35);
            this.addLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(165, 25);
            this.addLabel.TabIndex = 0;
            this.addLabel.Text = "Enter a number:";
            this.addLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(173, 97);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(56, 30);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Ок";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textAddNumber
            // 
            this.textAddNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAddNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAddNumber.Location = new System.Drawing.Point(39, 97);
            this.textAddNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textAddNumber.Name = "textAddNumber";
            this.textAddNumber.Size = new System.Drawing.Size(130, 30);
            this.textAddNumber.TabIndex = 2;
            this.textAddNumber.TextChanged += new System.EventHandler(this.textAddNumber_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 156);
            this.Controls.Add(this.textAddNumber);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.addLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Редактирование дерева";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label addLabel;
    public System.Windows.Forms.Button buttonAdd;
    public System.Windows.Forms.TextBox textAddNumber;
  }
}