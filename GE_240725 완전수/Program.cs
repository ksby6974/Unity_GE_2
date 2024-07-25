namespace GE_240725_완전수
{
    internal class Program
    {
        // 유상우
        static void Main(string[] args)
        {
            #region 완전수 여부
            // 완전수 : 해당 수의 약수를 전부 합하면 해당 수가 되는 수.
            // ex) 6 = 1 + 2 + 3
            #endregion

            Console.Write($"수를 입력해주세요 : ");
            int iInput = int.Parse(Console.ReadLine());
            Console.WriteLine($"");

            PerfectNumber(iInput);
        }

        static public void PerfectNumber(int n)
        {
            // 합
            int iSum = 0;
            int iCount = 1;

            // 약수 구하기
            while (iCount < n)
            {
                // 약수
                if (n % iCount == 0)
                {
                    iSum += iCount;
                }

                iCount++;
            }


            // 결과
            if (n == iSum)
            {
                Console.WriteLine($"입력값 {n}은 완전수. (={iSum})");
            }
            else
            {
                Console.WriteLine($"입력값 {n}은 완전수가 아님. (={iSum})");
            }
        }
    }
}
