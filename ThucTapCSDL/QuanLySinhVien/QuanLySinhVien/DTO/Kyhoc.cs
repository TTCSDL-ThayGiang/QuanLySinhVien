using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    public class Kyhoc
    {
        private int maKyHoc;
        private string tenKyHoc;


        public Kyhoc(DataRow row)
        {
            this.MaKyHoc = (int)row["makyhoc"];
            this.TenKyHoc = (string)row["tenhocky"];
        }

        public int MaKyHoc
        {
            get
            {
                return maKyHoc;
            }

            set
            {
                maKyHoc = value;
            }
        }

        public string TenKyHoc
        {
            get
            {
                return tenKyHoc;
            }

            set
            {
                tenKyHoc = value;
            }
        }


    }
}

