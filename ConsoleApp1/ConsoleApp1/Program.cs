using System;
using Newtonsoft.Json;

class Program
{
    static string TinhToanHinhTron(double r)
    {
        if (r <= 0)
        {
            throw new ArgumentException("Bán kính phải lớn hơn 0.");
        }

        var ketQua = new
        {
            dien_tich = Math.PI * r * r,
            chu_vi = 2 * Math.PI * r,
            duong_kinh = 2 * r
        };

        return JsonConvert.SerializeObject(ketQua);
    }

    static void Main(string[] args)
    {
        double r;

        while (true)
        {
            Console.Write("Nhập bán kính r: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out r) && r > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Giá trị nhập vào không hợp lệ.\n");
            }
        }

        try
        {
            string ketQuaJson = TinhToanHinhTron(r);
            Console.WriteLine("Kết quả: " + ketQuaJson);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
        }
    }
}
