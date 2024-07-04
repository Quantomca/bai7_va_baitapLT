using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class SinhVien
{
    public string MSSV { get; set; }
    public string HoTen { get; set; }
    public double DiemToan { get; set; }
    public double DiemLy { get; set; }
    public double DiemHoa { get; set; }

    public double DiemTrungBinh
    {
        get { return (DiemToan + DiemLy + DiemHoa) / 3; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        try
        {
            Console.Write("Nhập số lượng sinh viên: ");
            int soLuongSinhVien = int.Parse(Console.ReadLine());

            for (int i = 0; i < soLuongSinhVien; i++)
            {
                Console.WriteLine($"Nhập thông tin cho sinh viên thứ {i + 1}:");
                SinhVien sv = new SinhVien();

                Console.Write("Mã số sinh viên: ");
                sv.MSSV = Console.ReadLine();

                Console.Write("Họ tên: ");
                sv.HoTen = Console.ReadLine();

                Console.Write("Điểm Toán: ");
                sv.DiemToan = double.Parse(Console.ReadLine());

                Console.Write("Điểm Lý: ");
                sv.DiemLy = double.Parse(Console.ReadLine());

                Console.Write("Điểm Hóa: ");
                sv.DiemHoa = double.Parse(Console.ReadLine());

                danhSachSinhVien.Add(sv);
            }

            HienThiThongTinSinhVien(danhSachSinhVien);
            HienThiSinhVienDauTienTrungBinhLonHon9_5(danhSachSinhVien);
            DemSoSinhVienTrungBinhLonHon5(danhSachSinhVien);
            SapXepTheoDiemTrungBinh(danhSachSinhVien);
            HienThiThongTinSinhVien(danhSachSinhVien);
            SapXepTheoHoTen(danhSachSinhVien);
            HienThiThongTinSinhVien(danhSachSinhVien);

            Console.Write("Nhập tên file để ghi thông tin sinh viên: ");
            string tenFile = Console.ReadLine();
            GhiThongTinSinhVienVaoFile(danhSachSinhVien, tenFile);

            Console.Write("Nhập tên file để đọc thông tin sinh viên: ");
            string tenFileDoc = Console.ReadLine();
            List<SinhVien> danhSachSinhVienDoc = DocThongTinSinhVienTuFile(tenFileDoc);
            HienThiThongTinSinhVien(danhSachSinhVienDoc);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
        }
    }

    static void HienThiThongTinSinhVien(List<SinhVien> danhSachSinhVien)
    {
        Console.WriteLine("Thông tin sinh viên:");
        foreach (var sv in danhSachSinhVien)
        {
            Console.WriteLine($"MSSV: {sv.MSSV}, Họ tên: {sv.HoTen}, Điểm trung bình: {sv.DiemTrungBinh:F2}");
        }
    }

    static void HienThiSinhVienDauTienTrungBinhLonHon9_5(List<SinhVien> danhSachSinhVien)
    {
        foreach (var sv in danhSachSinhVien)
        {
            if (sv.DiemTrungBinh > 9.5)
            {
                Console.WriteLine($"Sinh viên đầu tiên có điểm trung bình > 9.5: {sv.HoTen}, Điểm trung bình: {sv.DiemTrungBinh:F2}");
                break;
            }
        }
    }

    static void DemSoSinhVienTrungBinhLonHon5(List<SinhVien> danhSachSinhVien)
    {
        int count = 0;
        foreach (var sv in danhSachSinhVien)
        {
            if (sv.DiemTrungBinh > 5.0)
            {
                count++;
            }
        }
        Console.WriteLine($"Số sinh viên có điểm trung bình lớn hơn 5.0: {count}");
    }

    static void SapXepTheoDiemTrungBinh(List<SinhVien> danhSachSinhVien)
    {
        danhSachSinhVien.Sort((sv1, sv2) => sv1.DiemTrungBinh.CompareTo(sv2.DiemTrungBinh));
    }

    static void SapXepTheoHoTen(List<SinhVien> danhSachSinhVien)
    {
        danhSachSinhVien.Sort((sv1, sv2) => sv1.HoTen.CompareTo(sv2.HoTen));
    }

    static void GhiThongTinSinhVienVaoFile(List<SinhVien> danhSachSinhVien, string tenFile)
    {
        using (StreamWriter sw = new StreamWriter(tenFile))
        {
            foreach (var sv in danhSachSinhVien)
            {
                sw.WriteLine($"{sv.MSSV},{sv.HoTen},{sv.DiemToan},{sv.DiemLy},{sv.DiemHoa},{sv.DiemTrungBinh:F2}");
            }
        }
    }

    static List<SinhVien> DocThongTinSinhVienTuFile(string tenFile)
    {
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        using (StreamReader sr = new StreamReader(tenFile))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                SinhVien sv = new SinhVien
                {
                    MSSV = data[0],
                    HoTen = data[1],
                    DiemToan = double.Parse(data[2]),
                    DiemLy = double.Parse(data[3]),
                    DiemHoa = double.Parse(data[4])
                };
                danhSachSinhVien.Add(sv);
            }
        }
        return danhSachSinhVien;
    }
}
