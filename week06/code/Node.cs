public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value == Data) { // no duplicates Problem 1
    
        return;
    }
        else if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value == Data) {
        // If the value is found, return true
        return true;
    } else if (value < Data) {
        // If the value is less than the current node's data, search the left subtree
        return Left != null && Left.Contains(value);
    } else {
        // If the value is greater than the current node's data, search the right subtree
        return Right != null && Right.Contains(value);
    }
    }

    public int GetHeight() {
        // TODO Start Problem 4
        if (Left == null && Right == null) {
        return 1;
    }

    // Recursively calculate the height of the left and right subtrees
    int leftHeight = Left?.GetHeight() ?? 0;
    int rightHeight = Right?.GetHeight() ?? 0;

    // The height of the tree is 1 plus the maximum height of its subtrees
    return 1 + Math.Max(leftHeight, rightHeight);
    }
}