using System;

class Karyawan
{
    private string nama;
    private string id;
    private double gajiPokok;

    // Constructor
    public Karyawan(string nama, string id, double gajiPokok)
    {
        this.nama = nama;
        this.id = id;
        this.gajiPokok = gajiPokok;
    }

    // Getter dan Setter
    public string Nama
    {
        get { return nama; }
        set { nama = value; }
    }

    public string ID
    {
        get { return id; }
        set { id = value; }
    }

    public double GajiPokok
    {
        get { return gajiPokok; }
        set { gajiPokok = value; }
    }

    // Virtual method
    public virtual double HitungGaji()
    {
        return gajiPokok;
    }
}

class KaryawanTetap : Karyawan
{
    public KaryawanTetap(string nama, string id, double gajiPokok)
        : base(nama, id, gajiPokok) { }

    public override double HitungGaji()
    {
        return GajiPokok + 500000;
    }
}

class KaryawanKontrak : Karyawan
{
    public KaryawanKontrak(string nama, string id, double gajiPokok)
        : base(nama, id, gajiPokok) { }

    public override double HitungGaji()
    {
        return GajiPokok - 200000;
    }
}

class KaryawanMagang : Karyawan
{
    public KaryawanMagang(string nama, string id, double gajiPokok)
        : base(nama, id, gajiPokok) { }

    public override double HitungGaji()
    {
        return GajiPokok;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Sistem Manajemen Karyawan ===");
        Console.WriteLine("Pilih Jenis Karyawan:");
        Console.WriteLine("1. Karyawan Tetap");
        Console.WriteLine("2. Karyawan Kontrak");
        Console.WriteLine("3. Karyawan Magang");

        Console.Write("Masukkan pilihan (1/2/3): ");
        string pilihan = Console.ReadLine();

        Console.Write("Masukkan Nama Karyawan : ");
        string nama = Console.ReadLine();
        Console.Write("Masukkan ID Karyawan   : ");
        string id = Console.ReadLine();
        Console.Write("Masukkan Gaji Pokok    : ");
        double gajiPokok = Convert.ToDouble(Console.ReadLine());

        Karyawan karyawan;
        string jenis = "";

        switch (pilihan)
        {
            case "1":
                karyawan = new KaryawanTetap(nama, id, gajiPokok);
                jenis = "Karyawan Tetap";
                break;
            case "2":
                karyawan = new KaryawanKontrak(nama, id, gajiPokok);
                jenis = "Karyawan Kontrak";
                break;
            case "3":
                karyawan = new KaryawanMagang(nama, id, gajiPokok);
                jenis = "Karyawan Magang";
                break;
            default:
                Console.WriteLine("Pilihan tidak valid!");
                return;
        }

        Console.WriteLine("\n=== Data Karyawan ===");
        Console.WriteLine("Jenis Karyawan : " + jenis);
        Console.WriteLine("Nama           : " + karyawan.Nama);
        Console.WriteLine("ID             : " + karyawan.ID);
        Console.WriteLine("Gaji Pokok     : Rp " + karyawan.GajiPokok.ToString("N2"));
        Console.WriteLine("Gaji Akhir     : Rp " + karyawan.HitungGaji().ToString("N2"));
    }
}
