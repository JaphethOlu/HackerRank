using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        Queue<Node> nodeQ = new Queue<Node>();

        String answer = "";

        nodeQ.Enqueue(root);

        while(nodeQ.Count() != 0) {
            Node currentNode = nodeQ.Dequeue();
            if(currentNode.left != null && nodeQ.Contains(currentNode.left) == false) {
                nodeQ.Enqueue(currentNode.left);
            }

            if(currentNode.right != null && nodeQ.Contains(currentNode.right) == false) {
                nodeQ.Enqueue(currentNode.right);
            }

            if(answer == "") {
                answer = $"{currentNode.data}";
            } else {
                answer = String.Concat(answer, $" {currentNode.data}");
            }
        }
        Console.WriteLine(answer);
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