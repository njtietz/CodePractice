//https://leetcode.com/problems/binary-tree-inorder-traversal/
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
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> Inorder = new List<int>();
        Inorder = IterateNode(root, Inorder);
        return Inorder;
        
    }
    
    public IList<int> IterateNode(TreeNode node, IList<int> Inorder){
        try{
            if (node.left != null){
                Inorder = IterateNode(node.left, Inorder);
            }
        }
        catch{
            return Inorder;
        }
        
        try {
            Inorder.Add(node.val);
        }
        catch {
            return Inorder;
        }
        try{
            if (node.right != null){
             Inorder = IterateNode(node.right, Inorder);
            }
        }
        catch{
            return Inorder;
        }
        
        return Inorder;
    }
}


