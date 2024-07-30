namespace GE_240730_크루스칼
{
    internal class Program
    {
        public class Graph
        {
            private int iSize;
            private int iSum;
            private int[] aParent;
            public List<Edge> graph;

            public Graph(int size)
            {
                iSize = size;
                iSum = 0;
                aParent = new int[iSize];
                graph = new List<Edge>();

                for (int i = 0; i < iSize; i++)
                {
                    aParent[i] = i;
                }
            }

            // 간선
            public class Edge : IComparable<Edge>
            {
                private int x, y, distance;

                public Edge(int x, int y, int d)
                {
                    this.x = x;
                    this.y = y;
                    this.distance = d;
                }

                // "프로퍼티"로 설정
                public int iX
                {
                    get
                    {
                        return x;
                    }
                    set
                    {
                        x = value;
                    }
                }

                public int iY
                {
                    get
                    {
                        return y;
                    }
                    set
                    {
                        y = value;
                    }
                }

                public int iDistance
                {
                    get
                    {
                        return distance;
                    }
                    set
                    {
                        distance = value;
                    }
                }

                public int CompareTo(Edge? other)
                {
                    return distance.CompareTo(other?.iDistance);
                }
            }

            public void Insert(int x, int y, int distance)
            {
                graph.Add(new Edge(x, y, distance));
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
                }
                else
                {
                    aParent[iX] = iY;
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

            public void Kruskal()
            {
                graph.Sort();

                for (int i = 0; i < graph.Count; i++)
                {
                    if (Same(graph[i].iX, graph[i].iY) == false)
                    {
                        iSum += graph[i].iDistance;
                        Union(graph[i].iX, graph[i].iY);
                    }
                }
            }

            public void Show()
            {
                Console.WriteLine($"\n─『{graph.Count}』────────────────────────────────");
                for (int i = 0; i < graph.Count; i++)
                {
                    Console.WriteLine($"【{i}】 - Ｘ:{graph[i].iX}, Ｙ:{graph[i].iY}, Ｄ:{graph[i].iDistance}");
                }

                Console.WriteLine($"\n─『배열』────────────────────────────────");
                for (int i = 0; i < aParent.Length; i++)
                {
                    Console.WriteLine($"【{i}】Ｐ:{aParent[i]}");
                }

                Console.WriteLine($"\n─『가중치의 합 : {iSum}』────────────────────────────────");
            }
        }


        static void Main(string[] args)
        {
            #region 신장 트리 (Spanning Tree) - O( n log n )
            // 그래프의 모든 정점을 포함하면서 사이클이 존재하지 않는 그래프
            // 그래프의 모든 정점을 최소 비용으로 연결하는 트리

            // 그래프의 정점 수가 n개일 때, 간선의 수는 n-1개입니다.

            // 【최소 비용 신장 트리 (Minimum Spanning Tree)】
            // 그래프의 간선들의 가중치 합이 최소인 신장 트리
            #endregion

            int iInput = 8;
            Graph graph = new Graph(iInput);

            graph.Insert(1, 2, 73);
            graph.Insert(1, 4, 28);
            graph.Insert(1, 5, 17);
            graph.Insert(1, 7, 12);

            graph.Insert(2, 4, 24);
            graph.Insert(2, 5, 62);

            graph.Insert(3, 5, 20);
            graph.Insert(3, 6, 35);

            graph.Insert(4, 7, 13);

            graph.Insert(5, 6, 40);

            //Console.WriteLine($"\n─────────────────────────────────");

            graph.Kruskal();

            graph.Show();
        }
    }
}
