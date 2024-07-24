using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Transactions;

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
        public class HNTower
        {
            public int iSize = 0;
            public int[] iArray;

            public HNTower(int size)
            {
                this.iSize = 0;
                this.iArray = new int[size];
            }

            public void Pop()
            {
                if (iSize <= 0)
                {
                    Console.WriteLine($"Empty.");
                }
                else
                {
                    iArray[iSize--] = 0;
                }
            }

            public void Input(int x)
            {
                if (iSize >= iArray.Length)
                {
                    Console.WriteLine($"Full.");
                }
                else
                {
                    iArray[iSize++] = x;
                }
            }

            public void Draw(int x)
            {
                if (x > 0)
                {
                    Console.Write($"■\t");
                }
                else
                {
                    Console.Write($"□\t");
                }
            }
        }

        static void Main(string[] args)
        {
            #region 백트래킹
            // 해를 찾는 도중 지금의 경로가 해가 될 것 가지 않으면 더 이상 들어가지 않고 이전 단계로 되돌아가는 알고리즘
            // 해가 될 것인가 판단한 후 유망하지 않다고 결정되면 그 노드의 이전 노드로 돌아가 다음 자식 노드로 이동
            // 해가 될 것 같은 가능성이 유망(=Promising)
            // 해가 될 가능성이 유망하지 않은 노드에 가지 않는 것(=Pruning)

            // 한번에 하나의 원판만 이동
            // 맨 위에 있는 원판만 이동
            // 크기가 작은 원판 위에 큰 원판을 쌓을 수 있음
            #endregion

            int iSize = 3;
            HNTower Pole1 = new HNTower(iSize);
            HNTower Pole2 = new HNTower(iSize);
            HNTower Pole3 = new HNTower(iSize);
            Pole1.Input(1);
            Pole1.Input(1);
            Pole1.Input(1);

            Hanoi(3,'A','B','C');

            Console.WriteLine($"\n───────────────────────────────────────");
            for (int i = 0; i < iSize; i++)
            {
                Pole1.Draw(Pole1.iArray[i]);
                Pole2.Draw(Pole2.iArray[i]);
                Pole3.Draw(Pole3.iArray[i]);
                Console.WriteLine($"");
            }

            //Console.WriteLine($"{GetGCD(78696, 19332)}");
        }  

        // 하노이의 탑
        // n : 고리의 수
        // from : 시작점
        // by : 이용
        // to : 도착점
        static public void Hanoi(int n, char from, char by, char to)
        {
            if (n == 1)
            {
                Console.WriteLine($"【{n}】:{from},{by},{to}");
                return;
            }
            else
            {
                Hanoi(n - 1, from, by, to);
                Console.WriteLine($"【{n}】:{from},{by},{to}");
                Hanoi(n - 1, by, to, from);
            }
            
        }
    }
}
