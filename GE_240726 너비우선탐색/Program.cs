namespace GE_240726_너비우선탐색
{
    internal class Program
    {
        public class BPS
        {
            public bool[] visited;
            public int iSize;
            private Queue<int> iQueue;
            private List<int>[] iList;

            public BPS(int n)
            {
                iSize = n;
                visited = new bool[iSize];
                iQueue = new Queue<int>();
                iList = new List<int>[iSize];

                for (int i = 0; i < iSize; i++)
                {
                    iList[i] = new List<int>();
                }
            }

            public void Insert(int vertex, int edge)
            {
                iList[vertex].Add(edge);
                iList[edge].Add(vertex);
            }

            public void Search(int start)
            {
                iQueue.Enqueue(start);
                visited[start] = true;

                while (iQueue.Count > 0)
                {
                    int x = iQueue.Dequeue();

                    Console.Write($"{x} 탐색:");

                    for (int i = 0; i < iList[x].Count; i++)
                    {
                        int next = iList[x][i];

                        if (visited[next] == false)
                        {
                            iQueue.Enqueue(next);
                            visited[next] = true;
                        }
                    }

                    Console.WriteLine($"");
                }
            }

            public void Show()
            {
                Console.WriteLine($"\n─『연결된 간선 : {iList.Length}』────────────────────────────────");
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
            #region 너비 완전 탐색 (BPS)
            // 
            #endregion

            int iInput = 8;
            BPS bps = new BPS(iInput);

            bps.Insert(1, 2);
            bps.Insert(1, 3);

            bps.Insert(2, 3);
            bps.Insert(2, 4);
            bps.Insert(2, 5);

            bps.Insert(3, 6);
            bps.Insert(3, 7);

            bps.Insert(4, 5);

            bps.Insert(6, 7);

            bps.Search(4);

            bps.Show();
        }
    }
}
