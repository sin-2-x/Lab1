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



  /*class Node {
    public Node Left { get; set; }
    public Node Right { get; set; }
    public Node Parent { get; set; }
    public int Data { get; set; }
  }
  class BinaryTree {
    public Node Root { get; set; }

    public bool Add(int value) {
      Node before = null, after = this.Root;

      while (after != null) {
        before = after;
        if (value < after.Data) //Is new node in left tree? 
          after = after.Left;
        else if (value > after.Data) //Is new node in right tree?
          after = after.Right;
        else {
          //Exist same value
          return false;
        }
      }

      Node newNode = new Node();
      newNode.Data = value;

      if (this.Root == null)//Tree ise empty
        this.Root = newNode;
      else {
        if (value < before.Data)
          before.Left = newNode;
        else
          before.Right = newNode;
      }

      return true;
    }

    public Node Find(int value) {
      return this.Find(value, this.Root);
    }

    public void Remove(int value) {
      this.Root = Remove(this.Root, value);
    }

    private Node Remove(Node parent, int key) {
      if (parent == null) return parent;

      if (key < parent.Data) parent.Left = Remove(parent.Left, key);
      else if (key > parent.Data)
        parent.Right = Remove(parent.Right, key);

      // if value is same as parent's value, then this is the node to be deleted  
      else {
        // node with only one child or no child  
        if (parent.Left == null)
          return parent.Right;
        else if (parent.Right == null)
          return parent.Left;

        // node with two children: Get the inorder successor (smallest in the right subtree)  
        parent.Data = MinValue(parent.Right);

        // Delete the inorder successor  
        parent.Right = Remove(parent.Right, parent.Data);
      }

      return parent;
    }

    private int MinValue(Node node) {
      int minv = node.Data;

      while (node.Left != null) {
        minv = node.Left.Data;
        node = node.Left;
      }

      return minv;
    }

    private Node Find(int value, Node parent) {
      if (parent != null) {
        if (value == parent.Data) return parent;
        if (value < parent.Data)
          return Find(value, parent.Left);
        else
          return Find(value, parent.Right);
      }

      return null;
    }

    public int GetTreeDepth() {
      return this.GetTreeDepth(this.Root);
    }

    private int GetTreeDepth(Node parent) {
      return parent == null ? 0 : Math.Max(GetTreeDepth(parent.Left), GetTreeDepth(parent.Right)) + 1;
    }

    public void TraversePreOrder(Node parent) {
      if (parent != null) {
        Console.Write(parent.Data + " ");
        TraversePreOrder(parent.Left);
        TraversePreOrder(parent.Right);
      }
    }

    public void TraverseInOrder(Node parent) {
      if (parent != null) {
        TraverseInOrder(parent.Left);
        Console.Write(parent.Data + " ");
        TraverseInOrder(parent.Right);
      }
    }

    public void TraversePostOrder(Node parent) {
      if (parent != null) {
        TraversePostOrder(parent.Left);
        TraversePostOrder(parent.Right);
        Console.Write(parent.Data + " ");
      }
    }
  }
*/

}