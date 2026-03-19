using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace KutuphaneWinForm;
internal class KitapManager
{
    public void KitapEkle(Kitap kitap)
    {
        using (SqlConnection connection = DbConnection.GetConnection())
        {
            string query =
                "insert into Kitaplar (Baslik,BasimYili,SayfaSayisi,Stok,YazarId) values (@baslik,@basimYili,@sayfaSayisi,@stok,@yazarId)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@baslik", kitap.Baslik);
            cmd.Parameters.AddWithValue("@basimYili", kitap.BasimYili);
            cmd.Parameters.AddWithValue("@sayfaSayisi", kitap.SayfaSayisi);
            cmd.Parameters.AddWithValue("@stok", kitap.Stok);
            cmd.Parameters.AddWithValue("@yazarId", kitap.YazarId);

            connection.Open();
            cmd.ExecuteNonQuery();

            //context.Add(kitap);
            //context.SaveChanges();
        }
    }

    public void KitapSil(int id)
    {
        using (SqlConnection conn = DbConnection.GetConnection())
        {
            SqlCommand cmd = new SqlCommand("delete from Kitaplar where Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public void KitapSil(Kitap kitap)
    {
        using (SqlConnection conn = DbConnection.GetConnection())
        {
            string query = "delete from Kitaplar where Id=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", kitap.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public void KitapGuncelle(Kitap kitap)
    {

    }

    public List<Kitap> KitaplariListele()
    {
        List<Kitap> kitaplar = new List<Kitap>();
        using (SqlConnection conn = DbConnection.GetConnection())
        {
            //string query = "Select k.Id,k.Baslik,k.BasimYili,k.SayfaSayisi, y.Adi as YazarAdi,y.Soyadi as YazarSoyadi from Kitaplar as k inner join Yazarlar as y on k.YazarId=y.Id";
            string query = "select * from Kitaplar";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Kitap kitap = new Kitap();
                kitap.Id = (int)reader["Id"];
                kitap.Baslik = reader["Baslik"].ToString();
                kitap.BasimYili = (int)reader["BasimYili"];
                kitap.SayfaSayisi = (int)reader["SayfaSayisi"];
                kitap.Stok = (byte)reader["Stok"];

                kitaplar.Add(kitap);
            }
        }

        return kitaplar;
    }

    public Kitap KitapGetirIdIle(int id)
    {
        return null;
    }
}


