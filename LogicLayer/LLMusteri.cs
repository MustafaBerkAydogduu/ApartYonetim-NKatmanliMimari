using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class LLMusteri
    {

        public static List<EntityMusteri> LLMusteriListele()
        {
            return DalMusteri.musteriListele();
        }

        public static bool LLMusteriSil(int id)
        {
            if(id > 0)
            {
                return DalMusteri.musteriSil(id);
            }
            else
            {
                return false;
            }
        }


        public static int LLMusteriEkle(EntityMusteri e)
        {
            if(e.Ad_soyad != "" && e.Tel_no != "")
            {
                return DalMusteri.musteriEkle(e);
            }
            else
            {
                return -1;
            }
        }

        public static bool LLMusteriGuncelle(EntityMusteri e)
        {
            if (e.Ad_soyad != "" && e.Tel_no != "")
            {
                return DalMusteri.musteriGuncelle(e);
            }
            else
            {
                return false;
            }
        }




    }
}
