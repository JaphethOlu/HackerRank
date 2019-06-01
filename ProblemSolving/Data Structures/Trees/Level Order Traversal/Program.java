import java.util.*;
import java.io.*;

class Node {
    Node left;
    Node right;
    int data;
    
    Node(int data) {
        this.data = data;
        left = null;
        right = null;
    }
}

class Solution {

	/* 
    
    class Node 
    	int data;
    	Node left;
    	Node right;
	*/
	public static void levelOrder(Node root) {
      
        Queue treeQueue = new LinkedList();

        treeQueue.add(root);

        while(treeQueue.size() != 0)
        {
            Node currentNode = (Node) treeQueue.remove();

            if(currentNode.left != null)
            {
                treeQueue.add(currentNode.left);
            }

            if(currentNode.right != null)
            {
                treeQueue.add(currentNode.right);
            }

            System.out.print(currentNode.data);
            System.out.print(" ");
        }

    }

	public static Node insert(Node root, int data) {
        if(root == null) {
            return new Node(data);
        } else {
            Node cur;
            if(data <= root.data) {
                cur = insert(root.left, data);
                root.left = cur;
            } else {
                cur = insert(root.right, data);
                root.right = cur;
            }
            return root;
        }
    }

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int t = scan.nextInt();
        Node root = null;
        while(t-- > 0) {
            int data = scan.nextInt();
            root = insert(root, data);
        }
        scan.close();
        levelOrder(root);
    }	
}