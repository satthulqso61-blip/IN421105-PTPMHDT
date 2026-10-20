using System;
using EduHub.Ch01.Domain;
namespace EduHub.Ch01;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("--- DEMO LUỒNG NGHIỆP VỤ HỆ THỐNG EDUHUB ---");

        try
        {
            Adviser gv = Adviser.Create("Nguyễn Văn A", "Khoa Công nghệ thông tin");
            Console.WriteLine($"Tạo giảng viên: {gv.Name} - {gv.Department}");

            Sponsor ntt = Sponsor.Create("Công ty TNHH Phần mềm ABC");
            Console.WriteLine($"Tạo nhà tài trợ: {ntt.CompanyName}");

            SponsorshipContract hd = SponsorshipContract.Create(ntt.Id, 15000000);
            Console.WriteLine($"Tạo hợp đồng tài trợ thành công. Số tiền: {hd.FundingAmount:N0} VNĐ");

            FundManager tq = FundManager.Create("DTH210001");
            Console.WriteLine($"Tạo thủ quỹ MSSV: {tq.StudentId}");

            FundReport bc = FundReport.Create(tq.Id, 2500000);
            Console.WriteLine($"Tạo báo cáo quỹ. Số dư hiện tại: {bc.TotalBalance:N0} VNĐ");

            Console.WriteLine("\n--- THỬ NGHIỆM KIỂM TRA LỖI DỮ LIỆU ---");
            SponsorshipContract.Create(ntt.Id, -500000);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Báo lỗi hệ thống: {ex.Message}");
        }

        Console.WriteLine("\nChạy thử nghiệm chương trình hoàn tất không có lỗi crash.");
    }
}

