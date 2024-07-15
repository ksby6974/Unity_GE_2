namespace GE_240712_선택정렬
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 선택정렬
            // 주어진 리스트 중에 최소값을 찾아서 맨앞에 위치한 결과를
            // 교체하는 방식으로 정렬하는 알고리즘
            #endregion

            int[] iArray = new int[] { 6, 3, 7, 9, 5 };

            for (int i = 0; i < iArray.Length - 1; i++)
            {
                int iMin = iArray[i];
                int iSelect = i;

                for (int j = i + 1; j < iArray.Length - 1; j++)
                {
                    if (iMin > iArray[j])
                    {
                        iMin = iArray[j];
                        iSelect = j;
                    }
                }

                int iTemp = iArray[i];
                iArray[i] = iArray[iSelect];
                iArray[iSelect] = iTemp;
            }

            Console.WriteLine($"정렬된 배열 : ");
            for (int i = 0; i < iArray.Length; i++)
            {
                Console.Write($"［{iArray[i]}］");
            }
        }
    }
}
