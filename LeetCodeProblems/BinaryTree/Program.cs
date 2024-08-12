BinaryTree binaryTree = new BinaryTree();
binaryTree.Insert(5);
binaryTree.Insert(6);
binaryTree.Insert(7);
binaryTree.Insert(1);
binaryTree.Insert(2);
binaryTree.Insert(3);

//binaryTree.Traverse(binaryTree.root);
binaryTree.TraverseInOrder(binaryTree.root);

hi
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class BinaryTree
{
    public TreeNode root;
    public BinaryTree()
    {
        root = null;
    }

    public void Insert(int val)
    {
        if(root == null)
        {
            root = new TreeNode(val);
        }
        else
        {
            InsertRecord(root, val);
        }
    }

    private void InsertRecord(TreeNode root, int val)
    {
        if(val < root.val)
        {
            if(root.left == null)
            {
                root.left = new TreeNode(val);
            }
            else
            {
                InsertRecord(root.left, val);
            }
        }
        else
        {
            if (root.right == null)
            {
                root.right = new TreeNode(val);
            }
            else{
                InsertRecord(root.right, val);
            }
        }
    }

    public void Traverse(TreeNode root)
    {
        if(root == null)
        {
            return;
        }
        Traverse(root.left);
        Console.WriteLine(root.val);
        Traverse(root.right);
    }

    public void TraverseInOrder(TreeNode root)
    {
        if(root == null)
        {
            return;
        }
        else
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while(queue.Count > 0)
            {
                int levelCount = queue.Count;
                for(int i = 0; i< levelCount; i++)
                {
                    TreeNode currentNode = queue.Dequeue();
                    if (currentNode.left != null)
                    {
                        queue.Enqueue(currentNode.left);
                    }
                    if(currentNode.right != null)
                    {
                        queue.Enqueue(currentNode.right);
                    }
                    Console.WriteLine(currentNode.val);
                }
            }

        }
    }
}



