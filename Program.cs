using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongDuongCheo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
             Tong();
            Console.ReadLine();
        }
        static void Tong()
        {
            int t = 0,hang,cot;
            do
            {
                Console.WriteLine("Tạo ma trận vuông có số hàng = số cột.");
                Console.WriteLine("Nhập số hàng của mảng muốn tạo:");
                hang = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập sô cột của mảng muốn tạo:");
                cot = int.Parse(Console.ReadLine());
            }
            while (hang != cot);
            int [,] list = new int [hang, cot];
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.WriteLine($"Nhập giá trị của phần tử {i}{j}");
                    list[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Mảng vừa tạo:");
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < hang; j++)
                {
                    Console.Write(list[i,j]+"\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < hang; j++)
                {
                    if (j == i)
                    {
                        t += list[i, j];
                    }
                }
            }
            Console.WriteLine("Tổng các số hạng của đường chéo chính = "+t);


        }
    }
}
