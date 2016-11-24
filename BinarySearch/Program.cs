using System;
using System.Collections.Generic;

class Node{
    public Node left,right;
    public int data;
    public Node(int data){
        this.data=data;
        left=right=null;
    }
}
class Solution{
    static void levelOrder(Node root){
        //Write your code here
        string res = "";
        Node current;

        Queue<Node> q = new Queue<Node>();

        q.Enqueue(root);

        while(q.Count > 0){
            current = q.Peek();
            res += current.data.ToString() + " ";
            if (current.left != null){
                q.Enqueue(current.left);
            }
            if (current.right != null){
                q.Enqueue(current.right);
            }
            q.Dequeue();
        }
        Console.WriteLine(res.TrimEnd());
        Console.ReadLine();
    }

    static Node insert(Node root, int data){
        if(root==null){
            return new Node(data);
        }
        else{
            Node cur;
            if(data<=root.data){
                cur=insert(root.left,data);
                root.left=cur;
            }
            else{
                cur=insert(root.right,data);
                root.right=cur;
            }
            return root;
        }
    }
    static void Main(String[] args){
        Node root=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            root=insert(root,data);            
        }
        levelOrder(root);
        
    }
}