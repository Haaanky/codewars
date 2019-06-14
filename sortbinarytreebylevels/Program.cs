using System;
using System.Collections.Generic;

namespace sortbinarytreebylevels
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata.TreeByLevels(null);
            foreach (var item in Kata.TreeByLevels(new Node(new Node(null, new Node(null, null, 4), 2), new Node(new Node(null, null, 5), new Node(null, null, 6), 3), 1)))
            {
                Console.Write(item);
            }
        }
    }
    class Kata
    {
        public static List<int> TreeByLevels(Node node)
        {
            var result = new List<int>();
            if (node != null)
                foreach (var item in TraverseBreadthFirst(node, FindLevel))
                {
                    result.Add(item.Value);
                }
            return result;
        }

        private static IEnumerable<Node> FindLevel(Node node)
        {
            if (node.Left != null)
                yield return node.Left;
            if (node.Right != null)
                yield return node.Right;

            yield break;
        }
        public static IEnumerable<T> TraverseBreadthFirst<T>(T root, Func<T, IEnumerable<T>> childrenSelector)
        {
            if (childrenSelector == null) throw new ArgumentNullException(nameof(childrenSelector));

            return _(); IEnumerable<T> _()
            {
                var queue = new Queue<T>();
                queue.Enqueue(root);

                while (queue.Count != 0)
                {
                    var current = queue.Dequeue();
                    yield return current;
                    foreach (var child in childrenSelector(current))
                        queue.Enqueue(child);
                }
            }
        }
    }
    public class Node
    {
        public Node Left;
        public Node Right;
        public int Value;

        public Node(Node l, Node r, int v)
        {
            Left = l;
            Right = r;
            Value = v;
        }
    }
}
