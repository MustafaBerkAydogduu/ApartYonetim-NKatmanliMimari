using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EntityMusteri
    {
        int id;
        string ad_soyad;
        int oda_no;
        string tel_no;

        public int ID { get => id; set => id = value; }
        public string Ad_soyad { get => ad_soyad; set => ad_soyad = value; }
        public int Oda_no { get => oda_no; set => oda_no = value; }
        public string Tel_no { get => tel_no; set => tel_no = value; }
    }
}
