/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        int depth = helper(head);
        int depthHalf = depth/2;
        Console.WriteLine("depth:"+depth);
        Console.WriteLine("depthHalf:"+depthHalf);
        Stack stack = new Stack();
        ListNode curNode = head;
        for (int i = 0; i < depthHalf; i++){
            stack.Push(curNode.val);
            curNode = curNode.next;
        }
        
        if (depth % 2 != 0){
            curNode = curNode.next;
        }
        while (stack.Count > 0){
            
            int top = (int)stack.Peek();
            Console.WriteLine("top:"+top);
            if (top == curNode.val){
                stack.Pop();
                curNode = curNode.next;
            } else {
                return false;
            }
        }
        Console.WriteLine(stack.Count);
        if (stack.Count == 0){
            return true;
        } else {
            return false;
        }
        
    }
    
    public int helper(ListNode node) {
        if (node is null){
            return 0;
        }
        if (node.next is null){
            return 1;
        }
        return 1 + helper(node.next);
    }
}