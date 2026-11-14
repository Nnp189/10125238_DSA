using System;
using System.Diagnostics;

namespace Buoi01_DeQuy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // ======================================================
            // CHƯƠNG 1: TỔNG QUAN (Mục 1.4.2)
            // ======================================================
            Console.WriteLine("=== Chương 1 (Tổng quan) - Bài 1 ===");
            Chuong1_Bai1();

            Console.WriteLine("\n=== Chương 1 (Tổng quan) - Bài 2 ===");
            Chuong1_Bai2();

            Console.WriteLine("\n=== Chương 1 (Tổng quan) - Bài 3 ===");
            Chuong1_Bai3();

            Console.WriteLine("\n=== Chương 1 (Tổng quan) - Bài 4 ===");
            Chuong1_Bai4();

            Console.WriteLine("\n=== Chương 1 (Tổng quan) - Bài 5 ===");
            Chuong1_Bai5();

            // ======================================================
            // CHƯƠNG 2: PHÂN TÍCH GIẢI THUẬT (Mục 2.5.2 - Trang 77-79)
            // ======================================================
            Console.WriteLine("\n=== Chương 2 (Phân tích GT) - Bài 1 ===");
            Chuong2_Bai1();

            Console.WriteLine("\n=== Chương 2 (Phân tích GT) - Bài 2 (Trang 77) ===");
            Chuong2_Bai2();

            Console.WriteLine("\n=== Chương 2 (Phân tích GT) - Bài 3 (Trang 77) ===");
            Chuong2_Bai3();

            Console.WriteLine("\n=== Chương 2 (Phân tích GT) - Bài 4 (Trang 78) ===");
            Chuong2_Bai4();

            Console.WriteLine("\n=== Chương 2 (Phân tích GT) - Bài 5 (Trang 78) ===");
            Chuong2_Bai5();

            Console.WriteLine("\n=== Chương 2 (Phân tích GT) - Bài 6 (Trang 78-79) ===");
            Chuong2_Bai6();

            // ======================================================
            // CHƯƠNG 3: ĐỆ QUY (Mục 3.7.2 - Trang 100-101)
            // ======================================================
            Console.WriteLine("\n=== Chương 3 (Đệ quy) - Bài 1 (Trang 100) ===");
            Chuong3_Bai1();

            Console.WriteLine("\n=== Chương 3 (Đệ quy) - Bài 2 (Trang 100) ===");
            Chuong3_Bai2();

            Console.WriteLine("\n=== Chương 3 (Đệ quy) - Bài 3 (Trang 100) ===");
            Chuong3_Bai3();

            Console.WriteLine("\n=== Chương 3 (Đệ quy) - Bài 4 (Trang 100) ===");
            Chuong3_Bai4();

            Console.WriteLine("\n=== Chương 3 (Đệ quy) - Bài 5 (Trang 101) ===");
            Chuong3_Bai5();

            Console.WriteLine("\n=== Chương 3 (Đệ quy) - Bài 6 (Trang 101) ===");
            Chuong3_Bai6();

            Console.WriteLine("\n=== Chương 3 (Đệ quy) - Bài 7 (Trang 101) ===");
            Chuong3_Bai7();

            Console.WriteLine("\n=== Chương 3 (Đệ quy) - Bài 8 (Trang 101) ===");
            Chuong3_Bai8();
        }

        // ==========================================================
        // CHƯƠNG 1: TỔNG QUAN (Mục 1.4.2)
        // ==========================================================

        // Chương 1 - Mục 1.4.2 - Bài 1
        static void Chuong1_Bai1()
        {
            Random rd = new Random();
            int[] arr = new int[1000];
            for (int i = 0; i < 1000; i++) arr[i] = rd.Next(0, 10000);

            int max = arr[0], min = arr[0];
            for (int i = 1; i < 1000; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
            Console.WriteLine($"Max = {max}, Min = {min}");
        }

        // Chương 1 - Mục 1.4.2 - Bài 2
        static void Chuong1_Bai2()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.Write("FizzBuzz ");
                else if (i % 3 == 0) Console.Write("Fizz ");
                else if (i % 5 == 0) Console.Write("Buzz ");
                else Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // Chương 1 - Mục 1.4.2 - Bài 3
        static void Chuong1_Bai3()
        {
            Console.Write("Nhập chuỗi: ");
            string chuoi = Console.ReadLine() ?? "";
            string daoNguoc = "";
            for (int i = chuoi.Length - 1; i >= 0; i--)
            {
                daoNguoc += chuoi[i];
            }
            Console.WriteLine("Chuỗi đảo ngược: " + daoNguoc);
        }

        // Chương 1 - Mục 1.4.2 - Bài 4
        static void Chuong1_Bai4()
        {
            Random rd = new Random();
            int[] arr = new int[1000];
            for (int i = 0; i < 1000; i++) arr[i] = rd.Next(0, 10000);

            Console.WriteLine("4a. Mảng ban đầu:");
            InMang(arr);

            Array.Sort(arr);
            Console.WriteLine("\n4b. Mảng sau khi sắp xếp tăng dần:");
            InMang(arr);
        }

        static void InMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        // Chương 1 - Mục 1.4.2 - Bài 5
        static void Chuong1_Bai5()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine() ?? "10");
            Console.WriteLine($"Fibonacci({n}) = {Fibonacci_VongLap(n)}");
        }

        // ==========================================================
        // CHƯƠNG 2: PHÂN TÍCH GIẢI THUẬT (Mục 2.5.2 - Trang 77-79)
        // ==========================================================

        // Chương 2 - Mục 2.5.2 - Bài 1
        static void Chuong2_Bai1()
        {
            Console.WriteLine("Tháp Hà Nội: T(n) = 2T(n-1) + 1, T(1) = 1 => O(2^n)");
        }

        // Chương 2 - Mục 2.5.2 - Bài 2 (Trang 77)
        static void Chuong2_Bai2()
        {
            Console.WriteLine("Tìm kiếm nhị phân: T(n) = T(n/2) + 1, T(1) = 1 => O(log n)");
        }

        // Chương 2 - Mục 2.5.2 - Bài 3 (Trang 77)
        static void Chuong2_Bai3()
        {
            Stopwatch sw = new Stopwatch();
            int soNT = 100000007;

            sw.Restart();
            bool kq1 = KiemTraNguyenTo_Cach1(soNT);
            sw.Stop();
            Console.WriteLine($"Cách 1 - O(n): {kq1} | {sw.Elapsed.TotalMilliseconds} ms");

            sw.Restart();
            bool kq2 = KiemTraNguyenTo_Cach2(soNT);
            sw.Stop();
            Console.WriteLine($"Cách 2 - O(√n): {kq2} | {sw.Elapsed.TotalMilliseconds} ms");
        }

        static bool KiemTraNguyenTo_Cach1(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i < n; i++)
                if (n % i == 0) return false;
            return true;
        }

        static bool KiemTraNguyenTo_Cach2(int n)
        {
            if (n < 2) return false;
            int limit = (int)Math.Sqrt(n);
            for (int i = 2; i <= limit; i++)
                if (n % i == 0) return false;
            return true;
        }

        // Chương 2 - Mục 2.5.2 - Bài 4 (Trang 78)
        static void Chuong2_Bai4()
        {
            Stopwatch sw = new Stopwatch();
            int N = 10000;

            sw.Restart();
            LietKeSoHoanHao_Cach1(N);
            sw.Stop();
            Console.WriteLine($"Cách 1 - O(N^2) | {sw.Elapsed.TotalMilliseconds} ms");

            sw.Restart();
            LietKeSoHoanHao_Cach2(N);
            sw.Stop();
            Console.WriteLine($"Cách 2 - O(N√N) | {sw.Elapsed.TotalMilliseconds} ms");
        }

        static void LietKeSoHoanHao_Cach1(int N)
        {
            Console.Write("Kết quả Cách 1: ");
            for (int k = 2; k < N; k++)
            {
                int tong = 0;
                for (int i = 1; i < k; i++)
                    if (k % i == 0) tong += i;
                if (tong == k) Console.Write(k + " ");
            }
            Console.WriteLine();
        }

        static void LietKeSoHoanHao_Cach2(int N)
        {
            Console.Write("Kết quả Cách 2: ");
            for (int k = 2; k < N; k++)
            {
                int tong = 1;
                int limit = (int)Math.Sqrt(k);
                for (int i = 2; i <= limit; i++)
                {
                    if (k % i == 0)
                    {
                        tong += i;
                        if (i != k / i) tong += k / i;
                    }
                }
                if (tong == k) Console.Write(k + " ");
            }
            Console.WriteLine();
        }

        // Chương 2 - Mục 2.5.2 - Bài 5 (Trang 78)
        static void Chuong2_Bai5()
        {
            Stopwatch sw = new Stopwatch();
            int n = 35;

            sw.Restart();
            long f1 = Fibonacci_DeQuy(n);
            sw.Stop();
            Console.WriteLine($"Cách 1 (Đệ quy) - O(2^n): {f1} | {sw.Elapsed.TotalMilliseconds} ms");

            sw.Restart();
            long f2 = Fibonacci_VongLap(n);
            sw.Stop();
            Console.WriteLine($"Cách 2 (Vòng lặp) - O(n): {f2} | {sw.Elapsed.TotalMilliseconds} ms");
        }

        static long Fibonacci_DeQuy(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci_DeQuy(n - 1) + Fibonacci_DeQuy(n - 2);
        }

        static long Fibonacci_VongLap(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            long f0 = 0, f1 = 1, fn = 0;
            for (int i = 2; i <= n; i++)
            {
                fn = f0 + f1;
                f0 = f1;
                f1 = fn;
            }
            return fn;
        }

        // Chương 2 - Mục 2.5.2 - Bài 6 (Trang 78-79)
        static void Chuong2_Bai6()
        {
            Stopwatch sw = new Stopwatch();
            int size = 5000;
            Random rd = new Random();
            double[] goc = new double[size];
            for (int i = 0; i < size; i++) goc[i] = Math.Round(rd.NextDouble() * 1000, 2);

            double[] mang1 = (double[])goc.Clone();
            sw.Restart();
            BubbleSort(mang1);
            sw.Stop();
            Console.WriteLine($"Bubble Sort - O(n^2) | {sw.Elapsed.TotalMilliseconds} ms");

            double[] mang2 = (double[])goc.Clone();
            sw.Restart();
            SelectionSort(mang2);
            sw.Stop();
            Console.WriteLine($"Selection Sort - O(n^2) | {sw.Elapsed.TotalMilliseconds} ms");
        }

        static void BubbleSort(double[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        double tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
                }
            }
        }

        static void SelectionSort(double[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[minIdx]) minIdx = j;
                }
                double tmp = a[minIdx];
                a[minIdx] = a[i];
                a[i] = tmp;
            }
        }

        // ==========================================================
        // CHƯƠNG 3: ĐỆ QUY (Mục 3.7.2 - Trang 100-101)
        // ==========================================================

        // Chương 3 - Mục 3.7.2 - Bài 1 (Trang 100)
        static void Chuong3_Bai1()
        {
            Console.WriteLine($"S(5) = {TinhS_Bai1(5)}");
        }

        static int TinhS_Bai1(int n)
        {
            if (n == 1) return 1;
            return TinhS_Bai1(n - 1) + n;
        }

        // Chương 3 - Mục 3.7.2 - Bài 2 (Trang 100)
        static void Chuong3_Bai2()
        {
            Console.WriteLine($"S(5) = {TinhS_Bai2(5)}");
        }

        static int TinhS_Bai2(int n)
        {
            if (n == 1) return 1;
            return TinhS_Bai2(n - 1) + n * n;
        }

        // Chương 3 - Mục 3.7.2 - Bài 3 (Trang 100)
        static void Chuong3_Bai3()
        {
            Console.WriteLine($"S(5) = {TinhS_Bai3(5):F4}");
        }

        static double TinhS_Bai3(int n)
        {
            if (n == 1) return 1.0;
            return TinhS_Bai3(n - 1) + 1.0 / n;
        }

        // Chương 3 - Mục 3.7.2 - Bài 4 (Trang 100)
        static void Chuong3_Bai4()
        {
            Console.WriteLine($"S(2, 5) = {TinhS_Bai4(2, 5)}");
            Console.WriteLine($"S(2, -2) = {TinhS_Bai4(2, -2)}");
        }

        static double LuyThua(double x, int n)
        {
            if (n == 0) return 1;
            return LuyThua(x, n - 1) * x;
        }

        static double TinhS_Bai4(double x, int n)
        {
            if (n < 0) return 1.0 / LuyThua(x, -n);
            return LuyThua(x, n);
        }

        // Chương 3 - Mục 3.7.2 - Bài 5 (Trang 101)
        static void Chuong3_Bai5()
        {
            Console.WriteLine($"Ước lẻ lớn nhất của 100 = {UocLeMax(100)}");
        }

        static int UocLeMax(int n)
        {
            if (n % 2 == 1) return n;
            return UocLeMax(n / 2);
        }

        // Chương 3 - Mục 3.7.2 - Bài 6 (Trang 101)
        static void Chuong3_Bai6()
        {
            Console.WriteLine($"UCLN(48, 18) = {UCLN(48, 18)}");
        }

        static int UCLN(int a, int b)
        {
            if (a % b == 0) return b;
            return UCLN(b, a % b);
        }

        // Chương 3 - Mục 3.7.2 - Bài 7 (Trang 101)
        static void Chuong3_Bai7()
        {
            Console.WriteLine($"Số chữ số của 12345 = {SoChuSo(12345)}");
        }

        static int SoChuSo(int n)
        {
            if (n == 0) return 0;
            return SoChuSo(n / 10) + 1;
        }

        // Chương 3 - Mục 3.7.2 - Bài 8 (Trang 101)
        static void Chu
