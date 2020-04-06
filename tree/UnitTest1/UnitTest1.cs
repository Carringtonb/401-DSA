using System;
using Tree.Classes;
using Xunit;

namespace UnitTest1
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateAnEmptyTree()
        {
            BinarySearchTree tree = new BinarySearchTree();
            Assert.Null(tree.Root);
        }
        [Fact]
        public void CanInstantiateTreeWithSingleNode()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.insertNode(tree.Root, 24);

            Assert.Equal(24, tree.Root.Value);
        }
        [Fact]
        public void CanAddLeftChildNode()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.insertNode(tree.Root, 13);
            tree.insertNode(tree.Root, 24);
            tree.insertNode(tree.Root, 4);

            Assert.Equal(4, tree.Root.Left.Value);
            Assert.Equal(24, tree.Root.Right.Value);
        }
        [Fact]
        public void CanTraversePreOrder()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.insertNode(tree.Root, 13);
            tree.insertNode(tree.Root, 24);
            tree.insertNode(tree.Root, 4);

            BinaryTree treeTwo = new BinaryTree();
            treeTwo.PreOrder();

            
        }
    }
}
