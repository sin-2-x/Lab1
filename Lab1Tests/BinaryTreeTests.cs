using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Tests {
  [TestClass()]
  public class BinaryTreeTests {
    private static BinaryTree tree;

    [TestMethod()]
    public void Test_1_Insert() {
      tree = new BinaryTree {
        root = new Node(55)
      };
      int newLeftNodeData = 45;
      tree.Insert(newLeftNodeData);
      Assert.AreEqual(tree.root.Left.Data, newLeftNodeData);
    }

    [TestMethod()]
    public void Test_2_Remove() {

      tree.Remove((int)tree.root.Left.Data);

      Assert.AreEqual(null, tree.root.Left);
    }

    [TestMethod()]
    public void Test_3_Find() {
      Assert.AreEqual(null, tree.Find(45));
    }
    [TestMethod()]
    public void Test_4_Duplicate() {
      tree.Insert(2);
      tree.Insert(2);
      Assert.AreEqual(null, tree.root.Left.Left);
      Assert.AreEqual(null, tree.root.Left.Right);
    }
  }
}