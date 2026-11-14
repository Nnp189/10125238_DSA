using System;
using System.Diagnostics;

namespace Buoi01_DeQuy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Chay_Muc_1_4_2();
            Chay_Muc_2_5_2();
            Chay_Muc_3_7_2();
        }

        // ==========================================================
        // MỤC 1.4.2 - BÀI TẬP ÁP DỤNG
        // ==========================================================
        static void Chay_Muc_1_4_2()
        {
            Console.WriteLine("================ MỤC 1.4.2 ================");
            Random rd = new Random();

            // Muc 1.4.2 - Bai 1
            Console.WriteLine("\n--- Bài 1: Max, Min mảng 1000 số tự nhiên ---");
            int[] arr1 = new int[1000];
            for (int i = 0; i < 1000; i++) arr1[i] = rd.Next(0, 10000);

            int max = arr1[0], min = arr1[0];
            for (int i = 1; i < 1000; i++)
            {
                if (arr1[i] > max) max = arr1[i];
                if (arr1[i] < min) min = arr1[i];
            }
            Console.WriteLine($"Max = {max}, Min = {min}");

            // Muc 1.4.2 - Bai 2
            Console.WriteLine("\n--- Bài 2: FizzBuzz (1 -> 100) ---");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.Write("FizzBuzz ");
                else if (i % 3 == 0) Console.Write("Fizz ");
                else if (i % 5 == 0) Console.Write("Buzz ");
                else Console.Write(i + " ");
            }
            Console.WriteLine();

            // Muc 1.4.2 - Bai 3
            Console.WriteLine("\n--- Bài 3: Đảo ngược chuỗi ---");
            Console.Write("Nhập chuỗi: ");
            string chuoi = Console.ReadLine() ?? "";
            string daoNguoc = "";
            for (int i = chuoi.Length - 1; i >= 0; i--)
            {
                daoNguoc += chuoi[i];
            }
            Console.WriteLine("Chuỗi đảo ngược: " + daoNguoc);

            // Muc 1.4.2 - Bai 4
            Console.WriteLine("\n--- Bài 4: Mảng 1000 số tự nhiên ---");
            int[] arr4 = new int[1000];
            for (int i = 0; i < 1000; i++) arr4[i] = rd.Next(0, 10000);

            Console.WriteLine("4a. Mảng ban đầu:");
            InMang(arr4);

            Array.Sort(arr4);
            Console.WriteLine("\n4b. Mảng sau khi sắp xếp tăng dần:");
            InMang(arr4);

            // Muc 1.4.2 - Bai 5
            Console.WriteLine("\n--- Bài 5: Số Fibonacci thứ n ---");
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine() ?? "10");
            Console.WriteLine($"Fibonacci({n}) = {Fibonacci_VongLap(n)}");
        }

        static void InMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        // ==========================================================
        // MỤC 2.5.2 - BÀI TẬP ÁP DỤNG (Trang 77 - 79)
        // ==========================================================
        static void Chay_Muc_2_5_2()
        {
            Console.WriteLine("\n================ MỤC 2.5.2 (Trang 77 - 79) ================");
            Stopwatch sw = new Stopwatch();

            // Muc 2.5.2 - Bai 1
            Console.WriteLine("\n--- Bài 1: Tháp Hà Nội ---");
            Console.WriteLine("Hệ thức: T(n) = 2T(n-1) + 1, T(1) = 1 => Độ phức tạp: O(2^n)");

            // Trang 77 - Muc 2.5.2 - Bai 2
            Console.WriteLine("\n--- Bài 2 (Trang 77): Tìm kiếm nhị phân ---");
            Console.WriteLine("Hệ thức: T(n) = T(n/2) + 1, T(1) = 1 => Độ phức tạp: O(log n)");

            // Trang 77 - Muc 2.5.2 - Bai 3
            Console.WriteLine("\n--- Bài 3 (Trang 77): Kiểm tra số nguyên tố (n = 100000007) ---");
            int soNT = 100000007;
            sw.Restart();
            bool kqNT1 = KiemTraNguyenTo_Cach1(soNT);
            sw.Stop();
            Console.WriteLine($"Cách 1 (Duyệt 2..n-1) - O(n): {kqNT1} | Thời gian: {sw.Elapsed.TotalMilliseconds} ms");

            sw.Restart();
            bool kqNT2 = KiemTraNguyenTo_Cach2(soNT);
            sw.Stop();
            Console.WriteLine($"Cách 2 (Duyệt 2..√n) - O(√n): {kqNT2} | Thời gian: {sw.Elapsed.TotalMilliseconds} ms");

            // Trang 78 - Muc 2.5.2 - Bai 4
            Console.WriteLine("\n--- Bài 4 (Trang 78): Liệt kê số hoàn hảo < N (N = 10000) ---");
            int N = 10000;
            sw.Restart();
            LietKeSoHoanHao_Cach1(N);
            sw.Stop();
            Console.WriteLine($"Cách 1 (Cơ bản) - O(N^2) | Thời gian: {sw.Elapsed.TotalMilliseconds} ms");

            sw.Restart();
            LietKeSoHoanHao_Cach2(N);
            sw.Stop();
            Console.WriteLine($"Cách 2 (Cải tiến duyệt đến √k) - O(N√N) | Thời gian: {sw.Elapsed.TotalMilliseconds} ms");

            // Trang 78 - Muc 2.5.2 - Bai 5
            Console.WriteLine("\n--- Bài 5 (Trang 78): Tìm số Fibonacci thứ n (n = 35) ---");
            int fibN = 35;
            sw.Restart();
            long f1 = Fibonacci_DeQuy(fibN);
            sw.Stop();
            Console.WriteLine($"Cách 1 (Đệ quy) - O(2^n): {f1} | Thời gian: {sw.Elapsed.TotalMilliseconds} ms");

            sw.Restart();
            long f2 = Fibonacci_VongLap(fibN);
            sw.Stop();
            Console.WriteLine($"Cách 2 (Vòng lặp) - O(n): {f2} | Thời gian: {sw.Elapsed.TotalMilliseconds} ms");

            // Trang 78, 79 - Muc 2.5.2 - Bai 6
            Console.WriteLine("\n--- Bài 6 (Trang 78-79): Sắp xếp dãy 5000 số thực ---");
            int size = 5000;
            Random rd = new Random();
            double[] goc = new double[size];
            for (int i = 0; i < size; i++) goc[i] = Math.Round(rd.NextDouble() * 1000, 2);

            double[] mangBubble = (double[])goc.Clone();
            sw.Restart();
            BubbleSort(mangBubble);
            sw.Stop();
            Console.WriteLine($"Cách 1 (Bubble Sort) - O(n^2) | Thời gian: {sw.Elapsed.TotalMilliseconds} ms");

            double[] mangSelection = (double[])goc.Clone();
            sw.Restart();
            SelectionSort(mangSelection);
            sw.Stop();
            Console.WriteLine($"Cách 2 (Selection Sort) - O(n^2) | Thời gian: {sw.Elapsed.TotalMilliseconds} ms");
        }

        // Trang 77 - Bai 3
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

        // Trang 78 - Bai 4
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

        // Trang 78 - Bai 5
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

        // Trang 79 - Bai 6
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
        // MỤC 3.7.2 - BÀI TẬP ÁP DỤNG ĐỆ QUY (Trang 100 - 101)
        // ==========================================================
        static void Chay_Muc_3_7_2()
        {
            Console.WriteLine("\n================ MỤC 3.7.2 (Trang 100 - 101) ================");
            int n = 5;
            double x = 2;

            Console.WriteLine($"Bài 1 (Trang 100) - S({n}) = 1 + ... + {n} = {TinhS_Bai1(n)}");
            Console.WriteLine($"Bài 2 (Trang 100) - S({n}) = 1^2 + ... + {n}^2 = {TinhS_Bai2(n)}");
            Console.WriteLine($"Bài 3 (Trang 100) - S({n}) = 1 + 1/2 + ... + 1/{n} = {TinhS_Bai3(n):F4}");
            Console.WriteLine($"Bài 4 (Trang 100) - S({x}, {n}) = {x}^{n} = {TinhS_Bai4(x, n)}");
            Console.WriteLine($"Bài 4 (Trang 100) - S({x}, -2) = {x}^(-2) = {TinhS_Bai4(x, -2)}");
            Console.WriteLine($"Bài 5 (Trang 101) - Ước lẻ lớn nhất của 100 = {UocLeMax(100)}");
            Console.WriteLine($"Bài 6 (Trang 101) - UCLN(48, 18) = {UCLN(48, 18)}");
            Console.WriteLine($"Bài 7 (Trang 101) - Số chữ số của 12345 = {SoChuSo(12345)}");
            Console.WriteLine($"Bài 8 (Trang 101) - Tổng căn lồng nhau (n = {n}) = {TinhS_Bai8(n):F4}");
        }

        // Trang 100 - Muc 3.7.2 - Bai 1
        static int TinhS_Bai1(int n)
        {
            if (n == 1) return 1;
            return TinhS_Bai1(n - 1) + n;
        }

        // Trang 100 - Muc 3.7.2 - Bai 2
        static int TinhS_Bai2(int n)
        {
            if (n == 1) return 1;
            return TinhS_Bai2(n - 1) + n * n;
        }

        // Trang 100 - Muc 3.7.2 - Bai 3
        static double TinhS_Bai3(int n)
        {
            if (n == 1) return 1.0;
            return TinhS_Bai3(n - 1) + 1.0 / n;
        }

        // Trang 100 - Muc 3.7.2 - Bai 4
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

        // Trang 101 - Muc 3.7.2 - Bai 5
        static int UocLeMax(int n)
        {
            if (n % 2 == 1) return n;
            return UocLeMax(n / 2);
        }

        // Trang 101 - Muc 3.7.2 - Bai 6
        static int UCLN(int a, int b)
        {
            if (a % b == 0) return b;
            return UCLN(b, a % b);
        }

        // Trang 101 - Muc 3.7.2 - Bai 7
        static int SoChuSo(int n)
        {
            if (n == 0) return 0;
            return SoChuSo(n / 10) + 1;
        }

        // Trang 101 - Muc 3.7.2 - Bai 8
        static float Can(int i, int n)
        {
            if (i == n) return (float)Math.Sqrt(n);
            return (float)Math.Sqrt(i + Can(i + 1, n));
        }

        static float TinhS_Bai8(int n)
        {
            return Can(1, n);
        }
    }
}
