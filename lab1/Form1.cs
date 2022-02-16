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
  public enum Tabindex {
    Random = 1,
    Keyboard,
    File
  }
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      
      //randomBtn.BackColor = Color.FromArgb(252, 81, 133);

      // Sizes the tabs of tabControl1.
      buttonStartRandom.Click += new EventHandler(this.startBtn_Click);
      buttonStartKeyboard.Click += new EventHandler(this.startBtn_Click);
      buttonStartFile.Click += new EventHandler(this.startBtn_Click);

      /*buttonRemoveFile.Click += new EventHandler();
      buttonRemoveKeyboard.Click += new EventHandler();
      buttonRemoveRandom.Click += new EventHandler();*/

      textRandomOutput.Enabled = false;
      textRandomOutput.ReadOnly = true;
      textFileOutput.Enabled = false;
      textFileOutput.ReadOnly = true;

      // Makes the tab width definable. 
      this.tabControl.SizeMode = TabSizeMode.Fixed;


      buttonAddFile.Click += new EventHandler(this.buttonAdd_Click);
       buttonAddKeyboard.Click += new EventHandler(this.buttonAdd_Click);
       buttonAddRandom.Click += new EventHandler(this.buttonAdd_Click);




    }





    BinaryTree tree = null;


    private void Button2_Click(object sender, EventArgs e) {

    }
    /* private void sequenceTextBoxChanged(object sender, EventArgs e) {
       string sequenceTextNewValue = sequenceTextBox.Text;


       if (randomSwitch) {
         for (int i = 0; i < sequenceTextNewValue.Length; i++) {
           if ((sequenceTextNewValue.ElementAt(i) < '0' || sequenceTextNewValue.ElementAt(i) > '9')) *//*&& sequenceTextNewValue.ElementAt(i) != '-')*//*
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
           if (sequenceTextNewValue.Length > 0 && (sequenceTextNewValue.ElementAt(i) < '0' || sequenceTextNewValue.ElementAt(i) > '9') && sequenceTextNewValue.ElementAt(i) != ' ') *//*&& sequenceTextNewValue.ElementAt(i) != '-')*//*
           {//набор алфавита
             sequenceTextBox.Text = sequenceTextLastCorrect;
             return;
           }
         }

         while (sequenceTextNewValue.Contains("  "))
           sequenceTextNewValue = sequenceTextNewValue.Replace("  ", " ");
         *//*while (sequenceTextNewValue.Contains("- "))
             sequenceTextNewValue = sequenceTextNewValue.Replace("- ", "-");
         while (sequenceTextNewValue.Contains("--"))
             sequenceTextNewValue = sequenceTextNewValue.Replace("--", "-");
         while (sequenceTextNewValue.Contains("-0"))
             sequenceTextNewValue = sequenceTextNewValue.Replace("-0", "0");*//*


         sequenceTextBox.Text = sequenceTextNewValue;
         sequenceTextLastCorrect = sequenceTextNewValue;
         return;
         *//*if (sequenceTextNewValue.ElementAt(i) == '-' && sequenceTextNewValue.ElementAt(i - 1) != ' '){
             sequenceTextNewValue = (new StringBuilder(sequenceTextNewValue)).insert(i, " ").toString();
         objTextBox.Text = sequenceTextNewValue;
         }*//*
         //return;
       }

     }*/


    private void plantTree() {
      string sequenceTextForStart = "";
      Input InputWay = null;
      switch (tabControl.SelectedTab.TabIndex) {
        case (int)Tabindex.Random:
          InputWay = new RandomInput();
          sequenceTextForStart = textRandomInput.Text;

          break;
        case (int)Tabindex.Keyboard:
          InputWay = new KeyboardInput();
          sequenceTextForStart = textKeyboardInput.Text;
          break;
        case (int)Tabindex.File:
          InputWay = new FileInput();
          sequenceTextForStart = textFileOutput.Text;
          break;
      }
      if (sequenceTextForStart.Length > 0) {
        int[] arr = InputWay.input(sequenceTextForStart); //нужный массив

        tree = new BinaryTree();
        for (int i = 0; i < arr.Length; i++) {
          tree.Insert(arr[i]);
          //Console.WriteLine(" " + arr[i] + " ");
        }

        if (tabControl.SelectedTab.TabIndex == (int)Tabindex.Random) {
          textRandomOutput.Text = "";
          textRandomOutput.Enabled = true;
          for (int i = 0; i < arr.Length; i++) {

            textRandomOutput.Text += arr[i] + " ";

          }

        }

        else if (tabControl.SelectedTab.TabIndex == (int)Tabindex.Keyboard) {

          textKeyboardInput.ReadOnly = true;

        }

        pictureBox.Size = new Size(scrollPanel.Width, scrollPanel.Height); //set min size and hide scrolls
        clearPictureBox();
        Print(tree, pictureBox);

        //scrollPanel.Size = new Size(pictureBox.Width, pictureBox.Height);
        //LineForDraw.drawLine(pictureBox);
        pictureBox.Update();
        drawLine();
      }
    }
    private void startBtn_Click(object sender, EventArgs e) {
      plantTree();
    }
    private void clearPictureBox() {
      pictureBox.Controls.Clear();

      NodeForDraw.drawList.Clear();
      LineForDraw.lineList.Clear();
      Graphics gr = pictureBox.CreateGraphics();
      gr.Clear(pictureBox.BackColor);
      //pictureBox.Update();
    }


    public void Print(BinaryTree node, PictureBox pictureBox, Color color = default, Point a = new Point()) {
      if (node.Data != null) {
        if (node.Parent == null) {  //Все для прорисовки корня
          Console.WriteLine("ROOT:" + node.Data);

          if (a.IsEmpty)
            a = new Point(pictureBox.Width / 2, 0);

          NodeForDraw nodeDraw = new NodeForDraw(node.Data.ToString(), a, Color.Green);

          NodeForDraw.drawList.Add(nodeDraw);
          pictureBox.Controls.Add(nodeDraw);
          nodeDraw.BringToFront();
        }
        else {    //Все для прорисовки узлов

          Point parentLocation = Point.Empty;                  //find parent location
          for (int i = 0; i < NodeForDraw.drawList.Count; i++) {
            if (NodeForDraw.drawList[i].Text == node.Parent.Data.ToString()) {
              parentLocation = NodeForDraw.drawList[i].Location;
              break;
            }
          }

          if (node.Parent.Left == node) { //Прорисовка левого узла
            Console.WriteLine("Left for " + node.Parent.Data + "  --> " + node.Data);
            NodeForDraw nodeDraw;
            if (node.Parent.Parent == null)
              nodeDraw = new NodeForDraw(node.Data.ToString(), new Point(parentLocation.X - 140, parentLocation.Y + 80), color);
            else
              nodeDraw = new NodeForDraw(node.Data.ToString(), new Point(parentLocation.X - 90, parentLocation.Y + 80), color);

            if (nodeDraw.Location.X - nodeDraw.Width < 0) {
              Point NB = new Point(NodeForDraw.drawList[0].Location.X + nodeDraw.Location.X + nodeDraw.Width, 0);
              clearPictureBox();
              Print(tree, pictureBox, color, NB);
              return;
            }

            if ((nodeDraw.Location.Y + nodeDraw.Height) > pictureBox.Height) {
              pictureBox.Height = nodeDraw.Location.Y + nodeDraw.Height * 2;
            }


            NodeForDraw.drawList.Add(nodeDraw);
            pictureBox.Controls.Add(nodeDraw);
            nodeDraw.BringToFront();
          }

          if (node.Parent.Right == node) { //Прорисовка правого узла
            Console.WriteLine("Right for " + node.Parent.Data + " --> " + node.Data);

            NodeForDraw nodeDraw = new NodeForDraw(node.Data.ToString(), new Point(parentLocation.X + 90, parentLocation.Y + 80), color);
            NodeForDraw.drawList.Add(nodeDraw);

            if ((nodeDraw.Location.X + nodeDraw.Width) > pictureBox.Width) {
              pictureBox.Width = nodeDraw.Location.X + nodeDraw.Width;
            }
            if ((nodeDraw.Location.Y + nodeDraw.Height) > pictureBox.Height) {
              pictureBox.Height = nodeDraw.Location.Y + nodeDraw.Height * 2;
            }



            pictureBox.Controls.Add(nodeDraw);
            nodeDraw.BringToFront();

          }



          //Добавление линий для рисования
          new LineForDraw(new Point(parentLocation.X + NodeForDraw.drawList.LastOrDefault().Width / 2, parentLocation.Y + NodeForDraw.drawList.LastOrDefault().Height / 2),
                   new Point(NodeForDraw.drawList.LastOrDefault().Location.X + NodeForDraw.drawList.LastOrDefault().Width / 2, NodeForDraw.drawList.LastOrDefault().Location.Y + NodeForDraw.drawList.LastOrDefault().Height / 2),
                   color);

          //_l.Add(temp);
          //drawLine();
          //LineForDraw.drawLine(pictureBox);



        }
        if (node.Left != null && node.Parent == null) {
          color = Color.Red;
          Print(node.Left, pictureBox, color);
        }
        else if (node.Left != null) {
          Print(node.Left, pictureBox, color);
        }


        if (node.Right != null && node.Parent == null) {
          color = Color.Black;
          Print(node.Right, pictureBox, color);
        }
        else if (node.Right != null) {
          Print(node.Right, pictureBox, color);
        }
      }
      //LineForDraw.drawLine(pictureBox);
      drawLine();
    }

    public void drawLine() {
      //var pictureBox = Form1.con.Controls.Find("pictureBox", true);
      Graphics gr = pictureBox.CreateGraphics();
      for (int i = 0; i < LineForDraw.lineList.Count; i++) {
        gr.DrawLine(new Pen(LineForDraw.lineList[i].lineColor, 2), LineForDraw.lineList[i].ParentLocation, LineForDraw.lineList[i].ChaildLocation);
      }
      for (int i = 0; i < LineForDraw.lineList.Count; i++) {
        gr.DrawLine(new Pen(LineForDraw.lineList[i].lineColor, 2), LineForDraw.lineList[i].ParentLocation, LineForDraw.lineList[i].ChaildLocation);
      }
    }
    class NodeForDraw : Label {
      public static List<Label> drawList = new List<Label>();
      public NodeForDraw(string text, Point loc, Color color) {
        AutoSize = true;
        Location = loc;
        BackColor = color;
        Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
        ForeColor = Color.White;
        Text = text;

      }
    }
    class LineForDraw {
      public Point ParentLocation;
      public Point ChaildLocation;
      public Color lineColor;
      public static List<LineForDraw> lineList = new List<LineForDraw>();
      public LineForDraw(Point ParentLocation, Point ChaildLocation, Color lineColor) {


        this.ParentLocation = ParentLocation;
        this.ChaildLocation = ChaildLocation;
        this.lineColor = lineColor;
        lineList.Add(this);

      }


      /*public static void drawLine(PictureBox pictureBox) {
        //var pictureBox = Form1.con.Controls.Find("pictureBox", true);
        Graphics gr = pictureBox.CreateGraphics();
        for (int i = 0; i < lineList.Count; i++) {
          gr.DrawLine(new Pen(lineList[i].lineColor, 2), lineList[i].ParentLocation, lineList[i].ChaildLocation);
        }
        //Console.WriteLine("закончен рисование");
      }*/
    }

    private void scrollPanel_SizeChanged(object sender, EventArgs e) {
      drawLine();
    }






    string RandomTextBoxLastCorrect = "";
    private void textRandomInput_TextChanged(object sender, EventArgs e) {
      string sequenceTextNewValue = textRandomInput.Text;
      for (int i = 0; i < sequenceTextNewValue.Length; i++) {
        if ((sequenceTextNewValue.ElementAt(i) < '0' || sequenceTextNewValue.ElementAt(i) > '9')) {//набор алфавита
          textRandomInput.Text = RandomTextBoxLastCorrect;
          return;
        }
      }
      textRandomInput.Text = sequenceTextNewValue;
      RandomTextBoxLastCorrect = sequenceTextNewValue;
      return;

    }
    string KeyboardTextBoxLastCorrect;
    private void textKeyboardInput_TextChanged(object sender, EventArgs e) {
      string sequenceTextNewValue = textKeyboardInput.Text;
      for (int i = 0; i < sequenceTextNewValue.Length; i++) {
        if (sequenceTextNewValue.Length > 0 && (sequenceTextNewValue.ElementAt(i) < '0' || sequenceTextNewValue.ElementAt(i) > '9') && sequenceTextNewValue.ElementAt(i) != ' '){//набор алфавита
          textKeyboardInput.Text = KeyboardTextBoxLastCorrect;
          return;
        }
      }

      while (sequenceTextNewValue.Contains("  "))
        sequenceTextNewValue = sequenceTextNewValue.Replace("  ", " ");

      textKeyboardInput.Text = sequenceTextNewValue;
      KeyboardTextBoxLastCorrect = sequenceTextNewValue;
      return;

    }


    private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
      RandomTextBoxLastCorrect = "";
      textRandomInput.Text = "";
      textRandomOutput.Text = "";
      textRandomOutput.Enabled = false;


      KeyboardTextBoxLastCorrect = "";
      textKeyboardInput.Text = "";

      textFileOutput.Text = "";
      textFileOutput.Enabled = false;

      textKeyboardInput.ReadOnly = false;

    }
    //string FileTextBoxLastCorrect = "";
    private void buttonOpenFile_Click(object sender, EventArgs e) {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
      //saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
      if (openFileDialog.ShowDialog() == DialogResult.Cancel)
        return;
      // получаем выбранный файл
      //string filename = openFileDialog.FileName;
      // читаем файл в строку
      string sequenceTextNewValue = System.IO.File.ReadAllText(openFileDialog.FileName);
      
      for (int i = 0; i < sequenceTextNewValue.Length; i++) {
        if (sequenceTextNewValue.Length > 0 && (sequenceTextNewValue.ElementAt(i) < '0' || sequenceTextNewValue.ElementAt(i) > '9') && sequenceTextNewValue.ElementAt(i) != ' ') {//набор алфавита
          textFileOutput.Text = "";
          MessageBox.Show("Ошибка: Неверный формат записи файла");
          return;
        }
      }

      while (sequenceTextNewValue.Contains("  "))
        sequenceTextNewValue = sequenceTextNewValue.Replace("  ", " ");

      textFileOutput.Text = sequenceTextNewValue;
      textFileOutput.Enabled = true;
      return;
      
    }

    private void textFileOutput_TextChanged(object sender, EventArgs e) {
/*      string sequenceTextNewValue = textFileOutput.Text;
      for (int i = 0; i < sequenceTextNewValue.Length; i++) {
        if (sequenceTextNewValue.Length > 0 && (sequenceTextNewValue.ElementAt(i) < '0' || sequenceTextNewValue.ElementAt(i) > '9') && sequenceTextNewValue.ElementAt(i) != ' ') {//набор алфавита
          textFileOutput.Text = "";
          MessageBox.Show("Ошибка: Неверный формат записи файла");
          return;
        }
      }

      while (sequenceTextNewValue.Contains("  "))
        sequenceTextNewValue = sequenceTextNewValue.Replace("  ", " ");

      textKeyboardInput.Text = sequenceTextNewValue;
      KeyboardTextBoxLastCorrect = sequenceTextNewValue;
      return;*/
    }
    Form2 newForm = null;
    private void buttonAdd_Click(object sender, EventArgs e) {
       newForm = new Form2();
      newForm.Owner = this;
      //newForm.textAddNumber.Text = 
      newForm.Show();
      newForm.buttonAdd.Click += new EventHandler(this.addToTree);
    }

    private void addToTree(object sender, EventArgs e) {
      if (newForm.textAddNumber.Text.Length > 0) {
        int newNode = int.Parse(newForm.textAddNumber.Text);
        if (tree == null || tree.Find(newNode) == null) {
          if (tabControl.SelectedTab.TabIndex == (int)Tabindex.Random) {
            textRandomOutput.Text += newForm.textAddNumber.Text + " ";
            if(textRandomInput.Text.Length>0)
            textRandomInput.Text = (int.Parse(textRandomInput.Text)+1).ToString();
            else
              textRandomInput.Text = 1.ToString();

          }
          else if (tabControl.SelectedTab.TabIndex == (int)Tabindex.Keyboard) {
            textKeyboardInput.Text += " " + newForm.textAddNumber.Text + " ";
            //newNode = int.Parse(newForm.textAddNumber.Text);
          }
          else {
            textFileOutput.Text += " " + newForm.textAddNumber.Text + " ";
            //newNode = int.Parse(newForm.textAddNumber.Text);
          }

          ///////////////
          if (tree == null)
            tree = new BinaryTree();
          tree.Insert(newNode);
          Print(tree, pictureBox);
        }
        
          
        
      }

      newForm.Close();
    }

    private void buttonStartRandom_Click(object sender, EventArgs e) {

    }

    private void pictureBox_Paint(object sender, PaintEventArgs e) {
      drawLine();
    }
  }
}


