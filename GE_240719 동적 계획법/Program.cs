namespace GE_240719_동적_계획법
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 동적 계획법
            // 특정 범위까지의 값을 구하기 위해서 그것돠 다른 범위까지의 값을 이용
            // 효율적으로 값을 구하는 알고리즘

            // 【메모이제이션】
            // 프로그램이 동일한 계산을 반복해야할 때 이전에 계산한 값을 메모리에 저장함으로써
            // 동일한 계산을 반복수행하는 작업을 제거하여 프로그램의 실행속도를 향상시키는 기법

            // 피보나치 수열
            // F(n - 1) + F(n + 1)
            #endregion

            int[] iArray = new int[10000];


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"피보나치 : {Fibonacci(45, iArray)}");
            Console.ResetColor();
        }

        static public int Fibonacci(int n, int[] iList)
        {
            if (n <= 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }

            if (iList[n] != 0)
            {
                return iList[n];
            }

            return iList[n] = Fibonacci(n - 1, iList) + Fibonacci(n - 2, iList);
        }
    }
}
