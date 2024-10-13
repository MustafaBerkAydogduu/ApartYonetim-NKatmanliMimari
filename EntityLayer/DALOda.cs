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
    public class DALOda
    {

        public static List<EntityOda> odaListele()
        {
            List<EntityOda> listOda= new List<EntityOda>();
            SqlCommand cmd = new SqlCommand("Select * From ODA",Baglanti.baglanti);
            if(cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) 
            {
                EntityOda entityOda = new EntityOda();
                entityOda.ID = byte.Parse(dr["ID"].ToString());
                entityOda.Durum= dr["DURUM"].ToString();
                entityOda.Oda_no= dr["ODANO"].ToString();
                entityOda.Musteri_no= int.Parse(dr["MUSTERİNO"].ToString());
                listOda.Add(entityOda);
            }
            cmd.Connection.Close();
            return listOda;
        }
         

        public static bool odaGuncelle(EntityOda e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE ODA SET DURUM=@p1,ODANO=@p2,MUSTERİNO=@p3 where ID=@p4",Baglanti.baglanti);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            cmd.Parameters.AddWithValue("@p1",e.Durum);
            cmd.Parameters.AddWithValue("@p2",e.Oda_no);
            cmd.Parameters.AddWithValue("@p3",e.Musteri_no);
            cmd.Parameters.AddWithValue("@p4",e.ID);

            
            return cmd.ExecuteNonQuery() > 0;
        }

        public static int odaEkle(EntityOda e)
        {
            SqlCommand cmd = new SqlCommand("insert into ODA(DURUM,ODANO,MUSTERİNO) values(@p1,@p2,@p3)", Baglanti.baglanti);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", e.Durum);
            cmd.Parameters.AddWithValue("@p2", e.Oda_no);
            cmd.Parameters.AddWithValue("@p3", e.Musteri_no);
            
            return cmd.ExecuteNonQuery();

        }

        public static bool odaSil(int id)
        {

            SqlCommand cmd = new SqlCommand("Delete from ODA where ID=@p1",Baglanti.baglanti);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            cmd.Parameters.AddWithValue("@p1", id);
            
            return cmd.ExecuteNonQuery() > 0;
        }


    }
}
