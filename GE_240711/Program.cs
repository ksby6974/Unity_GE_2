namespace GE_240711
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyAnswer();
            HisAnswer();

            void MyAnswer()
            {
                // 1. 비밀번호 세자리 설정
                // 2. 내가 설정한 비밀번호를 찾는 알고리즘
                int iCheck = 0;
                int iLimit = 10;
                int iTemp = 0;
                int[] iPW = new int[3];

                // 비밀번호 설정
                iPW[0] = 3;
                iPW[1] = 5;
                iPW[2] = 7;

                // 반복 : 복잡도 O(N)
                while (iCheck < 3)
                {
                    iTemp = iPW[iCheck];

                    for (int i = 0; i < iLimit; i++)
                    {
                        if (iTemp == i)
                        {
                            Console.WriteLine($"{iCheck + 1}번째 비밀번호 : {iTemp}");
                            iCheck++;
                        }
                    }
                }

                Console.WriteLine("다 찾았습니다.");
            }

            void HisAnswer()
            {
                // 브루트 포스 알고리즘
                int[] password = new int[3];
                password[0] = 3;
                password[1] = 5;
                password[2] = 7;

                // 복잡도 N^3
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            if (password[0] == i && password[1] == j && password[2] == k)
                            {
                                Console.WriteLine($"다 찾았습니다. : {password[0]}, {password[1]}, {password[2]}");
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
