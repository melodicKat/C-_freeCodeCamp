using System;
using System.Collections;
using System.Text;

namespace sinhVienCls
{
    internal class sinhvien : IComparer
    {
        public int age { get; set; }
        public decimal avr { get; set; }
        public string name { get; set; }

        public sinhvien()
        {

        }
        public sinhvien(int age, decimal avr, string name)
        {
            this.age = age;
            this.avr = avr;
            this.name = name;
        }

        public override string ToString()
        {
            return $"std name : {this.name} / avr : {this.avr} / age : {this.age}";
        }

        public int Compare(object a, object b)
        {
            sinhvien x = a as sinhvien;
            sinhvien y = b as sinhvien;

            return x.age.CompareTo(y.age);
        }

    }
    internal class personCompare : IComparer
    {
        public int Compare(object a, object b)
        {
            sinhvien x = a as sinhvien;
            sinhvien y = b as sinhvien;

            return decimal.Compare(x.avr, y.avr);
        }

    }
}