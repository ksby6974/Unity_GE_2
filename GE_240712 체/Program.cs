using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace GE_240712_체
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 에라토스테네스의 체
            // 소수를 판정하는 방법으로, 자연수를 순서대로 늘어놓은 표에서
            // 합성수를 차례대로 지워나가면서 소수의 목록을 얻어내는 방법
            #endregion

            MyAnswer();
            Console.WriteLine($"\n─────────────────────\n");
            HisAnswer();

            void MyAnswer()
            {
                int iLimit = 49;
                int[] iArray = new int[iLimit];

                // 값 할당
                for (int i = 0; i < iLimit; i++)
                {
                    iArray[i] = i;
                }

                // 반복
                int iCount = 1;
                while (iCount < iLimit)
                {
                    for (int i = 2; i < 10; i++)
                    {
                        if ((i != iCount) && (iArray[iCount] % i == 0))
                        {
                            iArray[iCount] = 0;
                        }
                    }

                    iCount += 1;
                }

                Console.WriteLine($"걸러낸 값 : ");
                for (int i = 2; i < iLimit; i++)
                {
                    if (iArray[i] > 0)
                    {
                        Console.Write($" {iArray[i]}");
                    }
                }
            }
           
            void HisAnswer()
            {

                Sieve(49);
            }

            static void Sieve(int n)
            {
                int[] array = new int[n + 1];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = i;
                }

                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (array[i] == 0)
                    {
                        continue;
                    }

                    for(int j = i * 2; j <= n; j += 1)
                    {
                        array[j] = 0;
                    }
                }

                Console.WriteLine($"걸러낸 값2 :");
                for (int i = 2; i <= n; i++)
                {
                    if (array[i] != 0)
                    {
                        Console.Write($" {array[i]}");
                    }
                }
            }
        }
    }
}
