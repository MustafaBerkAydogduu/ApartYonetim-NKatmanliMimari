using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class DalMusteri
    {

        public static List<EntityMusteri> musteriListele()
        {
            List<EntityMusteri> musteriList = new List<EntityMusteri>();

            SqlCommand cmd = new SqlCommand("Select * From MUSTERİ", Baglanti.baglanti);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                EntityMusteri e =new EntityMusteri();
                e.ID = int.Parse(dr["ID"].ToString());
                e.Ad_soyad = dr["ADSOYAD"].ToString();
                e.Oda_no = int.Parse(dr["ODANO"].ToString());
                e.Tel_no = dr["TELNO"].ToString();
                musteriList.Add(e);
            }
            cmd.Connection.Close();
            return musteriList;
        }

        public static int musteriEkle(EntityMusteri e)
        {
            SqlCommand cmd = new SqlCommand("insert into MUSTERİ(ADSOYAD,ODANO,TELNO) values(@p1,@p2,@p3)",Baglanti.baglanti);
            
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1",e.Ad_soyad);
            cmd.Parameters.AddWithValue("@p2",e.Oda_no);
            cmd.Parameters.AddWithValue("@p3",e.Tel_no);
            return cmd.ExecuteNonQuery();
        }

        public static bool musteriSil(int id)
        {

            SqlCommand cmd = new SqlCommand("Delete from MUSTERİ where ID=@p1",Baglanti.baglanti);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            cmd.Parameters.AddWithValue("@p1",id);
            
            return cmd.ExecuteNonQuery() >0;
        }

        public static bool musteriGuncelle(EntityMusteri e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE MUSTERİ Set ADSOYAD=@p1,ODANO=@p2,TELNO=@p3 where ID=@p4", Baglanti.baglanti);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1",e.Ad_soyad);
            cmd.Parameters.AddWithValue("@p2",e.Oda_no);
            cmd.Parameters.AddWithValue("@p3",e.Tel_no);
            cmd.Parameters.AddWithValue("@p4",e.ID);
            
            return cmd.ExecuteNonQuery() >0;
        }
    }
}
