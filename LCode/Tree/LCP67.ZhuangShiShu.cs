namespace LCode.Tree;

public class LCP67_ZhuangShiShu
{
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    
    public TreeNode ExpandBinaryTree(TreeNode root)
    {
        if (root.left != null)
        {
            var temp = GetLight();
            temp.left = root.left;
            root.left = temp;
            ExpandBinaryTree(temp.left);
        }

        if (root.right != null)
        {
            var temp = GetLight();
            temp.right = root.right;
            root.right = temp;
            ExpandBinaryTree(temp.right);
        }

        return root;
    }

    private TreeNode GetLight()
    {
        return new TreeNode(-1);
    }
    
}
