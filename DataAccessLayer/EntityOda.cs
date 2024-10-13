using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EntityOda
    {
        int id;
        string oda_no;
        string durum;
        int musteri_no;

        public int ID { get => id; set => id = value; }
        public string Oda_no { get => oda_no; set => oda_no = value; }
        public string Durum { get => durum; set => durum = value; }
        public int Musteri_no { get => musteri_no; set => musteri_no = value; }
    }
}
