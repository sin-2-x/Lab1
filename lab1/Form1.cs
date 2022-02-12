using lab1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      Button randomBtn = (Button)this.Controls.Find("randomBtn", false)[0];
      randomBtn.BackColor = Color.FromArgb(252, 81, 133);
      //scrollPanel.Width(Parent.Width);



      //this.pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
      
      //this.scrollPanel.AutoScroll = true;

      //the border is just for checking that size and picturebox location

      //this.scrollPanel.BorderStyle = BorderStyle.FixedSingle;
    }



    private void button2_Click(object sender, EventArgs e) {

    }

    bool randomSwitch = false;
    string sequenceTextLastCorrect;


    private void sequenceTextBoxChanged(object sender, EventArgs e) {
      //TextBox objTextBox = (TextBox)sender;
      string sequenceTextNewValue = sequenceTextBox.Text;


      if (randomSwitch) {
        for (int i = 0; i < sequenceTextNewValue.Length; i++) {
          if ((sequenceTextNewValue.ElementAt(i) < '0' || sequenceTextNewValue.ElementAt(i) > '9')) /*&& sequenceTextNewValue.ElementAt(i) != '-')*/
          {//набор алфавита
            sequenceTextBox.Text = sequenceTextLastCorrect;
            return;
          }
        }
        sequenceTextBox.Text = sequenceTextNewValue;
        sequenceTextLastCorrect = sequenceTextNewValue;
        return;
      }
      else {
        for (int i = 0; i < sequenceTextNewValue.Length; i++) {
          if (sequenceTextNewValue.Length > 0 && (sequenceTextNewValue.ElementAt(i) < '0' || sequenceTextNewValue.ElementAt(i) > '9') && sequenceTextNewValue.ElementAt(i) != ' ') /*&& sequenceTextNewValue.ElementAt(i) != '-')*/
          {//набор алфавита
            sequenceTextBox.Text = sequenceTextLastCorrect;
            return;
          }
        }

        while (sequenceTextNewValue.Contains("  "))
          sequenceTextNewValue = sequenceTextNewValue.Replace("  ", " ");
        /*while (sequenceTextNewValue.Contains("- "))
            sequenceTextNewValue = sequenceTextNewValue.Replace("- ", "-");
        while (sequenceTextNewValue.Contains("--"))
            sequenceTextNewValue = sequenceTextNewValue.Replace("--", "-");
        while (sequenceTextNewValue.Contains("-0"))
            sequenceTextNewValue = sequenceTextNewValue.Replace("-0", "0");*/


        sequenceTextBox.Text = sequenceTextNewValue;
        sequenceTextLastCorrect = sequenceTextNewValue;
        return;
        /*if (sequenceTextNewValue.ElementAt(i) == '-' && sequenceTextNewValue.ElementAt(i - 1) != ' '){
            sequenceTextNewValue = (new StringBuilder(sequenceTextNewValue)).insert(i, " ").toString();
        objTextBox.Text = sequenceTextNewValue;
        }*/
        //return;
      }

    }

    private void startBtn_Click(object sender, EventArgs e) {

      clearPictureBox();




      string sequenceTextStart = sequenceTextBox.Text;

      Input InputWay = null;
      if (randomSwitch) 
        InputWay = new RandomInput();      
      else 
        InputWay = new KeyboardInput();
      

      int[] arr = InputWay.input(sequenceTextStart); //нужный массив
      var tree = new BinaryTree();

      for (int i=0; i<arr.Length;i++)
        tree.Insert(arr[i]);


      Print(tree, pictureBox);
      

    }


    private void clearPictureBox() {
          pictureBox.Controls.Clear();
          drawList.Clear();
    }




    private void randomBtn_Click(object sender, EventArgs e) {
      Button randomBtn = (Button)sender;
      if (randomSwitch)
        randomBtn.BackColor = Color.FromArgb(252, 81, 133);
      else
        randomBtn.BackColor = Color.FromArgb(48, 227, 202);
      randomSwitch = !randomSwitch;
      sequenceTextLastCorrect = "";
    }

    private void scrollPanel_SizeChanged(object sender, EventArgs e) {
      if (this.pictureBox.Image != null) {
        Size picSize = this.pictureBox.Image.Size;
        Size panSize = this.scrollPanel.Size;
        if (picSize.Height < panSize.Height) {
          this.pictureBox.Location = new Point(this.pictureBox.Location.X, (panSize.Height - picSize.Height) / 2);
        }
        else {
          this.pictureBox.Location = new Point(this.pictureBox.Location.X, 0);
        }
        if (picSize.Width < panSize.Width) {
          this.pictureBox.Location = new Point((panSize.Width - picSize.Width) / 2, this.pictureBox.Location.Y);
        }
        else {
          this.pictureBox.Location = new Point(0, this.pictureBox.Location.Y);
        }
      }
    }




























    List<Label> drawList = new List<Label>();
    Dictionary<TextBox, List<Label>> lineList = new Dictionary<TextBox, List<Label>>();



    public void Print(BinaryTree node, PictureBox pictureBox) {

      

      if (node.Data != null) {
        if (node.Parent == null) {

          Console.WriteLine("ROOT:"+ node.Data);

          /*Label text_for_user = new Label();
          text_for_user.ForeColor = System.Drawing.Color.White;
          text_for_user.Top = 100;
          text_for_user.Left = -30;
          text_for_user.AutoSize = false;
          text_for_user.Text = "HEY, USER!!!";
          //text_for_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          text_for_user.Size = new System.Drawing.Size(50, 50);
          text_for_user.Font = new System.Drawing.Font("Arial", text_for_user.Font.Size);
          //text_for_user.Dock = System.Windows.Forms.DockStyle.Fill;



          //text_for_user.cor();
          //pictureBox.Controls.Add(text_for_user);*/

          nodeForDraw nodeDraw = new nodeForDraw(node.Data.ToString(), new Point(pictureBox.Width / 2, 0), Color.Green);


          //GraphicsPath path = new GraphicsPath();
          //path.AddEllipse(label.ClientRectangle);
          //path.AddRectangle(label.ClientRectangle);
          //label.Region = new Region(path);
          
          drawList.Add(nodeDraw);
          //pictureBox.AutoScrollOffset
          pictureBox.Controls.Add(nodeDraw);
          nodeDraw.BringToFront();

        }
        else {

          Point p = new Point(0, 0);                  //find parent location
          for (int i = 0; i < drawList.Count; i++) {
            if (drawList[i].Text == node.Parent.Data.ToString()) {
              p = drawList[i].Location;
              break;
            }
          }

          if (node.Parent.Left == node) {
            Console.WriteLine("Left for " + node.Parent.Data + "  --> " + node.Data);

            nodeForDraw nodeDraw = new nodeForDraw(node.Data.ToString(), new Point(p.X - 45, p.Y + 40), Color.Red);
            drawList.Add(nodeDraw);

            pictureBox.Controls.Add(nodeDraw);
            nodeDraw.BringToFront();
          }

          if (node.Parent.Right == node) {
            Console.WriteLine("Right for " + node.Parent.Data + " --> "+ node.Data);

            nodeForDraw nodeDraw = new nodeForDraw(node.Data.ToString(), new Point(p.X + 45, p.Y + 40), Color.Black);
            drawList.Add(nodeDraw);

            pictureBox.Controls.Add(nodeDraw);
            nodeDraw.BringToFront();

          }
        }
        if (node.Left != null) {
          Print(node.Left, pictureBox);
        }
        if (node.Right != null) {
          Print(node.Right, pictureBox);
        }
      }
    }







    class nodeForDraw : Label {
      public nodeForDraw(string text,Point loc, Color color) {
        this.AutoSize = true;
        this.Location = loc;
        //this.Size = new Size(30, 36);
        //label.TabIndex = vertex.Count(); ????????????
        this.BackColor = color;
        this.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
        this.ForeColor = System.Drawing.Color.White;
        this.Text = text;
        
      }
    }


  }
}
