namespace TreeTraversals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using Microsoft.Win32;

    public class Startup
    {
        public static void Main()
        {
/* Example user input:
7
2 4
3 2
5 0
3 5
5 6
5 1
*/

/* Example user input:
9
2 4
3 2
5 0
3 5
5 6
5 1
1 7
7 8
*/

            TreeNode<int> rootNode = BuildTreeFromUserInput();
            Console.WriteLine("The root is: {0}", rootNode.Value);

            Console.WriteLine("All leaf nodes are: {0}", string.Join(", ", GetLeafNodes(rootNode)));

            Console.WriteLine("All middle nodes are: {0}", string.Join(", ", GetMidelNodes(rootNode)));

            Console.WriteLine("The longest path in the tree is: {0}", GetLongestPath(rootNode));

            var s = 9;
            Console.WriteLine("All paths in the three with sum {0} of their nodes are:", s);
            var paths = GetAllPathsWithSum(rootNode, s);

            foreach (var path in paths)
            {
                Console.Write("Path: ");
                foreach (var value in path)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
        }

        private static List<List<int>> GetAllPathsWithSum(TreeNode<int> node, int s)
        {
            return GetAllPathsWithSum(node, s, new List<List<int>>(), new Stack<int>());
        }

        private static List<List<int>> GetAllPathsWithSum(TreeNode<int> node,  int s, List<List<int>> listOfPaths, Stack<int> currentPath,  int currentSum = 0)
        {
            currentSum += node.Value;
            currentPath.Push(node.Value);
            if (currentSum == s)
            {
                var currentPathList = currentPath.ToList();
                currentPathList.Reverse();
                listOfPaths.Add(currentPathList);
                currentPath.Pop();
                return listOfPaths;
            }

            foreach (var treeNode in node.Children)
            {
                GetAllPathsWithSum(treeNode, s, listOfPaths, currentPath, currentSum);
            }

            currentPath.Pop();
            return listOfPaths;
        }

        public static int GetLongestPath(TreeNode<int> node, int length = 0, int maxValue = 0)
        {
            if (node != null)
            {
                length++;
            }
            
            foreach (var treeNode in node.Children)
            {
                maxValue = GetLongestPath(treeNode, length, maxValue);
            }

            if (node.IsLeaf && maxValue < length )
            {
                maxValue = length;
            }

            return maxValue;
        }

        private static List<int> GetLeafNodes(TreeNode<int> root)
        {
            var result = new List<int>();
            if (root.IsLeaf)
            {
                result.Add(root.Value);
            }

            foreach (var child in root.Children)
            {
                result = result.Union(GetLeafNodes(child)).ToList();
            }

            return result;
        }

        private static List<int> GetMidelNodes(TreeNode<int> root)
        {
            var result = new List<int>();
            if (!root.IsLeaf && !root.IsRoot)
            {
                result.Add(root.Value);
            }

            foreach (var child in root.Children)
            {
                result = result.Union(GetMidelNodes(child)).ToList();
            }

            return result;
        }

        public static TreeNode<int> BuildTreeFromUserInput()
        {
            Console.Write("Please enter nodes number N: ");
            var nodesNumber = int.Parse(Console.ReadLine());

            var nodes = new List<TreeNode<int>>();

            for (int i = 0; i < nodesNumber - 1; i++)
            {
                var pair = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var parentValue = int.Parse(pair[0]);
                var childValue = int.Parse(pair[1]);

                if (nodes.Any(n => n.Value == parentValue) && nodes.Any(n => n.Value == childValue))
                {
                    var parent = nodes.Find(p => p.Value == parentValue);
                    var child = nodes.Find(c => c.Value == childValue);

                    parent.Add(child);
                    child.Parent = parent;
                }
                else if (nodes.Any(n => n.Value == parentValue))
                {
                    var parent = nodes.Find(p => p.Value == parentValue);
                    var child = new TreeNode<int>(childValue);

                    parent.Add(child);
                    child.Parent = parent;
                    nodes.Add(child);
                }
                else if (nodes.Any(n => n.Value == childValue))
                {
                    var parent = new TreeNode<int>(parentValue);
                    var child = nodes.Find(p => p.Value == childValue);

                    parent.Add(child);
                    child.Parent = parent;
                    nodes.Add(parent);
                }
                else
                {
                    var parent = new TreeNode<int>(parentValue);
                    var child = new TreeNode<int>(childValue);

                    parent.Add(child);
                    child.Parent = parent;

                    nodes.Add(parent);
                    nodes.Add(child);
                }
            }

            return nodes.FirstOrDefault(n => n.IsRoot);
        }
    }
}
