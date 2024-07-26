namespace GE_240725_깊이우선탐색
{
    internal class Program
    {
        public class DPS
        {
            public bool[] visited;
            public int iSize;
            public List<int>[] graph;

            public DPS(int n)
            {
                iSize = n;
                visited = new bool[iSize];
                graph = new List<int>[iSize];


                for (int i = 0; i < graph.Length; i++)
                {
                    graph[i] = new List<int>();
                }
            }

            public void Insert(int vertex, int edge)
            {
                graph[vertex].Add(edge); // [1] -> 2 -> 3
                graph[edge].Add(vertex); // [2] -> 1
                                          // [3] -> 1
            }

            public void Search(int start)
            {
                // 1. 현재 노드를 방문한 것으로 표시.
                visited[start] = true;

                // 2. 현재 노드를 출력
                Console.WriteLine($"{start}번째 - {graph[start].Count}");

                // 3. 현재 노드와 연결된 다른 노드를 재귀적으로 방문
                for (int i = 0; i < graph[start].Count; i++)
                {
                    // 4. 현재 노드와 연결된 다음 노드를 가져옴.
                    int next = graph[start][i];

                    if (visited[next] == false)
                    {
                        // 5. 다음 노드가 방문하지 않은 노드라면 재귀함수를 호출
                        Search(next);
                    }
                }
            }

            public void Show()
            {
                Console.WriteLine($"크기 : {graph.Length}");

                for (int i = 0; i < graph.Length; i++)
                {
                    for (int j = 0; j < graph[i].Count; j++)
                    {
                        Console.Write($"{graph[i][j]} ");
                    }

                    Console.WriteLine("");
                }
            }
        }

        static void Main(string[] args)
        {
            #region 깊이 우선 탐색
            // root 노드에서 시작해서 다음 분기로 넘어가기 전에 해당 분기를 완벽하게 탐색하는 방법

            // 1. 시작 노드를 스택에 넣고 방문 처리함
            // 2. 스택의 최상단 노드에 방문하지 않은 인접 노드가 있으면 그 노드를 스택에 넣고 방문 처리
            // 3. 방문하지 않은 인접 노드가 없으면 스택에서 최상단 노드를 꺼냅니다.
            // 4. 더 이상 2번의 과정을 수행할 수 없을 때까지 반복

            #endregion

            DPS dps = new DPS(8);

            dps.Insert(1, 2);
            dps.Insert(1, 3);

            dps.Insert(2, 3);

            dps.Insert(2, 4);
            dps.Insert(2, 5);

            dps.Insert(3, 6);
            dps.Insert(3, 7);

            dps.Insert(4, 5);
            dps.Insert(6, 7);

            dps.Show();

            dps.Search(1);
        }
    }
}
