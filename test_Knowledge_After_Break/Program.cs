using System;
using System.CodeDom;
using System.Data;

namespace baitpapTest
{

    interface hoTro
    {
         decimal soTienHoTro();
    }
    abstract internal class HopDongCaSi
    {
        protected string maHopDong;
        protected string tenCaSi;
        protected int soTietMucBieuDien;
        protected string ngayBieuDien;
        protected decimal donGia;
        protected decimal phuPhi;
        public string MaHopDong
        {
            set
            {
                maHopDong = value;
                bool checkTrue = true;
                foreach (char temp in value.Substring(2, 3))
                {
                    if (!char.IsDigit(temp))
                        checkTrue = false;
                }

                if (!(value.Length == 6) || !(value.StartsWith("HD") && checkTrue))
                {
                    throw new Exception("Loi");
                }
            }
                  
            get => maHopDong; 
        }
        public string TenCaSi { set => tenCaSi = value; get => tenCaSi; }
        public int SoTietMucBieuDien { get => soTietMucBieuDien; set => soTietMucBieuDien = value; }
        public string NgayBieuDien { get => ngayBieuDien; set => ngayBieuDien = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }
        public decimal PhuPhi { get => phuPhi; set => phuPhi = value; }

        //constructor

        // 3
        
        public HopDongCaSi()
        {
            this.maHopDong = "HD3418";
            this.tenCaSi = "Ly Khong Hay";
            this.soTietMucBieuDien = 3;
            this.ngayBieuDien = "24/10/2020";
            this.donGia = 4000000M;
            this.phuPhi = 2000000M;
        }

        //4

        public HopDongCaSi(string maHopDong, string tenCaSi, decimal donGia)

        {
            this.maHopDong = maHopDong;
            this.tenCaSi = tenCaSi;
            soTietMucBieuDien = 2;
            ngayBieuDien = "24/12/2020";
            this.donGia = donGia;
            phuPhi = 0M;
        }
        abstract public decimal quangCao();
        virtual public decimal thanhTien()
        {
            return donGia * soTietMucBieuDien + phuPhi + quangCao();
        }

        virtual public decimal thue()
        {
            return 0.15M * thanhTien();
        }

    }


    #region hopDongBieuDien_taiNHa
    /// <summary>
    /// inherited by abstract class hopDongCaSi and hoTro interface
    /// </summary>
    internal class BieuDienTaiNha : HopDongCaSi
    {
        private decimal khoangCach;
        public decimal KhoangCach { get => khoangCach; set => khoangCach = value; }
        override public decimal quangCao()
        {
            if (khoangCach < 20)
                return  (decimal)(400000M * khoangCach);
            else if ((khoangCach * 300000) < 15000000)
                return (300000M* khoangCach);
            return 15000000M;

        }
    }
    #endregion

    #region hopDongBieuDien_taiRapNho
    internal class BieuDienTaiRapNho : HopDongCaSi, hoTro
    {
        private int quiMo;

        public int QuiMo
        {
            get => quiMo;
            set => quiMo = value;
        }
        override public decimal quangCao()
        {
            return 10000000M + 2000000M * soTietMucBieuDien; 
        }

        public decimal soTienHoTro()
        {
            if( 1 <= quiMo || quiMo <= 3)
            {
                return 1000000;
            }
            return 0;
        }
        public override decimal thanhTien()
        {
            return base.thanhTien() - soTienHoTro();
        }
    }
    #endregion
    internal class BieuDienTaiRapLon: HopDongCaSi, hoTro
    {
        private decimal khanGia;

        public decimal KhanGia { get => khanGia; set => khanGia = value; }

        override public decimal quangCao()
        {
            if (KhanGia < 1000000)
                return 30000000M;
            return 50000000M;
        }

        public decimal soTienHoTro()
        {
            if (KhanGia < 2000000)
                return ((int)KhanGia % 100000) * 1000000M;
            return 20000000;
        }
        public override decimal thanhTien()
        {
            return base.thanhTien() - soTienHoTro();
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            HopDongCaSi a = new BieuDienTaiNha();
            

            Console.ReadKey();
        }
    }
}