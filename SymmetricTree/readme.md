Just an idea to use a mirrorNode and doing the reverse operation on it improved
my initial solution in a great way. I think some ideas or getting used to is required
to solve these kind of problems.
Below is the pseudo code for the better solution.
```
function isSymmetric(root):
    if root is null:
        return true
    return isMirror(root.left, root.right)

function isMirror(leftNode, rightNode):
    if leftNode is null AND rightNode is null:
        return true
    if leftNode is null OR rightNode is null:
        return false
    if leftNode.value != rightNode.value:
        return false
    return isMirror(leftNode.left, rightNode.right) 
        AND isMirror(leftNode.right, rightNode.left)
```