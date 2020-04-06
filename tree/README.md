# Trees

This program is written to create Nodes, then insert those nodes into a tree, with the larger values on the right and the lower on the left.
Once the tree us created, there are methods written to traverse the tree and return the value in an array in one of three orders
  * PreOrder
  * InOrder
  * PostOrder

## Challenge

* Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.
* Create a BinaryTree class
    * Define a method for each of the depth first traversals called preOrder, inOrder, and postOrder which returns an array of the values, ordered appropriately.
* Create a BinarySearchTree class
    * Define a method named add that accepts a value, and adds a new node with that value in the correct location in the binary search tree.
    * Define a method named contains that accepts a value, and returns a boolean indicating whether or not the value is in the tree at least once.
    
## Approach and Efficiency

* I took the approach of determining each nodes value and determining where in the tree it would be placed based on that value.
* I Believe this solution uses an `O(n)` in time and `O(log n)` space.

## API

* Preorder
* InOrder
* PostOrder
* insertNode
* traverse
