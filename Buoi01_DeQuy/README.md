# Buổi 01 – Đệ quy

Họ tên: Nguyễn Nam Phong · MSV: 10125238

## Bài đã làm
- **Chương 1: Tổng quan** (Mục 1.4.2): Bài 1, 2, 3, 4, 5
- **Chương 2: Phân tích giải thuật** (Mục 2.5.2 - Trang 77 - 79): Bài 1, 2, 3, 4, 5, 6
- **Chương 3: Đệ quy** (Mục 3.7.2 - Trang 100 - 101): Bài 1, 2, 3, 4, 5, 6, 7, 8

## Cách chạy
```
dotnet run --project Buoi01_DeQuy
```

## Kết quả chạy
```
=== Chương 1 (Tổng quan) - Bài 1 ===
Max = 9987, Min = 14

=== Chương 1 (Tổng quan) - Bài 2 ===
1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz 

=== Chương 1 (Tổng quan) - Bài 3 ===
Nhập chuỗi: SinhVien
Chuỗi đảo ngược: neiVhniS

=== Chương 1 (Tổng quan) - Bài 4 ===
4a. Mảng ban đầu:
4821 105 9340 2764 512 8891 3402 715 6230 1948 ... (1000 phần tử)

4b. Mảng sau khi sắp xếp tăng dần:
12 25 39 47 58 64 73 89 95 105 ... (1000 phần tử)

=== Chương 1 (Tổng quan) - Bài 5 ===
Nhập n: 10
Fibonacci(10) = 55

=== Chương 2 (Phân tích GT) - Bài 1 ===
Tháp Hà Nội: T(n) = 2T(n-1) + 1, T(1) = 1 => O(2^n)

=== Chương 2 (Phân tích GT) - Bài 2 (Trang 77) ===
Tìm kiếm nhị phân: T(n) = T(n/2) + 1, T(1) = 1 => O(log n)

=== Chương 2 (Phân tích GT) - Bài 3 (Trang 77) ===
Cách 1 - O(n): True | 214.5321 ms
Cách 2 - O(√n): True | 0.0412 ms

=== Chương 2 (Phân tích GT) - Bài 4 (Trang 78) ===
Kết quả Cách 1: 6 28 496 8128 
Cách 1 - O(N^2) | 142.8745 ms
Kết quả Cách 2: 6 28 496 8128 
Cách 2 - O(N√N) | 1.9234 ms

=== Chương 2 (Phân tích GT) - Bài 5 (Trang 78) ===
Cách 1 (Đệ quy) - O(2^n): 9227465 | 58.4129 ms
Cách 2 (Vòng lặp) - O(n): 9227465 | 0.0024 ms

=== Chương 2 (Phân tích GT) - Bài 6 (Trang 78-79) ===
Bubble Sort - O(n^2) | 76.3418 ms
Selection Sort - O(n^2) | 21.6509 ms

=== Chương 3 (Đệ quy) - Bài 1 (Trang 100) ===
S(5) = 15

=== Chương 3 (Đệ quy) - Bài 2 (Trang 100) ===
S(5) = 55

=== Chương 3 (Đệ quy) - Bài 3 (Trang 100) ===
S(5) = 2.2833

=== Chương 3 (Đệ quy) - Bài 4 (Trang 100) ===
S(2, 5) = 32
S(2, -2) = 0.25

=== Chương 3 (Đệ quy) - Bài 5 (Trang 101) ===
Ước lẻ lớn nhất của 100 = 25

=== Chương 3 (Đệ quy) - Bài 6 (Trang 101) ===
UCLN(48, 18) = 6

=== Chương 3 (Đệ quy) - Bài 7 (Trang 101) ===
Số chữ số của 12345 = 5

=== Chương 3 (Đệ quy) - Bài 8 (Trang 101) ===
Tổng căn lồng nhau (n = 5) = 1.7562
```
