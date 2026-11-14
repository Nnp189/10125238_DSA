# Buổi 01 – Đệ quy

Họ tên: Nguyễn Nam Phong · MSV: 10125238

## Bài đã làm
- Mục 1.4.2: Bài 1, 2, 3, 4, 5
- Mục 2.5.2 (Trang 77 - 79): Bài 1, 2, 3, 4, 5, 6
- Mục 3.7.2 (Trang 100 - 101): Bài 1, 2, 3, 4, 5, 6, 7, 8

## Cách chạy
```
dotnet run --project Buoi01_DeQuy
```

## Kết quả chạy
```
================ MỤC 1.4.2 ================

--- Bài 1: Max, Min mảng 1000 số tự nhiên ---
Max = 9987, Min = 14

--- Bài 2: FizzBuzz (1 -> 100) ---
1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz 

--- Bài 3: Đảo ngược chuỗi ---
Nhập chuỗi: SinhVien
Chuỗi đảo ngược: neiVhniS

--- Bài 4: Mảng 1000 số tự nhiên ---
4a. Mảng ban đầu:
4821 105 9340 2764 512 8891 3402 715 6230 1948 ... (1000 phần tử)

4b. Mảng sau khi sắp xếp tăng dần:
12 25 39 47 58 64 73 89 95 105 ... (1000 phần tử)

--- Bài 5: Số Fibonacci thứ n ---
Nhập n: 10
Fibonacci(10) = 55

================ MỤC 2.5.2 (Trang 77 - 79) ================

--- Bài 1: Tháp Hà Nội ---
Hệ thức: T(n) = 2T(n-1) + 1, T(1) = 1 => Độ phức tạp: O(2^n)

--- Bài 2 (Trang 77): Tìm kiếm nhị phân ---
Hệ thức: T(n) = T(n/2) + 1, T(1) = 1 => Độ phức tạp: O(log n)

--- Bài 3 (Trang 77): Kiểm tra số nguyên tố (n = 100000007) ---
Cách 1 (Duyệt 2..n-1) - O(n): True | Thời gian: 214.5321 ms
Cách 2 (Duyệt 2..√n) - O(√n): True | Thời gian: 0.0412 ms

--- Bài 4 (Trang 78): Liệt kê số hoàn hảo < N (N = 10000) ---
Kết quả Cách 1: 6 28 496 8128 
Cách 1 (Cơ bản) - O(N^2) | Thời gian: 142.8745 ms
Kết quả Cách 2: 6 28 496 8128 
Cách 2 (Cải tiến duyệt đến √k) - O(N√N) | Thời gian: 1.9234 ms

--- Bài 5 (Trang 78): Tìm số Fibonacci thứ n (n = 35) ---
Cách 1 (Đệ quy) - O(2^n): 9227465 | Thời gian: 58.4129 ms
Cách 2 (Vòng lặp) - O(n): 9227465 | Thời gian: 0.0024 ms

--- Bài 6 (Trang 78-79): Sắp xếp dãy 5000 số thực ---
Cách 1 (Bubble Sort) - O(n^2) | Thời gian: 76.3418 ms
Cách 2 (Selection Sort) - O(n^2) | Thời gian: 21.6509 ms

================ MỤC 3.7.2 (Trang 100 - 101) ================
Bài 1 (Trang 100) - S(5) = 1 + ... + 5 = 15
Bài 2 (Trang 100) - S(5) = 1^2 + ... + 5^2 = 55
Bài 3 (Trang 100) - S(5) = 1 + 1/2 + ... + 1/5 = 2.2833
Bài 4 (Trang 100) - S(2, 5) = 2^5 = 32
Bài 4 (Trang 100) - S(2, -2) = 2^(-2) = 0.25
Bài 5 (Trang 101) - Ước lẻ lớn nhất của 100 = 25
Bài 6 (Trang 101) - UCLN(48, 18) = 6
Bài 7 (Trang 101) - Số chữ số của 12345 = 5
Bài 8 (Trang 101) - Tổng căn lồng nhau (n = 5) = 1.7562
```
