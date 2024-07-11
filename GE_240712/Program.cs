namespace GE_240712
{
    #region 에라토스테네스의 체
    // 소수를 판정하는 방법으로, 자연수를 순서대로 늘어놓은 표에서
    // 합성수를 차례대로 지워나가면서 소수의 목록을 얻어내는 방법
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            MyAnswer();


            void MyAnswer()
            {
                // 합성수 찾기
                // 1보다 큰 자연수 중에서 소수가 아닌 수
                // 약수가 3개 이상인 수
                Console.WriteLine("값을 입력해주세요:");

                int iInput = 4;

                //int iInput = Console.ReadKey();

                if (iInput < 1)
                {
                    Console.WriteLine($"{iInput} 입력값은 1보다 작습니다.");
                }
                else
                {
                    // 소수인가?
                    if (isPrime(iInput) == true)
                    {
                        Console.WriteLine($"{iInput} 입력값은 소수입니다.");
                    }
                    else
                    {
                        int iCount = 0;

                        for (int i = 1; i <= iInput; i++)
                        {
                            if (iInput % i == 0)
                            {
                                iCount++;
                            }
                        }

                        // 반복 중지
                        if (iCount >= 3)
                        {
                            Console.WriteLine($"입력값 {iInput}은 합성수입니다.");
                        }
                        else
                        {
                            Console.WriteLine($"입력값 {iInput}은 합성수가 아닙니다. （{iCount}）");
                        }
                    }
                }
            }


            bool isPrime(int value)
            {
                while (value > 1)
                {
                    for (int i = 2; i < value; i++)
                    {
                        if (value % i == 0)
                        {
                            return false;
                        }
                    }

                    break;
                }

                return true;
            }
        }
    }
}
