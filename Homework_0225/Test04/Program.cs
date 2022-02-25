//如果矩阵上每一条由左上到右下的对角线上的元素都相同，那么这个矩阵是托普利茨矩阵。
//给定一个 M x N 的矩阵，当且仅当它是托普利茨矩阵时返回 True。

using System;

namespace Test04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix= { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            Console.WriteLine(Solution.IsToplitz(matrix));
        }

        class Solution
        {
            public static bool IsToplitz(int[,] matrix)
            {
                int rows = matrix.GetLength(0);//3
                int columns = matrix.GetLength(1);//4
                if(rows == 0 && columns == 0)
                    return false;

                for (int i = 0; i < rows; i++) 
                {
                    int current = matrix[i, 0];//[2,0]
                    for(int j = 1; i + j < rows && j < columns; ++j)
                    {
                        if (matrix[i + j, j] != current)
                            return false;
                    }
                }
                for (int i = 1; i < columns; i++)
                {
                    int current = matrix[0, i];
                    for (int j = 1; i + j < columns && j < rows; ++j)
                    {
                        if (matrix[j,i+j] != current)
                            return false;
                    }
                }
                return true;
            }
        }
    }
}
