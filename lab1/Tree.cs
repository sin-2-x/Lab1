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
    public int? Data { get; set; } 
    public Node Parent { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(int? data = null) {
      this.Data = data;
      this.Parent = null;
      this.Left = null;
      this.Right = null;
    }
  }

  public class BinaryTree {
    public Node root;
    public void Insert(int key) {
      if (Find(key)==null) {
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
      }
    }

    private BinSide? MeForParent(Node node) {
      if (node.Parent == null) return null;
      if (node.Parent.Left == node) return BinSide.Left;
      if (node.Parent.Right == node) return BinSide.Right;
      return null;
    }

    public void RemoveByNode(Node node) {
      if (node == null) return;
      var me = MeForParent(node);

      if (me == null) {

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
  }


}