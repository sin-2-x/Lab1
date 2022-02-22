using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Lab1 {

  public enum BinSide {
    Left,
    Right
  }

  /// Бинарное дерево поиска


  public class Node {
    public int? Data; // holds the key
    public Node Parent; // pointer to the parent
    public Node Left; // pointer to left child
    public Node Right; // pointer to right child

    public Node(int? data = null) {
      this.Data = data;
      this.Parent = null;
      this.Left = null;
      this.Right = null;
    }
  }

  public class BinaryTree {
    public Node root;
    /*public int? Data { get; private set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
    public Node Parent { get; set; }*/

    public void Insert(int key) {
      Node node = new Node(key);
      Node y = null;
      Node x = this.root;

      while (x != null) {
        y = x;
        if (node.Data < x.Data) {
          x = x.Left;
        }
        else {
          x = x.Right;
        }
      }

      // y is parent of x
      node.Parent = y;
      if (y == null) {
        root = node;
      }
      else if (node.Data < y.Data) {
        y.Left = node;
      }
      else {
        y.Right = node;
      }
      /*Node before = null, after = this.root;

      while (after != null) {
        before = after;
        if (data < after.Data) //Is new node in left tree? 
          after = after.Left;
        else if (data > after.Data) //Is new node in right tree?
          after = after.Right;
        else {
          //Exist same value
          return;
        }
      }

      Node newNode = new Node(data);
      //newNode.Data = value;

      if (this.root == null)//Tree ise empty
        this.root = newNode;
      else {
        if (data < before.Data)
          before.Left = newNode;
        else
          before.Right = newNode;
      }*/
    }

    /*    private void InsertByValue(int data, Node node, Node parent) {

          if (node.Data == null || node.Data == data) {
            node.Data = data;
            node.Parent = parent;
            return;
          }
          if (node.Data > data) {
            if (node.Left == null) node.Left = new Node();
            InsertByValue(data, node.Left, node);
          }
          else {
            if (node.Right == null) node.Right = new Node();
            InsertByValue(data, node.Right, node);
          }
        }*/

    /*private void InsertByNode(Node dataNode, Node node, Node parent) {

      if (node.Data == null || node.Data == dataNode.Data) {
        node.Data = dataNode.Data;
        node.Left = dataNode.Left;
        node.Right = dataNode.Right;
        node.Parent = parent;
        return;
      }
      if (node.Data > dataNode.Data) {
        if (node.Left == null) node.Left = new Node();
        InsertByNode(dataNode, node.Left, node);
      }
      else {
        if (node.Right == null) node.Right = new Node();
        InsertByNode(dataNode, node.Right, node);
      }
    }*/

    private BinSide? MeForParent(Node node) {
      if (node.Parent == null) return null;
      if (node.Parent.Left == node) return BinSide.Left;
      if (node.Parent.Right == node) return BinSide.Right;
      return null;
    }


    /*public void RemoveByNode(Node node) {
      if (node == null) return;
      var me = MeForParent(node);

      //Если узел явлется корнем 
      if (me == null) {
        *//*Node newNode = new Node();
        if (node.Left != null && node.Parent == null)
        {
            Insert(node.Left, pictureBox, color);
        }


        if (node.Right != null && node.Parent == null)
        {

            Inset(node.Right);
        }*//*

      }



      //Если у узла нет дочерних элементов, его можно смело удалять
      if (node.Left == null && node.Right == null) {

        if (me == BinSide.Left) {
          node.Parent.Left = null;
        }
        else {
          node.Parent.Right = null;
        }
        return;
      }
      //Если нет левого дочернего, то правый дочерний становится на место удаляемого
      if (node.Left == null) {

        if (me == BinSide.Left) {
          node.Parent.Left = node.Right;
        }
        else {
          node.Parent.Right = node.Right;
        }

        node.Right.Parent = node.Parent;
        return;
      }
      //Если нет правого дочернего, то левый дочерний становится на место удаляемого
      if (node.Right == null) {
        if (me == BinSide.Left) {
          node.Parent.Left = node.Left;
        }
        else {
          node.Parent.Right = node.Left;
        }

        node.Left.Parent = node.Parent;
        return;
      }

      //Если присутствуют оба дочерних узла
      //то правый ставим на место удаляемого
      //а левый вставляем в правый

      if (me == BinSide.Left) {
        node.Parent.Left = node.Right;
      }
      if (me == BinSide.Right) {
        node.Parent.Right = node.Right;
      }
      if (me == null) {
        var bufLeft = node.Left;
        var bufRightLeft = node.Right.Left;
        var bufRightRight = node.Right.Right;
        node.Data = node.Right.Data;
        node.Right = bufRightRight;
        node.Left = bufRightLeft;
        InsertByNode(bufLeft, node, node);
      }
      else {
        node.Right.Parent = node.Parent;
        InsertByNode(node.Left, node.Right, node.Right);
      }
    }*/

    public void RemoveByNode(Node node) {
      if (node == null) return;
      var me = MeForParent(node);

      //Если узел явлется корнем 
      if (me == null) {
        /*BinaryTree newNode = new BinaryTree();
        if (node.Left != null && node.Parent == null)
        {
            Insert(node.Left, pictureBox, color);
        }


        if (node.Right != null && node.Parent == null)
        {

            Inset(node.Right);
        }*/

      }



      //Если у узла нет дочерних элементов, его можно смело удалять
      if (node.Left == null && node.Right == null) {

        if (me == BinSide.Left) {
          node.Parent.Left = null;
        }
        else {
          node.Parent.Right = null;
        }
        return;
      }
      //Если нет левого дочернего, то правый дочерний становится на место удаляемого
      if (node.Left == null) {

        if (me == BinSide.Left) {
          node.Parent.Left = node.Right;
        }
        else {
          node.Parent.Right = node.Right;
        }

        node.Right.Parent = node.Parent;
        return;
      }
      //Если нет правого дочернего, то левый дочерний становится на место удаляемого
      if (node.Right == null) {
        if (me == BinSide.Left) {
          node.Parent.Left = node.Left;
        }
        else {
          node.Parent.Right = node.Left;
        }

        node.Left.Parent = node.Parent;
        return;
      }

      //Если присутствуют оба дочерних узла
      //то правый ставим на место удаляемого
      //а левый вставляем в правый

      if (me == BinSide.Left) {
        node.Parent.Left = node.Right;
      }
      if (me == BinSide.Right) {
        node.Parent.Right = node.Right;
      }
      if (me == null) {
        var bufLeft = node.Left;
        var bufRightLeft = node.Right.Left;
        var bufRightRight = node.Right.Right;
        node.Data = node.Right.Data;
        node.Right = bufRightRight;
        node.Left = bufRightLeft;
        InsertByNode(bufLeft, node, node);
      }
      else {
        node.Right.Parent = node.Parent;
        InsertByNode(node.Left, node.Right, node.Right);
      }
    }

    public void Remove(int data) {
      var removeNode = Find(data);
      if (removeNode != null) {
        RemoveByNode(removeNode);
      }
    }
    private void InsertByNode(Node dataNode, Node node, Node parent) {

      if (node.Data == null || node.Data == dataNode.Data) {
        node.Data = dataNode.Data;
        node.Left = dataNode.Left;
        node.Right = dataNode.Right;
        node.Parent = parent;
        return;
      }
      if (node.Data > dataNode.Data) {
        if (node.Left == null) node.Left = new Node();
        InsertByNode(dataNode, node.Left, node);
      }
      else {
        if (node.Right == null) node.Right = new Node();
        InsertByNode(dataNode, node.Right, node);
      }
    }
    private Node MinValue(Node node) {
      int? minv = node.Data;

      while (node.Left != null) {
        minv = node.Left.Data;
        node = node.Left;
      }

      //return minv;
      return node;
    }
    public Node Find(int data) {
      return this.Find(data, this.root);
    }

    public Node Find(int data, Node parent) {
      if (parent != null) {
        if (data == parent.Data) return parent;
        if (data < parent.Data)
          return Find(data, parent.Left);
        else
          return Find(data, parent.Right);
      }

      return null;
    }
    /*
        /// <summary>
        /// Количество элементов в дереве
        /// </summary>
        /// <returns></returns>
        public int CountElements() {
          return CountElements(this);
        }
        /// <summary>
        /// Количество элементов в определённом узле
        /// </summary>
        /// <param name="node">Узел для подсчета</param>
        /// <returns></returns>
        private int CountElements(Node node) {
          int count = 1;
          if (node.Right != null) {
            count += CountElements(node.Right);
          }
          if (node.Left != null) {
            count += CountElements(node.Left);
          }
          return count;
        }*/
  }


}