namespace GE_240725_하노이의_탑
{
    internal class Program
    {
        public class HNTower
        {
            public class Pole
            {
                public int iSize = 0;
                public int[]? iArray;

                public Pole(int size)
                {
                    this.iSize = 0;
                    int[] iArray = new int[size];
                    Console.WriteLine($"생성 {size}");
                }

                public void Pop()
                {
                    if (iSize <= 0)
                    {
                        Console.WriteLine($"Empty.");
                    }
                    else
                    {
                        iArray[iSize--] = 0;
                    }
                }

                public void Input(int x)
                {
                    if (iSize >= iArray?.Length)
                    {
                        Console.WriteLine($"Full.");
                    }
                    else
                    {
                        iArray[iSize++] = x;
                    }
                }
            }

            public Pole p1;
            public Pole p2;
            public Pole p3;

            public HNTower(int size)
            {
                p1 = new Pole(size);
                p2 = new Pole(size);
                p3 = new Pole(size);
            }

            public void Input()
            {

            }

            public void Draw(int x)
            {
                if (x > 0)
                {
                    Console.Write($"■\t");
                }
                else
                {
                    Console.Write($"□\t");
                }
            }
        }


        static void Main(string[] args)
        {
            #region 백트래킹
            // 해를 찾는 도중 지금의 경로가 해가 될 것 가지 않으면 더 이상 들어가지 않고 이전 단계로 되돌아가는 알고리즘
            // 해가 될 것인가 판단한 후 유망하지 않다고 결정되면 그 노드의 이전 노드로 돌아가 다음 자식 노드로 이동
            // 해가 될 것 같은 가능성이 유망(=Promising)
            // 해가 될 가능성이 유망하지 않은 노드에 가지 않는 것(=Pruning)

            // 한번에 하나의 원판만 이동
            // 맨 위에 있는 원판만 이동
            // 크기가 작은 원판 위에 큰 원판을 쌓을 수 있음
            #endregion

            int iSize = 3;
            HNTower Tower = new HNTower(iSize);

            for (int i = 0; i < iSize; i++)
            {
                // Tower.Draw(Pole1.iArray[i]);
                Console.WriteLine($"");
            }

            //Console.WriteLine($"{GetGCD(78696, 19332)}");


            Console.WriteLine($"\n───────────────────────────────────────");
            HanoiTower(3, 'A', 'B', 'C');
        }

        // 하노이의 탑
        // n : 고리의 수
        // from : 시작점
        // by : 이용
        // to : 도착점
        static public void HanoiTower(int n, char from, char by, char to)
        {
            if (n == 1)
            {
                Console.WriteLine($"[{n}] {from} → {to}");
            }
            else
            {
                HanoiTower(n - 1, from, to, by);
                Console.WriteLine($"[{n}] {from} → {to}");
                HanoiTower(n - 1, by, from, to);
            }

        }
    }
}
