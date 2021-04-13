using System;

namespace ResponsiPemrograman3374
{
    public class Responsi
    {
        class SebuahKantor
        {
            public int nik { get; set; }
            public string namakaryawan { get; set; }
            public int gaji { get; set; }
            public int naikgaji { get; set; }

            public SebuahKantor(int nik, string nama, int gaji)
            {
                this.nik = nik;
                this.namakaryawan = namakaryawan;
                if (gaji < 0)
                {
                    this.gaji = 0;
                }
                else
                {
                    this.gaji = gaji;
                }
                double tmp = 0;
                tmp = 0.1 * gaji;
                naikgaji += Convert.ToInt32(tmp) + gaji;
            }
        }
    }
}

