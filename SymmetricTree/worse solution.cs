public bool IsSymmetric(TreeNode root)
{
    if (root.left == null)
        return root.right == null;
    if (root.right == null)
        return root.left == null;

    var leftSide = root.left;

    // False means we are checking the left, true means right
    var navigation = new List<bool>();
    var isSymmetric = IsSymmetric(leftSide, root, navigation, false);
    return isSymmetric;
}

private bool IsSymmetric(TreeNode node, TreeNode root, IList<bool> navigation, bool IsRight)
{
    navigation.Add(IsRight);
    var isSymmetric = true;
    if (node != null)
    {
        isSymmetric = IsSymmetric(node.left, root, [.. navigation], false) &&
            IsSymmetric(node.right, root, [.. navigation], true);
    }

    if (!isSymmetric)
    {
        return false;
    }

    var counterNode = GetCounterNode(root, navigation);
    return node?.val == counterNode?.val;
}

private TreeNode GetCounterNode(TreeNode root, IList<bool> navigation)
{
    var counterNode = root;
    foreach (bool nav in navigation)
    {
        if (counterNode == null)
            break;
        if (nav)
        {
            counterNode = counterNode.left;
        }
        else
        {
            counterNode = counterNode.right;
        }
    }

    return counterNode;
}