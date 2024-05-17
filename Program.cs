internal class Program
{
    private static void Main(string[] args)
    {
        double rate = 23000; // Tỉ giá USD/VND
        double usdAmount;

        // Bước 3: Nhập giá trị USD từ người dùng
        Console.WriteLine("Nhap so tien USD:");
        string input = Console.ReadLine();

        // Kiểm tra xem giá trị nhập vào có phải là số không
        if (!double.TryParse(input, out usdAmount))
        {
            Console.WriteLine("Hay nhap so tien hop le.");
            return;
        }

        // Bước 4: Tính và hiển thị giá trị VND
        double vndAmount = usdAmount * rate;
        Console.WriteLine("Gia tri VND: " + vndAmount.ToString("N0") + " VND");
    }
}


