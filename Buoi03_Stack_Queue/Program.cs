using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    // Chương 5 - Bài 3 (Trang 215-216)
    class StackFrame
    {
        public string TenHam;
        public string ThamSo;
        public string DiaChiTraVe;

        public StackFrame(string tenHam, string thamSo, string diaChi)
        {
            TenHam = tenHam;
            ThamSo = thamSo;
            DiaChiTraVe = diaChi;
        }
    }

    // Chương 5 - Bài 6 (Trang 216-217)
    class KhachHang
    {
        public string Ten;
        public string ThoiGianDen;
        public string LoaiDichVu;

        public KhachHang(string ten, string tg, string dv)
        {
            Ten = ten;
            ThoiGianDen = tg;
            LoaiDichVu = dv;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Chương 5 (Stack & Queue) - Bài 1 (Trang 215) ===");
            Chuong5_Bai1();

            Console.WriteLine("\n=== Chương 5 (Stack & Queue) - Bài 2 (Trang 215) ===");
            Chuong5_Bai2();

            Console.WriteLine("\n=== Chương 5 (Stack & Queue) - Bài 3 (Trang 215-216) ===");
            Chuong5_Bai3();

            Console.WriteLine("\n=== Chương 5 (Stack & Queue) - Bài 4 (Trang 216) ===");
            Chuong5_Bai4();

            Console.WriteLine("\n=== Chương 5 (Stack & Queue) - Bài 5 (Trang 216) ===");
            Chuong5_Bai5();

            Console.WriteLine("\n=== Chương 5 (Stack & Queue) - Bài 6 (Trang 216-217) ===");
            Chuong5_Bai6();
        }

        // ==========================================================
        // Chương 5 - Mục 5.5.2 - Bài 1 (Trang 215)
        // ==========================================================
        static void Chuong5_Bai1()
        {
            string bt1 = "{[a + b] * (c - d)}";
            string bt2 = "{[a + b) * c]";

            Console.WriteLine($"Biểu thức \"{bt1}\" hợp lệ: {KiemTraNgoac(bt1)}");
            Console.WriteLine($"Biểu thức \"{bt2}\" hợp lệ: {KiemTraNgoac(bt2)}");
        }

        static bool KiemTraNgoac(string bieuThuc)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in bieuThuc)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0) return false;
                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

        // ==========================================================
        // Chương 5 - Mục 5.5.2 - Bài 2 (Trang 215)
        // ==========================================================
        static void Chuong5_Bai2()
        {
            Stack<string> backStack = new Stack<string>();
            Stack<string> forwardStack = new Stack<string>();
            string trangHienTai = "google.com";

            void TruyCap(string url)
            {
                backStack.Push(trangHienTai);
                trangHienTai = url;
                forwardStack.Clear();
                Console.WriteLine($"Truy cập: {trangHienTai}");
            }

            void Back()
            {
                if (backStack.Count > 0)
                {
                    forwardStack.Push(trangHienTai);
                    trangHienTai = backStack.Pop();
                    Console.WriteLine($"Nhấn Back -> Đang ở: {trangHienTai}");
                }
            }

            void Forward()
            {
                if (forwardStack.Count > 0)
                {
                    backStack.Push(trangHienTai);
                    trangHienTai = forwardStack.Pop();
                    Console.WriteLine($"Nhấn Forward -> Đang ở: {trangHienTai}");
                }
            }

            Console.WriteLine($"Trang bắt đầu: {trangHienTai}");
            TruyCap("github.com");
            TruyCap("utehy.edu.vn");
            Back();
            Back();
            Forward();
        }

        // ==========================================================
        // Chương 5 - Mục 5.5.2 - Bài 3 (Trang 215-216)
        // ==========================================================
        static void Chuong5_Bai3()
        {
            Stack<StackFrame> callStack = new Stack<StackFrame>();

            void GoiHam(StackFrame frame)
            {
                callStack.Push(frame);
                Console.WriteLine($"[PUSH] Gọi {frame.TenHam}({frame.ThamSo}) | Trả về: {frame.DiaChiTraVe}");
            }

            void TraVe()
            {
                if (callStack.Count > 0)
                {
                    StackFrame f = callStack.Pop();
                    Console.WriteLine($"[POP]  Kết thúc {f.TenHam} -> Quay lại {f.DiaChiTraVe}");
                }
            }

            GoiHam(new StackFrame("Main", "args", "OS"));
            GoiHam(new StackFrame("TinhTong", "a=3, b=5", "Main:Line10"));
            GoiHam(new StackFrame("KiemTra", "x=3", "TinhTong:Line22"));
            TraVe();
            TraVe();
            TraVe();
        }

        // ==========================================================
        // Chương 5 - Mục 5.5.2 - Bài 4 (Trang 216)
        // ==========================================================
        static void Chuong5_Bai4()
        {
            Queue<string> hangDoiIn = new Queue<string>();

            hangDoiIn.Enqueue("TaiLieu_01.pdf");
            hangDoiIn.Enqueue("BaoCao_DSA.docx");
            hangDoiIn.Enqueue("Slide_Chuong5.pptx");
            Console.WriteLine($"Đã thêm 3 tài liệu vào hàng đợi. Số lượng chờ: {hangDoiIn.Count}");

            while (hangDoiIn.Count > 0)
            {
                string taiLieu = hangDoiIn.Dequeue();
                Console.WriteLine($"Đang in: {taiLieu} | Còn lại trong hàng đợi: {hangDoiIn.Count}");
            }
        }

        // ==========================================================
        // Chương 5 - Mục 5.5.2 - Bài 5 (Trang 216)
        // ==========================================================
        static void Chuong5_Bai5()
        {
            Queue<string> kenhTruyen = new Queue<string>();
            string[] goiTin = { "Packet_1 [SYN]", "Packet_2 [DATA]", "Packet_3 [ACK]" };

            foreach (var pkt in goiTin)
            {
                kenhTruyen.Enqueue(pkt);
                Console.WriteLine($"Gửi vào mạng: {pkt}");
            }

            while (kenhTruyen.Count > 0)
            {
                string nhan = kenhTruyen.Dequeue();
                Console.WriteLine($"Đích đã nhận & xử lý: {nhan}");
            }
        }

        // ==========================================================
        // Chương 5 - Mục 5.5.2 - Bài 6 (Trang 216-217)
        // ==========================================================
        static void Chuong5_Bai6()
        {
            Queue<KhachHang> hangDoiKH = new Queue<KhachHang>();

            hangDoiKH.Enqueue(new KhachHang("Nguyễn Văn A", "08:00", "Mở thẻ"));
            hangDoiKH.Enqueue(new KhachHang("Trần Thị B", "08:05", "Nộp tiền"));
            hangDoiKH.Enqueue(new KhachHang("Lê Văn C", "08:10", "Vay vốn"));

            Console.WriteLine($"Số khách đang chờ tại quầy: {hangDoiKH.Count}");
            while (hangDoiKH.Count > 0)
            {
                KhachHang kh = hangDoiKH.Dequeue();
                Console.WriteLine($"Phục vụ: {kh.Ten} (Đến lúc {kh.ThoiGianDen} - DV: {kh.LoaiDichVu}) | Còn chờ: {hangDoiKH.Count}");
            }
        }
    }
}
