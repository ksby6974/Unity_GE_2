using System.ComponentModel.Design;

namespace Program
{
    #region 시간 복잡도
    // 특정 크기의 입력을 기준으로 필요한 연산 횟수
    #endregion

    #region 상수 시간 0 (1)
    // 입력 크기와 상관없이 일정한 시간 복잡도를 가지는 시간
    // ex) 배열의 인덱스 참조
    #endregion

    #region 선형 시간 0 (n)

    #endregion

    #region 로그 시간 0 (log n)
    // 데이터의 크기에 따라 실행 시간이 로그 함수의 형태로 증가하는 시간 복잡도
    // ex) 이진 탐색 트리
    #endregion

    #region 제곱 시간 0 (n^2)
    // 입력되는 데이터들 기준으로 n^2 만큼의 시간이 증가되는 시간 복잡도
    #endregion

    #region 공간 복잡도
    // 프로그램 실행과 완료에 얼마나 많은 공간이 필요한가 나타내는 척도
    #endregion

    #region 고정 공간
    // 코드가 저장되는 공간으로 알고리즘 실행을 위해 시스템이 필요로 하는 공간
    // ex) 배열
    #endregion

    #region 가변 공간
    // 문제를 해결하기 위해 알고리즘이 필요한 공간.
    // 순환 프로그램일 경우 순환 스택 의미
    #endregion

    #region 브루트 포스(Brute Force)
    // 가능한 모든 경우의 수를 탐색하면서 결과를 도출하는 알고리즘
    #endregion

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
