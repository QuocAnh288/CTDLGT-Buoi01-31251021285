using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
internal class Bai1
{
    
    static void Main1(string[] augs)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Nhập ba số nguyên:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int max, min = 0;
        max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        min = a;
        if (b < min) min = b;
        if (c < min) min = c;
        Console.WriteLine($"Lớn nhất:{max}, Nhỏ nhất:{min}");
        double sum = a + b + c;
        Console.WriteLine($"Tổng:{sum}");
        Console.WriteLine($"Trung bình:{sum/3}");


    }
}