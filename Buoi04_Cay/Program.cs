using System;

namespace Buoi04_Cay
{
    class Node
    {
        public int Data;
        public Node? Left;
        public Node? Right;

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khởi tạo cây nhị phân mẫu:
            //         10
            //        /  \
            //       5    20
            //      / \   / \
            //     3   8 15  30
            Node root = new Node(10);
            root.Left = new Node(5);
            root.Right = new Node(20);
            root.Left.Left = new Node(3);
            root.Left.Right = new Node(8);
            root.Right.Left = new Node(15);
            root.Right.Right = new Node(30);

            Console.WriteLine("=== Chương 6 (Cây nhị phân) - Bài 1 (Trang 266) ===");
            Chuong6_Bai1(root);

            Console.WriteLine("\n=== Chương 6 (Cây nhị phân) - Bài 2 (Trang 266) ===");
            Chuong6_Bai2(root);

            Console.WriteLine("\n=== Chương 6 (Cây nhị phân) - Bài 3 (Trang 266) ===");
            Chuong6_Bai3(root);

            Console.WriteLine("\n=== Chương 6 (Cây nhị phân) - Bài 4 (Trang 266) ===");
            Chuong6_Bai4(root);

            Console.WriteLine("\n=== Chương 6 (Cây nhị phân) - Bài 5 (Trang 266) ===");
            Chuong6_Bai5(root);

            Console.WriteLine("\n=== Chương 6 (Cây nhị phân) - Bài 6 (Trang 266) ===");
            Chuong6_Bai6(root);

            Console.WriteLine("\n=== Chương 6 (Cây nhị phân) - Bài 7 (Trang 266) ===");
            Chuong6_Bai7(root);

            Console.WriteLine("\n=== Chương 6 (Cây nhị phân) - Bài 8 (Trang 266) ===");
            Chuong6_Bai8(root);
        }

        // ==========================================================
        // Chương 6 - Mục 6.7.2 - Bài 1 (Trang 266): Đếm số nút
        // ==========================================================
        static void Chuong6_Bai1(Node? root)
        {
            Console.WriteLine($"Tổng số nút trên cây: {DemSoNut(root)}");
        }

        static int DemSoNut(Node? root)
        {
            if (root == null) return 0;
            return 1 + DemSoNut(root.Left) + DemSoNut(root.Right);
        }

        // ==========================================================
        // Chương 6 - Mục 6.7.2 - Bài 2 (Trang 266): Tính tổng giá trị
        // ==========================================================
        static void Chuong6_Bai2(Node? root)
        {
            Console.WriteLine($"Tổng giá trị các nút: {TongGiaTriNut(root)}");
        }

        static int TongGiaTriNut(Node? root)
        {
            if (root == null) return 0;
            return root.Data + TongGiaTriNut(root.Left) + TongGiaTriNut(root.Right);
        }

        // ==========================================================
        // Chương 6 - Mục 6.7.2 - Bài 3 (Trang 266): Hiển thị các nút
        // ==========================================================
        static void Chuong6_Bai3(Node? root)
        {
            Console.Write("Giá trị các nút trên cây: ");
            HienThiNut(root);
            Console.WriteLine();
        }

        static void HienThiNut(Node? root)
        {
            if (root == null) return;
            Console.Write(root.Data + " ");
            HienThiNut(root.Left);
            HienThiNut(root.Right);
        }

        // ==========================================================
        // Chương 6 - Mục 6.7.2 - Bài 4 (Trang 266): Hiển thị nút chẵn
        // ==========================================================
        static void Chuong6_Bai4(Node? root)
        {
            Console.Write("Các nút có giá trị chẵn: ");
            HienThiNutChan(root);
            Console.WriteLine();
        }

        static void HienThiNutChan(Node? root)
        {
            if (root == null) return;
            if (root.Data % 2 == 0) Console.Write(root.Data + " ");
            HienThiNutChan(root.Left);
            HienThiNutChan(root.Right);
        }

        // ==========================================================
        // Chương 6 - Mục 6.7.2 - Bài 5 (Trang 266): Đếm số nút chẵn
        // ==========================================================
        static void Chuong6_Bai5(Node? root)
        {
            Console.WriteLine($"Số lượng nút có giá trị chẵn: {DemNutChan(root)}");
        }

        static int DemNutChan(Node? root)
        {
            if (root == null) return 0;
            int dem = (root.Data % 2 == 0) ? 1 : 0;
            return dem + DemNutChan(root.Left) + DemNutChan(root.Right);
        }

        // ==========================================================
        // Chương 6 - Mục 6.7.2 - Bài 6 (Trang 266): Đếm số con của nút
        // ==========================================================
        static void Chuong6_Bai6(Node? root)
        {
            Console.WriteLine($"Số con của nút {root?.Data}: {DemSoCon(root)}");
            Console.WriteLine($"Số con của nút {root?.Left?.Left?.Data}: {DemSoCon(root?.Left?.Left)}");
        }

        static int DemSoCon(Node? p)
        {
            if (p == null) return 0;
            int soCon = 0;
            if (p.Left != null) soCon++;
            if (p.Right != null) soCon++;
            return soCon;
        }

        // ==========================================================
        // Chương 6 - Mục 6.7.2 - Bài 7 (Trang 266): Cây con trái
        // ==========================================================
        static void Chuong6_Bai7(Node? root)
        {
            Console.Write("Các nút trên cây con trái: ");
            if (root != null) HienThiNut(root.Left);
            Console.WriteLine();
        }

        // ==========================================================
        // Chương 6 - Mục 6.7.2 - Bài 8 (Trang 266): Duyệt cây
        // ==========================================================
        static void Chuong6_Bai8(Node? root)
        {
            Console.Write("Tiền thứ tự (NLR): ");
            DuyetNLR(root);
            Console.WriteLine();

            Console.Write("Trung thứ tự (LNR): ");
            DuyetLNR(root);
            Console.WriteLine();

            Console.Write("Hậu thứ tự (LRN): ");
            DuyetLRN(root);
            Console.WriteLine();
        }

        static void DuyetNLR(Node? root)
        {
            if (root == null) return;
            Console.Write(root.Data + " ");
            DuyetNLR(root.Left);
            DuyetNLR(root.Right);
        }

        static void DuyetLNR(Node? root)
        {
            if (root == null) return;
            DuyetLNR(root.Left);
            Console.Write(root.Data + " ");
            DuyetLNR(root.Right);
        }

        static void DuyetLRN(Node? root)
        {
            if (root == null) return;
            DuyetLRN(root.Left);
            DuyetLRN(root.Right);
            Console.Write(root.Data + " ");
        }
    }
}
