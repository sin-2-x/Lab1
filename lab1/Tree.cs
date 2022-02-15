using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace lab1 {
  public class BinaryTree {

    public int? Data { get; private set; }
    public BinaryTree Left { get; set; }
    public BinaryTree Right { get; set; }
    public BinaryTree Parent { get; set; }
    public static List<Label> knotArr = new List<Label>();



    public void Insert(int data) { //Добавление любого узла
      if (Data == null || Data == data) { //is it a root
        Data = data;
        return;
      }
      if (Data > data) {
        if (Left == null)
          Left = new BinaryTree(); //create feft node
        Insert(data, Left, this);//fill left node
      }
      else {
        if (Right == null)
          Right = new BinaryTree();
        Insert(data, Right, this);
      }
    }


    private void Insert(int data, BinaryTree node, BinaryTree parent) { // adding l\r node

      if (node.Data == null || node.Data == data) {
        node.Data = data;
        node.Parent = parent;
        return;
      }
      if (node.Data > data) {
        if (node.Left == null) node.Left = new BinaryTree();
        Insert(data, node.Left, node);
      }
      else {
        if (node.Right == null) node.Right = new BinaryTree();
        Insert(data, node.Right, node);
      }
    }

  }
}