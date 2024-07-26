using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Transactions;
using static Program.Program;
using static System.Net.Mime.MediaTypeNames;

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
        public class TSort
        {
            private int iSize;
            private int[] iDegree;
            private List<int>[] iList;
            private Queue<int> iQueue;

            public TSort(int size)
            {
                this.iSize = size;
                iDegree = new int[iSize];
                iList = new List<int>[iSize];
                iQueue = new Queue<int>();

                for (int i = 0; i < iSize; i++)
                {
                    iList[i] = new List<int>();
                }
            }

            public void Insert(int vertex, int edge)
            {
                iList[vertex].Add(edge);

                // 진입차수 증가
                iDegree[edge] += 1;
            }

            public void Search(int start)
            {
                iQueue.Enqueue(start);

                Console.WriteLine($"\n─『탐색 {iQueue.Count}』─────────────────────");

                while (iQueue.Count > 0)
                {
                    int x = iQueue.Dequeue();

                    Console.Write($"【{x}】:");

                    for (int i = 0; i < iDegree[i]; i++)
                    {
                        int next = iList[x][i];

                        iQueue.Enqueue(next);
                    }
                    Console.WriteLine($"");
                }
            }

            public void Show()
            {
                Console.WriteLine($"\n─『진입차수』────────────────────────────────");
                for (int i = 0; i < iDegree.Length; i++)
                {
                    Console.WriteLine($"【{i}】:{iDegree[i]}");
                }

                Console.WriteLine($"\n─『연결된 간선』────────────────────────────────");
                for (int i = 0; i < iList.Length; i++)
                {
                    Console.Write($"【{i}】:");

                    for (int j = 0; j < iList[i].Count; j++)
                    {
                        Console.Write($"{iList[i][j]} ");
                    }

                    Console.WriteLine("");
                }
            }
        }

        static void Main(string[] args)
        {
            #region 위상 정렬 (Topological Sorting)
            // 방향 그래프에 존재하는 각 정점들의 선행 순서를 지키며 모든 정점을 차례대로 진행하는 알고리즘
            // ※ 사이클이 발생하는 경우 위상 정렬을 수행할 수 없습니다.

            // DAG(Directed Acyclic Graph) : 사이클이 존재하지 않는 그래프
            // 시간 복잡도 - O(V + E)

            // 위상정렬법
            // 1. 진입 치수가 0인 정점을 Queue에 삽입
            // 2. Queue에서 원소를 꺼내 연결된 모든 간선을 제거
            // 3. 간선 제거 후에 진입 차수가 0이 된 정점을 Queue에 삽입
            // 4. Queue가 비어있을 때까지 2~3번 반복 수행
            #endregion

            int iInput = 8;
            TSort sort = new TSort(iInput);

            sort.Insert(1, 2);
            sort.Insert(1, 5);

            sort.Insert(2, 3);
            sort.Insert(5, 6);

            sort.Insert(3, 4);
            sort.Insert(6, 4);

            sort.Insert(4, 7);
            sort.Show();



            sort.Search(1);
        }
    }
}
