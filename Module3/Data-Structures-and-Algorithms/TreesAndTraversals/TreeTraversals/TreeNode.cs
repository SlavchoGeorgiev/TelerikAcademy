namespace TreeTraversals
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class TreeNode<T>
        where T : IEquatable<T>
    {
        public TreeNode(T value)
        {
            this.Value = value;
            this.Children = new List<TreeNode<T>>();
        }

        public T Value { get; set; }

        public TreeNode<T> Parent { get; set; }

        public List<TreeNode<T>> Children { get; private set; }

        public bool IsLeaf
        {
            get { return this.Children.Count == 0; }
        }

        public bool IsRoot
        {
            get { return this.Parent == null; }
        }

        public TreeNode<T> Add(TreeNode<T> node)
        {
            this.Children.Add(node);

            return this;
        }

        public bool Contains(T value)
        {
            if (this.Value.Equals(value))
            {
                return true;
            }

            if (!this.IsLeaf)
            {
                foreach (var child in this.Children)
                {
                    if (child.Contains(value))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
