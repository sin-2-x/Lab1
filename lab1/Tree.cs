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

  public class BinaryTree {

    public int? Data { get; private set; }
    public BinaryTree Left { get; set; }
    public BinaryTree Right { get; set; }
    public BinaryTree Parent { get; set; }

    public void Insert(int data) {
      if (Data == null || Data == data) {
        Data = data;
        return;
      }
      if (Data > data) {
        if (Left == null) Left = new BinaryTree();
        InsertByValue(data, Left, this);
      }
      else {
        if (Right == null) Right = new BinaryTree();
        InsertByValue(data, Right, this);
      }
    }

    private void InsertByValue(int data, BinaryTree node, BinaryTree parent) {

      if (node.Data == null || node.Data == data) {
        node.Data = data;
        node.Parent = parent;
        return;
      }
      if (node.Data > data) {
        if (node.Left == null) node.Left = new BinaryTree();
        InsertByValue(data, node.Left, node);
      }
      else {
        if (node.Right == null) node.Right = new BinaryTree();
        InsertByValue(data, node.Right, node);
      }
    }

    private void InsertByNode(BinaryTree dataNode, BinaryTree node, BinaryTree parent) {

      if (node.Data == null || node.Data == dataNode.Data) {
        node.Data = dataNode.Data;
        node.Left = dataNode.Left;
        node.Right = dataNode.Right;
        node.Parent = parent;
        return;
      }
      if (node.Data > dataNode.Data) {
        if (node.Left == null) node.Left = new BinaryTree();
        InsertByNode(dataNode, node.Left, node);
      }
      else {
        if (node.Right == null) node.Right = new BinaryTree();
        InsertByNode(dataNode, node.Right, node);
      }
    }

    private BinSide? MeForParent(BinaryTree node) {
      if (node.Parent == null) return null;
      if (node.Parent.Left == node) return BinSide.Left;
      if (node.Parent.Right == node) return BinSide.Right;
      return null;
    }


    public void RemoveByNode(BinaryTree node) {
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
    public BinaryTree Find(int data) {
      if (Data == data) return this;
      if (Data > data) {
        return Find(data, Left);
      }
      return Find(data, Right);
    }

    public BinaryTree Find(int data, BinaryTree node) {
      if (node == null) return null;

      if (node.Data == data) return node;
      if (node.Data > data) {
        return Find(data, node.Left);
      }
      return Find(data, node.Right);
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
        private int CountElements(BinaryTree node) {
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