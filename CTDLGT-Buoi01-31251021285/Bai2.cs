using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Text;
internal class Bai2
{

    static void Main2(string[] augs)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Nhập n số nguyên:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for(int i =0;i < n; i++)
        {
            Console.WriteLine($"Nhập giá trị phần tử thứ {i}:");
            a[i] = int.Parse(Console.ReadLine());
        }
        int max1 = int.MinValue;
        int max2 = int.MinValue;
        bool hasmax2 = false;
        for(int i = 0; i < n; i++)
        {
            int k = a[i];
            if(k > max1)
            {
                if(max1 != int.MinValue)
                {
                    max2 = max1;
                    hasmax2 = true;
                }
                max1 = k;
                
            }
            else if(k < max1 && k > max2)
            {
                max2 = k;
                hasmax2 = true;
            }

        }
        if (hasmax2)
        {
            Console.WriteLine($" Số lớn nhất là:{max1}, Số lớn thứ hai: {max2}");
        }
        else
        {
            Console.WriteLine("NO");
        }

    }
}