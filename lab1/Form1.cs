﻿using lab1.Properties;
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


    }



    private void button2_Click(object sender, EventArgs e) {

    }

    bool randomSwitch = false;
    string sequenceTextLastCorrect;
    readonly BinaryTree tree = new BinaryTree();

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










    List<Label> drawList = new List<Label>();
    Dictionary<TextBox, List<Label>> lineList = new Dictionary<TextBox, List<Label>>();

    

    public void Print(BinaryTree node, PictureBox pictureBox, Point a = new Point()) {
      if (node.Data != null) {
        if (node.Parent == null) {

          Console.WriteLine("ROOT:"+ node.Data);

          nodeForDraw nodeDraw = new nodeForDraw(node.Data.ToString(), new Point(pictureBox.Width / 2, 0), Color.Green);
          
          drawList.Add(nodeDraw);
          pictureBox.Controls.Add(nodeDraw);
          nodeDraw.BringToFront();

        }
        else {

          Point p = Point.Empty;                  //find parent location
          for (int i = 0; i < drawList.Count; i++) {
            if (drawList[i].Text == node.Parent.Data.ToString()) {
              p = drawList[i].Location;
              break;
            }
          }

          if (node.Parent.Left == node) {
            Console.WriteLine("Left for " + node.Parent.Data + "  --> " + node.Data);

            nodeForDraw nodeDraw = new nodeForDraw(node.Data.ToString(), new Point(p.X - 45, p.Y + 40), Color.Red);
            
            if (nodeDraw.Location.X - nodeDraw.Width<0 || nodeDraw.Location.Y - nodeDraw.Height < 0) {
              Point NB = new Point(drawList[0].Location.X + nodeDraw.Location.X + nodeDraw.Width, drawList[0].Location.Y + nodeDraw.Location.Y + nodeDraw.Height);
              //pictureBox.Width = nodeDraw.Location.X + nodeDraw.Width;
              clearPictureBox();
              Print(tree, pictureBox, NB);
              return;
            }
            drawList.Add(nodeDraw);
            pictureBox.Controls.Add(nodeDraw);
            nodeDraw.BringToFront();
          }

          if (node.Parent.Right == node) {
            Console.WriteLine("Right for " + node.Parent.Data + " --> "+ node.Data);

            nodeForDraw nodeDraw = new nodeForDraw(node.Data.ToString(), new Point(p.X + 45, p.Y + 40), Color.Black);
            drawList.Add(nodeDraw);

            if ((nodeDraw.Location.X+ nodeDraw.Width)>pictureBox.Width) {
              pictureBox.Width = nodeDraw.Location.X + nodeDraw.Width;
            }
            if ((nodeDraw.Location.Y + nodeDraw.Height) > pictureBox.Height) {
              pictureBox.Height = nodeDraw.Location.Y + nodeDraw.Height;
            }

           

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
        //this.AutoSize = true;
        this.Location = loc;
        this.Size = new Size(30, 36);
        //label.TabIndex = vertex.Count(); ????????????
        this.BackColor = color;
        this.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
        this.ForeColor = System.Drawing.Color.White;
        this.Text = text;
        
      }
    }

    /*private void pictureBox_Paint(object sender, PaintEventArgs e) {
      Console.WriteLine("Paint!" ); //ЗА ПРЕДЕЛЫ??? видимо отрисовка за пределами
    }

    private void pictureBox_SystemColorsChanged(object sender, EventArgs e) {
      Console.WriteLine("Paint! 2");
    }

    private void pictureBox_Resize(object sender, EventArgs e) {
      Console.WriteLine("Paint! 3"); //при изменении размера окна
    }*/

    private void pictureBox_ControlAdded(object sender, ControlEventArgs e) {
      //Console.WriteLine("Paint! 4");//при добавлении любого элемента

    
    }

    /*private void scrollPanel_AutoSizeChanged(object sender, EventArgs e) {
      Console.WriteLine("scroll!");
    }

    private void scrollPanel_BindingContextChanged(object sender, EventArgs e) {
      Console.WriteLine("scroll! 2");
    }

    private void scrollPanel_Scroll(object sender, ScrollEventArgs e) {
      Console.WriteLine("scroll!3");
    }*/
  }
}
