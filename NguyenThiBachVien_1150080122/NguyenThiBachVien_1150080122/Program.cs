//// Tính diện tích và chu vi HCN
//using System;

//class Program
//{
//    static void Main()
//    {
//        // Nhập dữ liệu
//        Console.Write("Nhập vào chiều dài a: ");
//        double a = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Nhập vào chiều rộng b: ");
//        double b = Convert.ToDouble(Console.ReadLine());

//        // Tính chu vi và diện tích
//        double P = (a + b) * 2;
//        double S = a * b;

//        // Hiển thị kết quả
//        Console.WriteLine("Chu vi hình chữ nhật là: " + P);
//        Console.WriteLine("Diện tích hình chữ nhật là: " + S);
//    }
//}


//// Tìm số lớn hơn trong 2 số nguyên a và b được nhập vào từ bàn phím
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhập số nguyên a: ");
//        int a = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Nhập số nguyên b: ");
//        int b = Convert.ToInt32(Console.ReadLine());

//        int max;
//        if (a > b)
//            max = a;
//        else
//            max = b;

//        Console.WriteLine("Số lớn hơn là: " + max);
//    }
//}

////Tìm số lớn nhất trong 3 số nguyên
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhập a: ");
//        int a = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Nhập b: ");
//        int b = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Nhập c: ");
//        int c = Convert.ToInt32(Console.ReadLine());

//        int max = a;
//        if (b > max) max = b;
//        if (c > max) max = c;

//        Console.WriteLine("Số lớn nhất là: " + max);
//    }
//}

// Cho biết số ngày trong tháng

//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhập năm: ");
//        int nam = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Nhập tháng: ");
//        int thang = Convert.ToInt32(Console.ReadLine());
//        switch (thang)
//        {
//            case 1:
//            case 3:
//            case 5:
//            case 7:
//            case 8:
//            case 10:
//            case 12:
//                Console.WriteLine("Tháng có 31 ngày.");
//                break;
//            case 4:
//            case 6:
//            case 9:
//            case 11:
//                Console.WriteLine("Tháng có 30 ngày.");
//                break;
//            case 2:
//                if ((nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0))
//                    Console.WriteLine("Tháng có 29 ngày.");
//                else
//                    Console.WriteLine("Tháng có 28 ngày.");
//                break;
//            default:
//                Console.WriteLine("Tháng không hợp lệ!");
//                break;
//        }
//    }
//}

////TH5: Tìm số âm

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhập số nguyên n: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        // a) Kiểm tra chẵn lẻ
//        if (n % 2 == 0)
//            Console.WriteLine("n là số chẵn");
//        else
//            Console.WriteLine("n là số lẻ");

//        // b) Kiểm tra âm / không âm
//        if (n < 0)
//            Console.WriteLine("n là số âm");
//        else
//            Console.WriteLine("n là số không âm");
//    }
//}




//TH7: Chu vi và diện tích tam giác
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhập cạnh a: ");
//        double a = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Nhập cạnh b: ");
//        double b = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Nhập cạnh c: ");
//        double c = Convert.ToDouble(Console.ReadLine());

//        if (a + b > c && a + c > b && b + c > a)
//        {
//            double P = a + b + c;
//            double p = P / 2;
//            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

//            Console.WriteLine("Chu vi tam giác: " + P);
//            Console.WriteLine("Diện tích tam giác: " + S);
//        }
//        else
//        {
//            Console.WriteLine("Ba cạnh không tạo thành tam giác!");
//        }
//    }
//}

////TH8: Giải pt bậc 2
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhập a: ");
//        double a = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Nhập b: ");
//        double b = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Nhập c: ");
//        double c = Convert.ToDouble(Console.ReadLine());

//        if (a == 0) // phương trình bậc nhất
//        {
//            if (b == 0)
//            {
//                if (c == 0)
//                    Console.WriteLine("Phương trình vô số nghiệm.");
//                else
//                    Console.WriteLine("Phương trình vô nghiệm.");
//            }
//            else
//            {
//                double x = -c / b;
//                Console.WriteLine("Phương trình có nghiệm: x = " + x);
//            }
//        }
//        else // phương trình bậc 2
//        {
//            double delta = b * b - 4 * a * c;

//            if (delta < 0)
//            {
//                Console.WriteLine("Phương trình vô nghiệm.");
//            }
//            else if (delta == 0)
//            {
//                double x = -b / (2 * a);
//                Console.WriteLine("Phương trình có nghiệm kép: x = " + x);
//            }
//            else
//            {
//                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
//                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
//                Console.WriteLine("Phương trình có 2 nghiệm phân biệt:");
//                Console.WriteLine("x1 = " + x1);
//                Console.WriteLine("x2 = " + x2);
//            }
//        }
//    }
//}


//// TH9: Tính tổng các phần tử trong mảng
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhập số phần tử của mảng: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        int[] arr = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write("Nhập phần tử arr[{0}]: ", i);
//            arr[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        int tong = 0;
//        for (int i = 0; i < n; i++)
//        {
//            tong += arr[i];
//        }

//        Console.WriteLine("Tổng các phần tử trong mảng là: " + tong);
//    }
//}


////TH10: Sắp xếp chọn (Selection Sort) từ file input_array.txt
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        // Đọc dữ liệu từ file
//        string[] lines = File.ReadAllText("viensayhi.txt").Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
//        int n = lines.Length;
//        int[] arr = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            arr[i] = Convert.ToInt32(lines[i]);
//        }

//        // Selection Sort
//        for (int i = 0; i < n - 1; i++)
//        {
//            int minIndex = i;
//            for (int j = i + 1; j < n; j++)
//            {
//                if (arr[j] < arr[minIndex])
//                {
//                    minIndex = j;
//                }
//            }
//            // Hoán đổi
//            int temp = arr[i];
//            arr[i] = arr[minIndex];
//            arr[minIndex] = temp;
//        }

//        Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
//        foreach (int num in arr)
//        {
//            Console.Write(num + " ");
//        }
//    }
//}

// TH11:
using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập số phần tử mảng: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n + 1]; // +1 để chèn thêm phần tử

        Console.WriteLine("Nhập mảng đã sắp xếp tăng dần:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Nhập số nguyên cần chèn: ");
        int x = Convert.ToInt32(Console.ReadLine());

        int pos = n; // mặc định chèn cuối
        for (int i = 0; i < n; i++)
        {
            if (x < arr[i])
            {
                pos = i;
                break;
            }
        }

        // Dời phần tử sang phải
        for (int i = n; i > pos; i--)
        {
            arr[i] = arr[i - 1];
        }
        arr[pos] = x;
        n++;

        Console.WriteLine("Mảng sau khi chèn:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

