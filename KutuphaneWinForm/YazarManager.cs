using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneWinForm;
internal class YazarManager
{
    public void YazarEkle(Yazar yazar)
    {
        using(SqlConnection connection = DbConnection.GetConnection())
        {
            string query = "insert into Yazarlar (Adi,Soyadi,DogumYili,DogumYeri) values (@adi,@soyadi,@dogumYili,@dogumYeri)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@dogumYeri", yazar.DogumYeri);
            cmd.Parameters.AddWithValue("@adi", yazar.Adi);
            cmd.Parameters.AddWithValue("@soyadi", yazar.Soyadi);
            cmd.Parameters.AddWithValue("@dogumYili", yazar.DogumYili);
            connection.Open();
            cmd.ExecuteNonQuery();

            
        }
    }

    public void YazarGuncelle(Yazar yazar)
    {
        using (SqlConnection connection = DbConnection.GetConnection())
        {
            string query =
                @"update Yazarlar set Adi=@adi, Soyadi=@soyadi, DogumYili=@dogumYili, DogumYeri=@dogumYeri where Id=@id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", yazar.Id);
            cmd.Parameters.AddWithValue("@adi", yazar.Adi);
            cmd.Parameters.AddWithValue("@soyadi", yazar.Soyadi);
            cmd.Parameters.AddWithValue("@DogumYeri", yazar.DogumYeri);
            cmd.Parameters.AddWithValue("@dogumYili", yazar.DogumYili);

            connection.Open(); 
            cmd.ExecuteNonQuery();
        }
    }

    public void YazarGuncelle2(int id, string ad, string soyad, string dogumYeri, DateTime dogumYili)
    {
        using (SqlConnection connection = DbConnection.GetConnection())
        {
            string query =
                @"update Yazarlar set Adi=@adi, Soyadi=@soyadi, DogumYili=@dogumYili, DogumYeri=@dogumYeri where Id=@id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@adi", ad);
            cmd.Parameters.AddWithValue("@soyadi", soyad);
            cmd.Parameters.AddWithValue("@DogumYeri", dogumYeri);
            cmd.Parameters.AddWithValue("@dogumYili", dogumYili);

            connection.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public void YazarSil(int id)
    {
        using (SqlConnection conn = DbConnection.GetConnection())
        {
            string query = "Delete from Yazarlar where Id=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
    public void YazarSil(Yazar yazar)
    {
        using (SqlConnection conn = DbConnection.GetConnection())
        {
            string query = "Delete from Yazarlar where Id=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", yazar.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public List<Yazar> YazarlariListele()
    {
        List<Yazar> yazarlar = new List<Yazar>();
        //yazarlar.Add(
        //    new Yazar() {
        //    Adi = "Erkan",
        //    Soyadi = "Günay",
        //    DogumYeri = "İstanbul",
        //    DogumYili = new DateTime(2000,1,1),
        //    Id = 1
        //});
        //yazarlar.Add(new Yazar()
        //{
        //    Adi = "Muhammed",
        //    Soyadi = "Saka",
        //    DogumYeri = "İstanbul",
        //    DogumYili = new DateTime(2000, 1, 1),
        //    Id = 1
        //});
        //yazarlar.Add(new Yazar()
        //{
        //    Adi = "Akın",
        //    Soyadi = "Cengiz",
        //    DogumYeri = "İstanbul",
        //    DogumYili = new DateTime(),
        //    Id = 1
        //});

        using (SqlConnection connection = DbConnection.GetConnection())
        {
            SqlCommand command = new SqlCommand("SELECT * from Yazarlar", connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                Yazar yazar = new Yazar();
                yazar.Id = (int)reader["Id"];
                yazar.Adi = reader["Adi"].ToString();
                yazar.Soyadi = reader["Soyadi"].ToString();
                yazar.DogumYeri = reader["DogumYeri"].ToString();
                yazar.DogumYili = (reader["DogumYili"] != DBNull.Value) ? Convert.ToDateTime(reader["DogumYili"].ToString()) : new DateTime();
                yazarlar.Add(yazar);
            }

        }

        return yazarlar;
    }

    public Yazar YazarGetirIdIle(int id)
    {
        Yazar yazar = null;
        using (SqlConnection conn = DbConnection.GetConnection())
        {
            SqlCommand cmd = new SqlCommand("SELECT * from Yazarlar where Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                yazar = new Yazar();
                yazar.Id = (int)reader["Id"];
                yazar.Adi = reader["Adi"].ToString();
                yazar.Soyadi = reader["Soyadi"].ToString();
                yazar.DogumYeri = reader["DogumYeri"].ToString();
                yazar.DogumYili = Convert.ToDateTime(reader["DogumYili"]);
            }
        }

        return yazar;
    }
}
//insert into Yazarlar (Adi,Soyadi,DogumYili,DogumYeri) values (Akın,Cengiz,1981,İstanbul)