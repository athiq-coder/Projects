using System;

namespace Binary_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Btree tree = new Btree();

            tree.insertNode(30);
            tree.insertNode(40);
            tree.displayTree();
        }
    }


    class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node()
        {

        }

        public Node(int data)
        {
            this.data = data;
            this.left = this.right = null;
        }

    }

    class Btree
    {
        Node root;

        public Btree()
        {
            this.root = null;
        }

        public Btree(Node root)
        {
            this.root = root;
        }

        public void insertNode(int data)
        {
            if(this.root == null)
            {
                this.root = new Node(data);
                return;
            }
            recurInsert(this.root, new Node(data));

        }

        public void recurInsert(Node root,Node newNode)
        {
            if(root == null)
            {
                root = newNode;
            }

            if(newNode.data < root.data)
            {
                if(root.left == null)
                {
                    root.left = newNode;
                }else
                {
                    recurInsert(root.left, newNode);
                }
            }else if(newNode.data > root.data)
            {
                if(root.right == null)
                {
                    root.right = newNode;
                }else
                {
                    recurInsert(root.right, newNode);
                }
            }
        }

        public void displayTree()
        {
            displayTree(this.root);
        }

        public void displayTree(Node root)
        {
            if (root == null)
                return;

            Console.Write(root.data + " ");
            displayTree(root.left);
            displayTree(root.right);
        }
    }
}
