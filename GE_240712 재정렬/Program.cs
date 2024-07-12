namespace GE_240712_재정렬
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 거품 정렬
            //
            #endregion
            MyAnswer();
            Console.WriteLine($"\n─────────────────");
            HisAnswer();
        }

        static void MyAnswer()
        {
            int[] iArray = new int[] { 32, 7, 1, 29, 5 };
            int iCount = 1;

            while (iCount > 0)
            {
                iCount = 0;

                for (int i = 0; i < iArray.Length - 1; i++)
                {
                    int iTemp;

                    if (iArray[i] > iArray[i + 1])
                    {
                        iTemp = iArray[i + 1];
                        iArray[i + 1] = iArray[i];
                        iArray[i] = iTemp;
                        iCount = 1;
                        break;
                    }
                }
            }

            Console.WriteLine($"정렬된 배열 : ");
            for (int i = 0; i < iArray.Length; i++)
            {
                Console.Write($"［{iArray[i]}］");
            }
        }

        static void HisAnswer()
        {
            int[] iArray = new int[] { 32, 7, 1, 29, 5 };

            for (int i = 0; i < iArray.Length - 1; i++)
            {
                for (int j = 0; j < iArray.Length - 1; j++)
                {
                    if (iArray[j] > iArray[j + 1])
                    {
                        int temp = iArray[j];
                        iArray[j] = iArray[j + 1];
                        iArray[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine($"정렬된 배열 : ");
            for (int i = 0; i < iArray.Length; i++)
            {
                Console.Write($"［{iArray[i]}］");
            }
        }
    }
}
