using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_v.DTO
{
    public class TypeNameAcc
    {
        private string typeNamee;

        public TypeNameAcc() { }
        public TypeNameAcc(DataRow row)
        {
            this.TypeNamee = (string)row["typename"];
        }

        public string TypeNamee
        {
            get
            {
                return typeNamee;
            }

            set
            {
                typeNamee = value;
            }
        }
    }
}
