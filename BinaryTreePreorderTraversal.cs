//https://leetcode.com/problems/binary-tree-preorder-traversal/
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        IList<int> Preorder = new List<int>();
        Preorder = IterateNode(root, Preorder);
        return Preorder;
    }
    
    public IList<int> IterateNode(TreeNode node, IList<int> Preorder){
        try {
            Preorder.Add(node.val);
        }
        catch {
            return Preorder;
        }
        if (node.left != null){
            Preorder = IterateNode(node.left, Preorder);
        }
        if (node.right != null){
            Preorder = IterateNode(node.right, Preorder);
        }
        return Preorder;
    }
}
