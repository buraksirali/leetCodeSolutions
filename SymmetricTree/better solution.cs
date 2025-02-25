public bool IsSymmetric(TreeNode root)
{
    if (root == null)
        return true;

    return IsMirror(root.left, root.right);
}

private bool IsMirror(TreeNode node, TreeNode mirrorNode)
{
    var isSymmetric = true;
    if (node != null)
    {
        if (mirrorNode == null)
        {
            return false;
        }
        isSymmetric = IsMirror(node.left, mirrorNode.right) &&
            IsMirror(node.right, mirrorNode.left);
    }

    if (!isSymmetric)
    {
        return false;
    }

    return node?.val == mirrorNode?.val;
}