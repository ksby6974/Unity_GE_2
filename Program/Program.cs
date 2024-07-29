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
using System.Xml.Schema;
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
        public class Graph
        {
            private int iSize;
            private int[] aParent;
            private List<int>[] Node;

            public Graph(int size)
            {
                iSize = size;
                aParent = new int[iSize];
                Node = new List<int>[iSize];

                for (int i = 0; i < iSize; i++)
                {
                    aParent[i] = i;
                    Node[i] = new List<int>();
                }
            }

            public void Union(int x, int y)
            {
                int iX = Find(x);
                int iY = Find(y);

                if (Same(iX, iY))
                {
                    return;
                }

                if (iX < iY)
                {
                    aParent[iY] = iX;
                    Node[iY].Add(iX);
                }
                else
                {
                    aParent[iX] = iY;
                    Node[iX].Add(iY);
                }
            }

            public int Find(int x)
            {
                if (aParent[x] == x)
                {
                    return x;
                }
                else
                {
                    return aParent[x] = Find(aParent[x]);
                }
            }

            public bool Same(int x, int y)
            {
                return Find(x) == Find(y);
            }

            public void Show()
            {
                Console.WriteLine($"\n─『배열』────────────────────────────────");
                for (int i = 0; i < iSize; i++)
                {
                    Console.WriteLine($"【{i}】 - {aParent[i]}");
                }

                Console.WriteLine($"\n─『간선』────────────────────────────────");
                for (int i = 0; i < iSize; i++)
                {
                    Console.WriteLine($"【{i}】 - {Node[i].Count}");
                }
            }
        }
        

        static void Main(string[] args)
        {
            #region 유니온 파인드 (Union Find)
            // 여러 노드가 존재할 때 어떤 두 개의 노드를 같은 집합으로 묶은 다음
            // 어떤 두 노드가 같은 집합에 있는지 확인하는 알고리즘

            // 1.
            // 2.
            // 3.
            // 4.
            #endregion

            int iInput = 8;
            Graph graph = new Graph(iInput);

            graph.Union(2, 3);
            graph.Union(1, 3);

            Console.WriteLine($"{graph.Same(2, 3)}");
            Console.WriteLine($"{graph.Same(1, 3)}");
            Console.WriteLine($"{graph.Same(4, 5)}");

            graph.Show();
        }
    }
}
