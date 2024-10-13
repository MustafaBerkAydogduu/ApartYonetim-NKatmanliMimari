using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class LLOda
    {

        public static List<EntityOda> LLOdaListele()
        {
            return DALOda.odaListele();
        }

        public static bool LLOdaSil(int id)
        {
            if(id > 0)
            {
                return DALOda.odaSil(id);
            }
            else
            {
                return false;
            }
        }

        public static int LLOdaEkle(EntityOda e)
        {
            if( e.Durum !="" && e.Oda_no !="")
            {
                return DALOda.odaEkle(e);
            }
            else
            {
                return -1;
            }
        }

        public static bool LLOdaGuncelle(EntityOda e)
        {
            if (e.ID > 0 && e.Durum != "" && e.Oda_no != "")
            {
                return DALOda.odaGuncelle(e);
            }
            else
            {
                return false;
            }
        }





    }
}
