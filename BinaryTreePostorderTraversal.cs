//https://leetcode.com/problems/binary-tree-postorder-traversal/
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
    public IList<int> PostorderTraversal(TreeNode root) {
       IList<int> Postorder = new List<int>();
        Postorder = IterateNode(root, Postorder);
        return Postorder;
        
    }
    
    public IList<int> IterateNode(TreeNode node, IList<int> Postorder){
        try{
            if (node.left != null){
                Postorder = IterateNode(node.left, Postorder);
            }
        }
        catch{
            return Postorder;
        }
        
        try{
            if (node.right != null){
             Postorder = IterateNode(node.right, Postorder);
            }
        }
        catch{
            return Postorder;
        }
        
        try {
            Postorder.Add(node.val);
        }
        catch {
            return Postorder;
        }
        
        return Postorder;
    }
}