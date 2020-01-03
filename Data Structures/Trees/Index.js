 
 //Definition for a binary tree node.
function TreeNode(val) {
    this.val = val;
    this.left = this.right = null;
}

//https://leetcode.com/problems/increasing-order-search-tree/

/**
 * @param {TreeNode} root
 * @return {TreeNode}
 */
var increasingBST = function(root) {

};

let simpleInOrder = (root) => {
    console.log(root);
}

let root = new TreeNode(5);
root.left = new TreeNode(3); 
root.right = new TreeNode(6);

root.left.left = new TreeNode(2);
root.left.right = new TreeNode(4);
root.left.left.left = new TreeNode(1);

root.right.right = new TreeNode(8);
root.right.right.right = new TreeNode(9);
root.right.right.left = new TreeNode(7);

simpleInOrder(root);
