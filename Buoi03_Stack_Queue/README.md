# Buổi 03 – Stack và Queue

Họ tên: Nguyễn Nam Phong · MSV: 10125238

## Bài đã làm
- **Chương 5: Ngăn xếp và Hàng đợi** (Mục 5.5.2 - Trang 215 - 217): Bài 1, 2, 3, 4, 5, 6

## Cách chạy
```
dotnet run --project Buoi03_Stack_Queue
```

## Kết quả chạy
```
=== Chương 5 (Stack & Queue) - Bài 1 (Trang 215) ===
Biểu thức "{[a + b] * (c - d)}" hợp lệ: True
Biểu thức "{[a + b) * c]" hợp lệ: False

=== Chương 5 (Stack & Queue) - Bài 2 (Trang 215) ===
Trang bắt đầu: google.com
Truy cập: github.com
Truy cập: utehy.edu.vn
Nhấn Back -> Đang ở: github.com
Nhấn Back -> Đang ở: google.com
Nhấn Forward -> Đang ở: github.com

=== Chương 5 (Stack & Queue) - Bài 3 (Trang 215-216) ===
[PUSH] Gọi Main(args) | Trả về: OS
[PUSH] Gọi TinhTong(a=3, b=5) | Trả về: Main:Line10
[PUSH] Gọi KiemTra(x=3) | Trả về: TinhTong:Line22
[POP]  Kết thúc KiemTra -> Quay lại TinhTong:Line22
[POP]  Kết thúc TinhTong -> Quay lại Main:Line10
[POP]  Kết thúc Main -> Quay lại OS

=== Chương 5 (Stack & Queue) - Bài 4 (Trang 216) ===
Đã thêm 3 tài liệu vào hàng đợi. Số lượng chờ: 3
Đang in: TaiLieu_01.pdf | Còn lại trong hàng đợi: 2
Đang in: BaoCao_DSA.docx | Còn lại trong hàng đợi: 1
Đang in: Slide_Chuong5.pptx | Còn lại trong hàng đợi: 0

=== Chương 5 (Stack & Queue) - Bài 5 (Trang 216) ===
Gửi vào mạng: Packet_1 [SYN]
Gửi vào mạng: Packet_2 [DATA]
Gửi vào mạng: Packet_3 [ACK]
Đích đã nhận & xử lý: Packet_1 [SYN]
Đích đã nhận & xử lý: Packet_2 [DATA]
Đích đã nhận & xử lý: Packet_3 [ACK]

=== Chương 5 (Stack & Queue) - Bài 6 (Trang 216-217) ===
Số khách đang chờ tại quầy: 3
Phục vụ: Nguyễn Văn A (Đến lúc 08:00 - DV: Mở thẻ) | Còn chờ: 2
Phục vụ: Trần Thị B (Đến lúc 08:05 - DV: Nộp tiền) | Còn chờ: 1
Phục vụ: Lê Văn C (Đến lúc 08:10 - DV: Vay vốn) | Còn chờ: 0
```
