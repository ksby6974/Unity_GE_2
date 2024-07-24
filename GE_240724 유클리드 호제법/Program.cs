namespace GE_240724_유클리드_호제법
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 유클리드 호제법
            // 2개의 자연수 또는 정식의 최대공약수를 구하는 알고리즘
            // 두 수가 서로 상대방 수를 나누어서 원하는 수를 얻어내는 알고리즘
            #endregion

            Console.WriteLine($"{GetGCD(78696, 19332)}");
            Console.WriteLine($"{GetLCM(78696, 19332)}");
        }

        // 최대 공약수
        static int GetGCD(int iA, int iB)
        {
            int iCount = 1;
            int iResult = 0;
            Console.Write($"{iA}와 {iB}의 최대 공약수:");

            while (iA >= iCount || iB >= iCount)
            {
                if ((iA % iCount == 0) && (iB % iCount == 0))
                {
                    iResult = iCount;
                }
                iCount++;
            }

            return iResult;
        }

        static int GetGCD_Math(int iA, int iB)
        {
            int iResult = 0;

            for (int i = 1; i <= Math.Min(iA, iB); i++)
            {
                if (iA % i == 0 && iB % i == 0)
                {
                    iResult = i;
                }
            }

            return iResult;
        }

        static int GetLCM(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }
            else
            {
                return GetLCM(x, x % y);
            }
        }
    }
}
