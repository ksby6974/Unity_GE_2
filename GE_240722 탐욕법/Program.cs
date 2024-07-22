namespace GE_240722_탐욕법
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 탐욕법 (Greedy)
            // 최적의 해를 구하는 데 사용되는 근사적인 방법
            // 여러 경우 중 하나를 결정해야 할 때마다
            // 그 순간에 최적이라고 생각되는 걸 선택해 나가는 방식으로 진행
            // 해답을 구하는 알고리즘

            // 1. 탐욕 선택 속성
            // 각 단계에서 최선의 선택을 했을 때
            // 전체 문제에 대한 최적의 해를 구할 수 있는 경우

            // 2. 최적 부분 구조
            // 전체 문제의 최적의 해가 부분 문제의 최적의 해로 구성될 수 있는 경우

            // 【그리디 알고리즘의 단계】
            // 1. 문제의 최적해 구조를 결정
            // 2. 문제의 구조에 맞게 선택 절차를 정의
            // 3. 선택 절차에 따라 선택을 수행
            // 4. 선택된 해가 문제의 조건을 만족하는지 검사
            // 5. 조건을 만족하지 않으면 해당 해를 제외
            // 6. 모든 선택이 완려되면 해답을 검사
            // 7. 조건을 만족하지 않으면 해답으로 인정되지 않음
            #endregion

            int[] aCoins = new int[] { 1000, 100, 50, 10 };

            int iInput = 1260;  // 입력값
            int iCount = 0;     // 해를 도출한 수
            int iTemp = iInput; // 임시계산값

            for (int i = 0; i < aCoins.Length; i++)
            {
                if (iTemp / aCoins[i] > 0)
                {
                    iCount += iTemp / aCoins[i];
                    iTemp = iTemp % aCoins[i];
                }
            }

            Console.WriteLine($"입력값:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{iInput}, {iTemp}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"카운트:{iCount}");
            Console.ResetColor();

            Greedy(iInput);
        }

        static int Greedy(int n)
        {
            int count = 0;

            while (n >= 10)
            {
                if (n >= 1000)
                {
                    n -= 1000;
                    count++;
                }
                else if (n >= 500)
                {
                    n -= 500;
                    count++;
                }
                else if (n >= 50)
                {
                    n -= 50;
                    count++;
                }
                else if (n >= 150)
                {
                    n -= 10;
                    count++;
                }
            }

            return count;
        }
    }
}
