namespace GE_240730_유니온_파인트
{
    internal class Program
    {
        public class Graph
        {
            private int iSize;
            private int[] aParent;
            private List<int>[] Node;

            public Graph(int size)
            {
                iSize = size;
                aParent = new int[iSize];
                Node = new List<int>[iSize];

                for (int i = 0; i < iSize; i++)
                {
                    aParent[i] = i;
                    Node[i] = new List<int>();
                }
            }

            public void Union(int x, int y)
            {
                int iX = Find(x);
                int iY = Find(y);

                if (Same(iX, iY))
                {
                    return;
                }

                if (iX < iY)
                {
                    aParent[iY] = iX;
                    Node[iY].Add(iX);
                }
                else
                {
                    aParent[iX] = iY;
                    Node[iX].Add(iY);
                }
            }

            public int Find(int x)
            {
                if (aParent[x] == x)
                {
                    return x;
                }
                else
                {
                    return aParent[x] = Find(aParent[x]);
                }
            }

            public bool Same(int x, int y)
            {
                return Find(x) == Find(y);
            }

            public void Show()
            {
                Console.WriteLine($"\n─『배열』────────────────────────────────");
                for (int i = 0; i < iSize; i++)
                {
                    Console.WriteLine($"【{i}】 - {aParent[i]}");
                }

                Console.WriteLine($"\n─『간선』────────────────────────────────");
                for (int i = 0; i < iSize; i++)
                {
                    Console.WriteLine($"【{i}】 - {Node[i].Count}");
                }
            }
        }


        static void Main(string[] args)
        {
            #region 유니온 파인드 (Union Find)
            // 여러 노드가 존재할 때 어떤 두 개의 노드를 같은 집합으로 묶은 다음
            // 어떤 두 노드가 같은 집합에 있는지 확인하는 알고리즘

            // 1.
            // 2.
            // 3.
            // 4.
            #endregion

            int iInput = 8;
            Graph graph = new Graph(iInput);

            graph.Union(2, 3);
            graph.Union(1, 3);

            Console.WriteLine($"{graph.Same(2, 3)}");
            Console.WriteLine($"{graph.Same(1, 3)}");
            Console.WriteLine($"{graph.Same(4, 5)}");

            graph.Show();
        }
    }
}
