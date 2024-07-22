namespace GE_240722_최장증가부분수열
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 최장 증가 부분 수열
            // 원소가 n개인 배열의 일부 원소를 골라내서 만든 부분 수열 중
            // 각 원소가 이전 원소보다 크다는 조건을 만족하고 그 길이가 최대인 부분 수열 

            // 주어진 배열에서 인덱스를 한칸씩 늘려가며 확인
            // 내부 반복문으로 i보다 작은 인덱스들을 하나씩 살펴보면서
            // aArray[i] > aArray[j]일 경우 count 배열을 업데이트

            // 1. LIS의 첫번째는 항상 1부터 시작
            // 2. 2보다 작은 이전의 인덱스가 없으므로 count 배열의 [i]에 값을 1 저장
            // 3. 4보다 작은 이전 이전 인덱스 array[i] 가장 큰 count 배열의 값은 1이므로 count 배열 [i]에 1+1 = 2로 만듬
            // 4. 1보다 작은 이전 인덱스가 없으므로 count 배열[i]의 값에 1을 저장
            // 5. 6보다 작은 이전 이전 인덱스 array[i] 배열 중 가장 큰 값 count배열 값은 2이므로
            // count[i]의 값에 2 + 1 = 3으로 만들어 줌

            // 업데이트 기준
            // 1. j번째 인덱스에서 끝나는 최장 증가 부분 수열의 마지막에 array[i]를 추가했을 때 LIST 길이
            // 2. 추가하지 않고 기존의 count 배열 [i]의 값


            #endregion

            int[] aArray = new int[] { 3, 2, 4, 1, 6 };
            int[] iCount = new int[aArray.Length];

            iCount[0] = 1;

            for (int i = 1; i < aArray.Length; i++)
            {
                // 첫 원소부터 i 원소 전까지 비교합니다.
                for (int j = 0; j < i; j++)
                {
                    if (aArray[i] > aArray[j])
                    {
                        iCount[i] = Math.Max(iCount[i], iCount[j] + 1);
                    }

                    // 증가 부분 수열의 길이는 1부터 시작하므로 0인 값을 1로 저장합니다.
                    if (iCount[i] == 0)
                    {
                        iCount[i] = 1;
                    }
                }
            }

            Console.WriteLine($"결과 :");
            for (int i = 0; i < iCount.Length; i++)
            {
                Console.Write($"{iCount[i]} ");
            }
        }
    }
}
