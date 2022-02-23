using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1 {
  public partial class MessageForm : Form {
    public MessageForm(int left, int top, string message) {
      InitializeComponent();

      this.StartPosition = FormStartPosition.Manual;
      
      
      this.textMessage.Text = message;
      Point magin = textMessage.Location;

      this.Size = new Size(magin.X*2+textMessage.Width, magin.Y * 3 + textMessage.Height);
      this.MaximumSize = this.Size;
      this.MinimumSize = this.Size;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Location = new Point(left - Width / 2, top - Height / 2);
    }

    private void MessageForm_Load(object sender, EventArgs e) {

    }
  }
}
