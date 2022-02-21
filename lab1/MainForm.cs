using Lab1.Properties;
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
using System.Configuration;

namespace Lab1 {
  public enum Tabindex {
    Random = 1,
    Keyboard,
    File
  }
  public partial class MainForm : Form {
    public MainForm() {
      InitializeComponent();
      
    }

    private void MainForm_Load(object sender, EventArgs e) {

      buttonStartRandom.Click += new EventHandler(this.PlantTree);
      buttonStartKeyboard.Click += new EventHandler(this.PlantTree);
      buttonStartFile.Click += new EventHandler(this.PlantTree);

      buttonRemoveFile.Click += new EventHandler(ButtonRemove_Click);
      buttonRemoveKeyboard.Click += new EventHandler(ButtonRemove_Click);
      buttonRemoveRandom.Click += new EventHandler(ButtonRemove_Click);

      buttonRemoveRandom.Enabled = false;
      buttonRemoveKeyboard.Enabled = false;
      buttonRemoveFile.Enabled = false;

      textRandomOutput.Enabled = false;
      textRandomOutput.ReadOnly = true;
      textFileOutput.Enabled = false;
      textFileOutput.ReadOnly = true;

      // Makes the tab width definable. 
      this.tabControl.SizeMode = TabSizeMode.Fixed;

      buttonAddFile.Click += new EventHandler(this.ButtonAdd_Click);
      buttonAddKeyboard.Click += new EventHandler(this.ButtonAdd_Click);
      buttonAddRandom.Click += new EventHandler(this.ButtonAdd_Click);

      textFileOutput.TextChanged += new EventHandler(ActivateElements);
      textRandomOutput.TextChanged += new EventHandler(ActivateElements);
      textKeyboardInput.TextChanged += new EventHandler(ActivateElements);



      saveBtn.MouseClick += new MouseEventHandler(ShowSaveMenu);
     // settingsBtn.MouseClick += new MouseEventHandler(ShowSettingsMenu);
      
    }
    /*private void ShowGreeting(object sender, EventArgs e) {
      if (bool.Parse(ConfigurationManager.AppSettings["showGreeting"])) {
        lab1.MessageForm mes = new lab1.MessageForm(Left + Width / 2, Top + Height / 2, 
          "Студент СПБГТИ(ТУ) \nСтарков Силантий Денисович \n403 группа\n Контрольная работа №2\n Вариант №24");
        mes.ShowDialog();
      }
    }*/


    //SAVE
    private void SavelData(object sender, EventArgs e) {
      SaveFileDialog saveFileDialog = new SaveFileDialog {

        Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"
      };

      if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
        return;
      string filename = saveFileDialog.FileName;




      string data;
      if (tabControl.SelectedTab.TabIndex == (int)Tabindex.Random) {
        data = textRandomOutput.Text;

      }
      else if (tabControl.SelectedTab.TabIndex == (int)Tabindex.Keyboard) {
        data = textKeyboardInput.Text;
      }
      else {
        data = textFileOutput.Text;
      }
      System.IO.File.WriteAllText(filename, data);
      MessageBox.Show("Файл сохранен");
    }
    private void SavelResults(object sender, EventArgs e) {
      GeneraitSaveList(tree, 0);
      for (int i = 0; i < saveList.Count; i++)
        Console.WriteLine(saveList[i]);
      saveList.Clear();
    }
    List<StringBuilder> saveList = new List<StringBuilder>();

    void GeneraitSaveList(BinaryTree node, int level) {
      if (node != null) {
        /*if (saveList.Count == level) {

          saveList.Add(new StringBuilder());
          saveList[level].Append(node.Data);

          StringBuilder tab = new StringBuilder();
          
            tab.Append(' ', node.Data.ToString().Length);
          

          if (level != 0) {//Если это не корень, тк корень при добавлении двигать не надо
            for (int i =0; i < level; i++) {// для каждой верхней строчки от нынешней
              Console.WriteLine("use = " + saveList[i]);
              StringBuilder buff = new StringBuilder(saveList[i].ToString());
              Console.WriteLine("buff = " + buff);
              saveList[i].Clear();

              Console.WriteLine("---------------");
              for (int c = 0; c < saveList.Count; c++)
                Console.WriteLine(saveList[c]);
              Console.WriteLine("---------------");


              //for (int a = 0; a < saveList.Count; a++) {
                saveList[i].Append(tab);
              //}
              saveList[i].Append(buff);


            }

          }


        }
        else if (saveList.Count > level) {
          //saveList[level].Append(node.Data);
        }*/

        if (node.Left != null) {
          GeneraitSaveList(node.Left, level + 1);
        }
        if (node.Right != null) {
          GeneraitSaveList(node.Right, level + 1);
        }

        /*GeneraitSaveList(node.Left, level + 1);
        for (int i = 0; i < level; i++) Console.Write("   ");
        Console.WriteLine(node.Data);
        GeneraitSaveList(node.Right, level + 1);*/


      }
    }

    private void ShowSaveMenu(object sender, MouseEventArgs e) {
      saveBtn.ContextMenu = new ContextMenu();
      saveBtn.ContextMenu.MenuItems.Add("Save results", SavelResults);
      saveBtn.ContextMenu.MenuItems.Add("Save data", SavelData);

      saveBtn.ContextMenu.Show(saveBtn, new Point(e.X, e.Y));

    }

    //SETTINGS
/*    private void ShowSettingsMenu(object sender, MouseEventArgs e) {
      *//*settingsBtn.ContextMenu = new ContextMenu();
      settingsBtn.ContextMenu.MenuItems.Add("Show greeting", ShowGreetingChange);
      settingsBtn.ContextMenu.MenuItems[0].Checked = bool.Parse(ConfigurationManager.AppSettings["showGreeting"]);

      settingsBtn.ContextMenu.Show(settingsBtn, new Point(e.X, e.Y));
*//*
    }

    private void ShowGreetingChange(object sender, EventArgs e) {
      *//*var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
      config.AppSettings.Settings["showGreeting"].Value = (!bool.Parse(ConfigurationManager.AppSettings["showGreeting"])).ToString();
      config.Save();
      ConfigurationManager.RefreshSection("appSettings");*//*
    }
*/

    //TREE

    BinaryTree tree = null;

    private void GetInputWay(ref Input inputWay, ref string sequenceTextForStart) {
      switch (tabControl.SelectedTab.TabIndex) {
        case (int)Tabindex.Random:
          inputWay = new RandomInput();
          sequenceTextForStart = textRandomInput.Text;

          break;
        case (int)Tabindex.Keyboard:
          inputWay = new KeyboardInput();
          sequenceTextForStart = textKeyboardInput.Text;
          break;
        case (int)Tabindex.File:
          inputWay = new FileInput();
          sequenceTextForStart = textFileOutput.Text;
          break;
      }
    }
    private void PlantTree(object sender, EventArgs e) {

      string sequenceTextForStart = "";
      Input inputWay = null;
      GetInputWay(ref inputWay, ref sequenceTextForStart);

      if (sequenceTextForStart.Length > 0) {
        int[] arr = inputWay.input(sequenceTextForStart); //нужный массив

        tree = new BinaryTree();
        for (int i = 0; i < arr.Length; i++) {
          tree.Insert(arr[i]);
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
        ClearPictureBox();
        leftmost = Point.Empty;
        Print(tree, pictureBox);
        ClearPictureBox();
        Console.WriteLine("Чистовая");

        Print(tree, pictureBox, default, leftmost);

      }
    }
    private void RepaintTree() {

      ClearPictureBox();
      pictureBox.Size = scrollPanel.MinimumSize;

      Print(tree, pictureBox);
      pictureBox.Update();
      NodeForDraw.DrawLine(pictureBox);

    }


    Point leftmost = Point.Empty;
    Point rightmost = Point.Empty;
    Point correction = new Point(40, 40);
    public void Print(BinaryTree node, PictureBox pictureBox, Color color = default, Point a = new Point()) {
      if (node.Data != null) {
        if (node.Parent == null) {  //Все для прорисовки корня
          Console.WriteLine("ROOT:" + node.Data);
          /*
                    //if (a.IsEmpty)
                     // a = new Point(pictureBox.Width / 2, 0);
                    //a.X = a.X + pictureBox.Width / 2;*/

          NodeForDraw nodeDraw = new NodeForDraw(node.Data.ToString(), new Point(Math.Abs(a.X) + pictureBox.Width / 2, 0), Color.FromArgb(59, 131, 189));

          NodeForDraw.drawList.Add(nodeDraw);
          pictureBox.Controls.Add(nodeDraw);
          nodeDraw.BringToFront();
        }
        else {    //Все для прорисовки узлов

          Point parentLocation = Point.Empty;                  //find parent location
          NodeForDraw parentNode = new NodeForDraw();
          for (int i = 0; i < NodeForDraw.drawList.Count; i++) {
            if (NodeForDraw.drawList[i].Text == node.Parent.Data.ToString()) {
              parentNode = NodeForDraw.drawList[i];
              break;
            }
          }
          parentLocation = parentNode.Location;
          NodeForDraw nodeDraw = new NodeForDraw();
          if (node.Parent.Left == node) { //Прорисовка левого узла
            Console.WriteLine("Left for " + node.Parent.Data + "  --> " + node.Data);
            //NodeForDraw nodeDraw;

            if (color == Color.FromArgb(255, 46, 99)) {

            }


            nodeDraw = new NodeForDraw(node.Data.ToString(), new Point(parentLocation.X - correction.X, parentLocation.Y + +20 + correction.Y), color);

            if (nodeDraw.Location.X - nodeDraw.Width < 0) {
              if (nodeDraw.Location.X - nodeDraw.Width < leftmost.X)
                leftmost = new Point(Math.Abs(nodeDraw.Location.X - nodeDraw.Width), 0);


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


            nodeDraw = new NodeForDraw(node.Data.ToString(), new Point(parentLocation.X + correction.X, parentLocation.Y + 20 + correction.Y), color);



            if ((nodeDraw.Location.X + nodeDraw.Width) > pictureBox.Width) {
              pictureBox.Width = nodeDraw.Location.X + nodeDraw.Width;
            }
            if ((nodeDraw.Location.Y + nodeDraw.Height) > pictureBox.Height) {
              pictureBox.Height = nodeDraw.Location.Y + nodeDraw.Height * 2;
            }


            NodeForDraw.drawList.Add(nodeDraw);
            pictureBox.Controls.Add(nodeDraw);
            nodeDraw.BringToFront();

          }

          correction.X += 40;
          correction.Y += 40;
          List<NodeForDraw> buffLine = new List<NodeForDraw>();
          buffLine.Add(parentNode);
          buffLine.Add(nodeDraw);

          //NodeForDraw.pointListForLines.Add(buffLine);
          NodeForDraw.nodeListForLines.Add(buffLine);


        }
        if (node.Left != null && node.Parent == null) {
          color = Color.FromArgb(255, 46, 99);
          Print(node.Left, pictureBox, color);
        }
        else if (node.Left != null) {
          Print(node.Left, pictureBox, color);
        }


        if (node.Right != null && node.Parent == null) {
          color = Color.FromArgb(37, 42, 52);
          Print(node.Right, pictureBox, color);
        }
        else if (node.Right != null) {
          Print(node.Right, pictureBox, color);
        }
      }
      //LineForDraw.drawLine(pictureBox);

      NodeForDraw.DrawLine(pictureBox);
      correction = new Point(30, 30);
    }
    private void ClearPictureBox() {
      pictureBox.Controls.Clear();

      NodeForDraw.drawList.Clear();
      NodeForDraw.nodeListForLines.Clear();
      Graphics gr = pictureBox.CreateGraphics();
      gr.Clear(pictureBox.BackColor);
      pictureBox.Update();
    }
    class NodeForDraw : Label {

      public static List<List<NodeForDraw>> nodeListForLines = new List<List<NodeForDraw>>();
      public static List<NodeForDraw> drawList = new List<NodeForDraw>(); //Список всех узлов для отрисовки с параметрами

      public NodeForDraw() { }
      public NodeForDraw(string text, Point loc, Color color) {
        AutoSize = true;
        Location = loc;
        BackColor = color;
        Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
        ForeColor = Color.White;
        Text = text;


        this.MouseDown += new MouseEventHandler((object sender, MouseEventArgs e) => { isMouseDown = true; cursorStartinLocation = Cursor.Position; });
        this.MouseUp += new MouseEventHandler((object sender, MouseEventArgs e) => isMouseDown = false);
        this.MouseMove += new MouseEventHandler(MoveNode);
      }
      Point cursorStartinLocation = new Point();//Не спрашивай...
      bool isMouseDown = false;
      void MoveNode(object sender, MouseEventArgs e) {
        NodeForDraw nodeToMove = (NodeForDraw)sender;
        if (isMouseDown) {
          Location = new Point(this.Location.X + (Cursor.Position.X - cursorStartinLocation.X), this.Location.Y + (Cursor.Position.Y - cursorStartinLocation.Y));
          cursorStartinLocation = Cursor.Position;

          //repaint lines

          for (int i = 0; i < nodeListForLines.Count; i++) {
            List<NodeForDraw> linesToMove = new List<NodeForDraw>();
            if (nodeListForLines[i][0] == nodeToMove) {

              nodeListForLines[i][0].Location = new Point(this.Location.X + (Cursor.Position.X - cursorStartinLocation.X), this.Location.Y + (Cursor.Position.Y - cursorStartinLocation.Y));
              //DrawLine((PictureBox)nodeToMove.Parent, nodeListForLines[i]);
              DrawLine((PictureBox)nodeToMove.Parent);
            }
          }

          // DrawLine((PictureBox)nodeToMove.Parent);
        }
      }


      public static void DrawLine(PictureBox pictureBox) {
        Graphics gr = pictureBox.CreateGraphics();

        gr.Clear(pictureBox.BackColor);
        pictureBox.Update();
        if (nodeListForLines.Count != 0) {
          for (int i = 0; i < nodeListForLines.Count; i++) {
            gr.DrawLine(new Pen(nodeListForLines[i][0].BackColor, 2), new Point(nodeListForLines[i][0].Location.X + nodeListForLines[i][0].Width / 2, nodeListForLines[i][0].Location.Y + nodeListForLines[i][0].Height / 2), new Point(nodeListForLines[i][1].Location.X + nodeListForLines[i][1].Width / 2, nodeListForLines[i][1].Location.Y + nodeListForLines[i][1].Height / 2));
          }
        }
      }

      /*  public static void DrawLine(PictureBox pictureBox, List<NodeForDraw> MoveNode) {
          Graphics gr = pictureBox.CreateGraphics();

          //gr.Clear(pictureBox.BackColor);
          //pictureBox.Update();
          //if (nodeListForLines.Count != 0) {
          //for (int i = 0; i < nodeListForLines.Count; i++) {
          gr.DrawLine(new Pen(MoveNode[0].BackColor, 2), MoveNode[0].Location, MoveNode[1].Location);
          //}
          //}
        }*/



    }




    //WINFORMS
    private void ScrollPanel_SizeChanged(object sender, EventArgs e) {
      pictureBox.MinimumSize = scrollPanel.Size;
      NodeForDraw.DrawLine(pictureBox);

    }
    private void PictureBox_Paint(object sender, PaintEventArgs e) {
      NodeForDraw.DrawLine(pictureBox);
    }
    private void CleanBtn_Click(object sender, EventArgs e) {
      if (tabControl.SelectedTab.TabIndex == (int)Tabindex.Random) {
        textRandomOutput.Text = "";
        textRandomInput.Text = "";

      }
      else if (tabControl.SelectedTab.TabIndex == (int)Tabindex.Keyboard) {
        textKeyboardInput.Text = "";
      }
      else {
        textFileOutput.Text = "";
      }
    }

    private void PictureBox_Click(object sender, EventArgs e) {
      Console.WriteLine("clicc");
    }
    private void ActivateElements(object sender, EventArgs e) {

      if (tabControl.SelectedTab.TabIndex == (int)Tabindex.Random) {
        if (textRandomOutput.Text != "") {
          buttonRemoveRandom.Enabled = true;
          //buttonStartRandom.Enabled = true;
        }
        else {
          buttonRemoveRandom.Enabled = false;
          //buttonStartRandom.Enabled = false;
        }
      }
      else if (tabControl.SelectedTab.TabIndex == (int)Tabindex.Keyboard) {
        if (textKeyboardInput.Text != "") {
          buttonRemoveKeyboard.Enabled = true;
          //buttonStartRandom.Enabled = true;
        }
        else {
          buttonRemoveKeyboard.Enabled = false;
          //buttonStartRandom.Enabled = false;
        }
      }

      else if (tabControl.SelectedTab.TabIndex == (int)Tabindex.File) {
        if (textFileOutput.Text != "") {
          buttonRemoveFile.Enabled = true;
          //buttonStartRandom.Enabled = true;
        }
        else {
          buttonRemoveFile.Enabled = false;
          //buttonStartRandom.Enabled = false;
        }
      }



    }
    private void TabControl_SelectedIndexChanged(object sender, EventArgs e) {
      /*RandomTextBoxLastCorrect = "";
      textRandomInput.Text = "";
      textRandomOutput.Text = "";
      textRandomOutput.Enabled = false;


      KeyboardTextBoxLastCorrect = "";
      textKeyboardInput.Text = "";

      textFileOutput.Text = "";
      textFileOutput.Enabled = false;

      textKeyboardInput.ReadOnly = false;

      tree = null;*/

    }




    //ADD/REMOVE
    AddRemoveForm addRemoveForm = null;
    private void ButtonAdd_Click(object sender, EventArgs e) {
      addRemoveForm = new AddRemoveForm(this.Left + this.Width / 2, this.Top + this.Height / 2);
      addRemoveForm.buttonAdd.Click += new EventHandler(this.AddToTree);
      addRemoveForm.ShowDialog();

    }
    private void AddToTree(object sender, EventArgs e) {
      if (addRemoveForm.textAddNumber.Text.Length > 0) {
        int newNode = int.Parse(addRemoveForm.textAddNumber.Text);
        if (tree == null || tree.Find(newNode) == null) {
          if (tabControl.SelectedTab.TabIndex == (int)Tabindex.Random) {
            textRandomOutput.Text += addRemoveForm.textAddNumber.Text + " ";
            if (textRandomInput.Text.Length > 0)
              textRandomInput.Text = (int.Parse(textRandomInput.Text) + 1).ToString();
            else
              textRandomInput.Text = 1.ToString();

          }
          else if (tabControl.SelectedTab.TabIndex == (int)Tabindex.Keyboard) {
            textKeyboardInput.Text += " " + addRemoveForm.textAddNumber.Text + " ";
            //newNode = int.Parse(newForm.textAddNumber.Text);
          }
          else {
            textFileOutput.Text += " " + addRemoveForm.textAddNumber.Text + " ";
            //newNode = int.Parse(newForm.textAddNumber.Text);
          }
          if (tree == null)
            tree = new BinaryTree();
          tree.Insert(newNode);
          ClearPictureBox();
          Print(tree, pictureBox);
        }
        else {
          lab1.MessageForm mes = new lab1.MessageForm(Left + Width / 2, Top + Height / 2, "Элемент уже введен.");
          mes.ShowDialog();
        }


      }

      addRemoveForm.Close();
    }

    private void ButtonRemove_Click(object sender, EventArgs e) {
      addRemoveForm = new AddRemoveForm(Left + Width / 2, Top + Height / 2);
      addRemoveForm.buttonAdd.Click += new EventHandler(this.RemoveFromTree);
      addRemoveForm.ShowDialog();
    }
    private void RemoveFromTree(object sender, EventArgs e) {

      if (addRemoveForm.textAddNumber.Text.Length > 0) {
        int newNode = int.Parse(addRemoveForm.textAddNumber.Text);

        if (!(tree is null) && tree.Find(newNode) != null && tree.Data != newNode) {
          if (tabControl.SelectedTab.TabIndex == (int)Tabindex.Random) {
            if (textRandomOutput.Text.IndexOf(" " + addRemoveForm.textAddNumber.Text + " ") != -1) {
              textRandomOutput.Text = textRandomOutput.Text.Replace(" " + addRemoveForm.textAddNumber.Text + " ", " "); // убираем из поля вывода
              if (textRandomInput.Text.Length > 0)
                textRandomInput.Text = (int.Parse(textRandomInput.Text) - 1).ToString();
              tree.Remove(newNode);
              RepaintTree();
            }


          }
          else if (tabControl.SelectedTab.TabIndex == (int)Tabindex.Keyboard) {

            if (textKeyboardInput.Text.IndexOf(" " + addRemoveForm.textAddNumber.Text) != -1) {
              textKeyboardInput.Text = textKeyboardInput.Text.Replace(" " + addRemoveForm.textAddNumber.Text, ""); // убираем из поля вывода
              tree.Remove(newNode);
              RepaintTree();

            }


          }
          else {
            if (textFileOutput.Text.IndexOf(" " + addRemoveForm.textAddNumber.Text) != -1) {
              textFileOutput.Text = textFileOutput.Text.Replace(" " + addRemoveForm.textAddNumber.Text, ""); // убираем из поля вывода
              tree.Remove(newNode);
              RepaintTree();
            }
          }
        }
        else {
          lab1.MessageForm mes = new lab1.MessageForm(Left + Width / 2, Top + Height / 2, "Элемент не найден.");
          mes.ShowDialog();
        }

      }

      addRemoveForm.Close();
    }




    //INPUT
    string KeyboardTextBoxLastCorrect;
    private void TextKeyboardInput_TextChanged(object sender, EventArgs e) {
      string sequenceTextNewValue = textKeyboardInput.Text;
      if (sequenceTextNewValue.Length > 0) {
        for (int i = 0; i < sequenceTextNewValue.Length; i++) {
          if (sequenceTextNewValue.Length > 0 && (sequenceTextNewValue.ElementAt(i) < '0' || sequenceTextNewValue.ElementAt(i) > '9') && sequenceTextNewValue.ElementAt(i) != ' ') {//набор алфавита
            textKeyboardInput.Text = KeyboardTextBoxLastCorrect;
            return;
          }
        }

        while (sequenceTextNewValue.Contains("  "))
          sequenceTextNewValue = sequenceTextNewValue.Replace("  ", " ");
        if (sequenceTextNewValue.ElementAt(0) == ' ') {
          sequenceTextNewValue = sequenceTextNewValue.Remove(0, 1);
        }

        textKeyboardInput.Text = sequenceTextNewValue;
        KeyboardTextBoxLastCorrect = sequenceTextNewValue;
        return;
      }
    }
    private void TextFileOutput_TextChanged(object sender, EventArgs e) {
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
    private void ButtonOpenFile_Click(object sender, EventArgs e) {
      OpenFileDialog openFileDialog = new OpenFileDialog {
        Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"
      };
      if (openFileDialog.ShowDialog() == DialogResult.Cancel)
        return;

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
    string RandomTextBoxLastCorrect = "";
    private void TextRandomInput_TextChanged(object sender, EventArgs e) {
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





    private bool Dragging;
    private int xPos;
    private int yPos;
    private void pictureBox_MouseMove(object sender, MouseEventArgs e) {
      //Console.WriteLine("cl");
      Control c = sender as Control;
      if (Dragging && c != null) {
        c.Top = e.Y + c.Top - yPos;
        c.Left = e.X + c.Left - xPos;
      }
    }

    private void pictureBox_MouseDown(object sender, MouseEventArgs e) {
      if (e.Button == MouseButtons.Left) {
        Dragging = true;
        xPos = e.X;
        yPos = e.Y;
      }
    }

    private void pictureBox_MouseUp(object sender, MouseEventArgs e) {
      Dragging = false;
    }

    private void MainForm_SizeChanged(object sender, EventArgs e) {
      
    }
  }
}


