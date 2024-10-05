internal class Program
{
    public static void Main(string[] args)
    {
        BSTLevel bst = new BSTLevel();

        int[] values = { 10, 5, 3, 15, 7, 12, 18 };
        foreach (int value in values)
        {
            bst.Insert(new TreeNode(value));
        }

        bst.Traverse(bst.Root);
    }
}



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


public class BSTLevel
{
    public TreeNode Root;
    public void Insert(TreeNode node)
    {
        Root = InsertRec(Root, node.val);
    }
    public TreeNode InsertRec(TreeNode root, int val)
    {
        if (root == null)
        {
            root = new TreeNode(val);
            return root;
        }
        if(root.val > val)
        {
            root.left = InsertRec(root.left, val);
        }
        else
        {
            root.right = InsertRec(root.right, val);
        }
        return root;
        
    }
    public void Traverse(TreeNode root)
    {
        if(root != null)
        {
            Traverse(root.left);
            Console.WriteLine(root.val);
            Traverse(root.right);
        }
    }
}

