namespace GE_240729_위상정렬
{
    internal class Program
    {
        public class TSort
        {
            private int iSize;
            private int[] iDegree;
            private List<int>[] iList;

            public TSort(int size)
            {
                this.iSize = size;
                iDegree = new int[iSize];
                iList = new List<int>[iSize];

                for (int i = 0; i < iSize; i++)
                {
                    iList[i] = new List<int>();
                }
            }

            public void Insert(int vertex, int edge)
            {
                iList[vertex].Add(edge);

                // 진입차수 증가
                iDegree[edge] += 1;
            }

            public void Search()
            {
                Queue<int> iQueue = new Queue<int>();

                for (int i = 1; i < iSize; i++)
                {
                    if (iDegree[i] == 0)
                    {
                        iQueue.Enqueue(i);
                    }
                }

                Console.WriteLine($"\n─『탐색 {iQueue.Count}』─────────────────────");

                while (iQueue.Count > 0)
                {
                    int x = iQueue.Dequeue();

                    Console.Write($"【{x}】");

                    for (int i = 0; i < iList[x].Count; i++)
                    {
                        int start = iList[x][i];

                        iDegree[start]--;

                        if (iDegree[start] == 0)
                        {
                            iQueue.Enqueue(start);
                        }
                    }
                }
                Console.WriteLine($"");
            }

            public void Show()
            {
                Console.WriteLine($"\n─『진입차수』────────────────────────────────");
                for (int i = 0; i < iDegree.Length; i++)
                {
                    Console.WriteLine($"【{i}】:{iDegree[i]}");
                }

                Console.WriteLine($"\n─『연결된 간선』────────────────────────────────");
                for (int i = 0; i < iList.Length; i++)
                {
                    Console.Write($"【{i}】:");

                    for (int j = 0; j < iList[i].Count; j++)
                    {
                        Console.Write($"{iList[i][j]} ");
                    }

                    Console.WriteLine("");
                }
            }
        }

        static void Main(string[] args)
        {
            #region 위상 정렬 (Topological Sorting)
            // 방향 그래프에 존재하는 각 정점들의 선행 순서를 지키며 모든 정점을 차례대로 진행하는 알고리즘
            // ※ 사이클이 발생하는 경우 위상 정렬을 수행할 수 없습니다.

            // DAG(Directed Acyclic Graph) : 사이클이 존재하지 않는 그래프
            // 시간 복잡도 - O(V + E)

            // 위상정렬법
            // 1. 진입 치수가 0인 정점을 Queue에 삽입
            // 2. Queue에서 원소를 꺼내 연결된 모든 간선을 제거
            // 3. 간선 제거 후에 진입 차수가 0이 된 정점을 Queue에 삽입
            // 4. Queue가 비어있을 때까지 2~3번 반복 수행
            #endregion

            int iInput = 8;
            TSort sort = new TSort(iInput);

            sort.Insert(1, 2);
            sort.Insert(1, 5);

            sort.Insert(2, 3);
            sort.Insert(5, 6);

            sort.Insert(3, 4);
            sort.Insert(6, 4);

            sort.Insert(4, 7);
            sort.Show();



            sort.Search();
        }
    }
}
