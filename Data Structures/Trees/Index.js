 
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
    //base condition
    if (root === undefined || root === null) {
        return;
    }
    if (root.left === undefined || root.left === null && root.right === undefined || root.right === null) {
        console.log(root.val);
        return;
    }
    simpleInOrder(root.left);
    console.log(root.val);
    simpleInOrder(root.right);
}

//tree1 

let root = new TreeNode(5);
root.left = new TreeNode(3); 
root.right = new TreeNode(6);

root.left.left = new TreeNode(2);
root.left.right = new TreeNode(4);
root.left.left.left = new TreeNode(1);

root.right.right = new TreeNode(8);
root.right.right.right = new TreeNode(9);
root.right.right.left = new TreeNode(7);

//tree2
let root2 = new TreeNode(1);
root2.left = new TreeNode(2);
root2.right = new TreeNode(3);
root2.left.left = new TreeNode(4);
root2.left.right = new TreeNode(5);

simpleInOrder(root2);