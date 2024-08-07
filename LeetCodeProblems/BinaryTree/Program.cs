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
    private TreeNode root;
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
            while(root != null)
            {
                root = root.left;
            }
        }
    }
}