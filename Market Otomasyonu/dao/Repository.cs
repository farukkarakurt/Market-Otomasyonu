using Market_Otomasyonu.Controller;
using Market_Otomasyonu.enumaration;
using Market_Otomasyonu.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.dao
{
    public class Repository
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        int returnValues;
        List<LoginTable> loginTablesList;
        public Repository()
        {
            conn = new SqlConnection("Data Source=FARUK\\SQLEXPRESS;Initial Catalog=MarketOtomasyonu;User ID=sa;Password=1");
        }

        User user = new User();

        public void baglantiAyarla()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            else
            {
                conn.Close();
            }
        }

        public User login(string kullaniciAdi, string sifre)
        {

            conn.Open();

            cmd = new SqlCommand("select * from LoginTable where kullaniciAdi=@kullaniciAdi and sifre=@sifre", conn);
            cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                User user = new User();
                user.id = int.Parse(dr["id"].ToString());
                user.kulaniciAdi = dr["kullaniciAdi"].ToString();
                user.sifre = dr["sifre"].ToString();
                user.yetki = dr["yetki"].ToString();
                user.email = dr["email"].ToString();
                user.guvenlikSorusu = dr["guvenlikSorusu"].ToString();
                user.guvenlikCevabi = dr["guvenlikCevabi"].ToString();
                user.status = LoginStatus.Başarılı;
                return user;
            }
            else
            {
                User user = new User();
                user.status = LoginStatus.Başarısız;
                return user;
            }
            conn.Close();

        }


        public List<LoginTable> getLoginTables()
        {
            loginTablesList = new List<LoginTable>();
            conn.Open();

            cmd = new SqlCommand("guvenlikSorusuGetir_sp", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LoginTable loginTable = new LoginTable();
                loginTable.id = int.Parse(dr["id"].ToString());
                loginTable.kullaniciAdi = dr["kullaniciAdi"].ToString();
                loginTable.sifre = dr["sifre"].ToString();
                loginTable.yetki = dr["yetki"].ToString();
                loginTable.email = dr["email"].ToString();
                loginTable.guvenlikSorusu = dr["guvenlikSorusu"].ToString();
                loginTable.guvenlikCevabi = dr["guvenlikCevabi"].ToString();
                loginTablesList.Add(loginTable);
            }
            conn.Close();

            return loginTablesList;

        }


        public LoginStatus doAuthentication(string kullaniciAdi, string guvenlikSorusu, string guvenlikCevabi)
        {
            conn.Open();

            cmd = new SqlCommand("select count(*) from LoginTable where kullaniciAdi=@kullaniciAdi and guvenlikSorusu=@guvenlikSorusu and guvenlikCevabi=@guvenlikCevabi", conn);
            cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@guvenlikSorusu", guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvenlikCevabi", guvenlikCevabi);
            int returnValue = (int)cmd.ExecuteScalar();

            conn.Close();

            if (returnValue == 1)
            {
                return LoginStatus.Başarılı;
            }
            else
            {
                return LoginStatus.Başarısız;
            }

        }


        public LoginStatus changePassword(string kullaniciAdi, string sifre)
        {
            conn.Open();

            cmd = new SqlCommand("sifreGuncelle_sp", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            returnValues = cmd.ExecuteNonQuery();
            conn.Close();

            return LoginStatus.Başarılı;

        }


        public string checkEmailAdress(string kullaniciAdi)
        {
            conn.Open();

            cmd = new SqlCommand("select email from LoginTable where kullaniciAdi=@kullaniciAdi", conn);
            cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            string email = cmd.ExecuteScalar().ToString();

            conn.Close();

            return email;
        }


        public Urun urunuGetir(string barkod)
        {
            conn.Open();

            cmd = new SqlCommand("select*from urun where barkod=@barkod", conn);
            cmd.Parameters.AddWithValue("@barkod", barkod);
            dr = cmd.ExecuteReader();
            Urun urun = new Urun();
            while (dr.Read())
            {

                urun.id = dr["id"].ToString();
                urun.qrKod = dr["qrKod"].ToString();
                urun.barkod = dr["barkod"].ToString();
                urun.UrunIsim = dr["UrunIsim"].ToString();
                urun.kilo = int.Parse(dr["kilo"].ToString());
                urun.fiyat = int.Parse(dr["fiyat"].ToString());

            }
            conn.Close();
            return urun;
        }

        public List<User> tumKullanicilariGetir()
        {
            List<User> kullanıcıGetirmek = new List<User>();

            conn.Open();
            cmd = new SqlCommand("select * from LoginTable", conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                User user = new User();
                user.id = int.Parse(dr["id"].ToString());
                user.kulaniciAdi = dr["kullaniciAdi"].ToString();
                user.sifre = dr["sifre"].ToString();
                user.yetki = dr["yetki"].ToString();
                user.bolge = dr["bolge"].ToString();
                user.email = dr["email"].ToString();
                user.guvenlikSorusu = dr["guvenlikSorusu"].ToString();
                user.guvenlikCevabi = dr["guvenlikCevabi"].ToString();
                kullanıcıGetirmek.Add(user);
            }
            conn.Close();

            return kullanıcıGetirmek;
        }


        public LoginStatus KullaniciEkle(User user)
        {
            conn.Open();

            cmd = new SqlCommand("sp_KayitalariGetir", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciAdi", user.kulaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", user.sifre);
            cmd.Parameters.AddWithValue("@yetki", user.yetki);
            cmd.Parameters.AddWithValue("@bolge", user.bolge);
            cmd.Parameters.AddWithValue("@email", user.email);
            cmd.Parameters.AddWithValue("@guvenlikSorusu", user.guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvenlikCevabi", user.guvenlikCevabi);
            int returnValues = cmd.ExecuteNonQuery();
            conn.Close();

            if (returnValues == 1)
            {
                return LoginStatus.Başarılı;
            }
            else
            {
                return LoginStatus.Başarısız;
            }
        }

        public LoginStatus KayitGuncelleme(User user)
        {
            conn.Open();

            cmd = new SqlCommand("sp_KayitlariGuncelle", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", user.id);
            cmd.Parameters.AddWithValue("@kullaniciAdi", user.kulaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", user.sifre);
            cmd.Parameters.AddWithValue("@yetki", user.yetki);
            cmd.Parameters.AddWithValue("@bolge", user.bolge);
            cmd.Parameters.AddWithValue("@email", user.email);
            cmd.Parameters.AddWithValue("@guvenlikSorusu", user.guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvenlikCevabi", user.guvenlikCevabi);
            int returnValues = cmd.ExecuteNonQuery();

            conn.Close();

            if (returnValues == 1)
            {
                return LoginStatus.Başarılı;
            }
            return LoginStatus.Başarısız;

        }

        public LoginStatus KayitlariSil(int id)
        {
            conn.Open();
            cmd = new SqlCommand("Delete from LoginTable where id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            int returnValues = cmd.ExecuteNonQuery();
            conn.Close();

            if (returnValues == 1)
            {
                return LoginStatus.Başarılı;
            }
            else
            {
                return LoginStatus.Başarısız;
            }

        }

        public List<Urun> tumUrunleriGetir()
        {
            List<Urun> UrunList = new List<Urun>();
            conn.Open();
            cmd = new SqlCommand("select * from urun", conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Urun urun = new Urun();
                urun.id = dr["id"].ToString();
                urun.qrKod = dr["qrKod"].ToString();
                urun.barkod = dr["barkod"].ToString();
                urun.olusturulma_tarihi = DateTime.Parse(dr["olusturulma_tarihi"].ToString());

                //if (!string.IsNullOrEmpty(dr["guncellem_Tarih"].ToString()))
                //{
                //    urun.guncellem_Tarih = DateTime.Parse(dr["guncellem_Tarih"].ToString());
                //}
                urun.UrunIsim = dr["UrunIsim"].ToString();
                urun.kilo = int.Parse(dr["kilo"].ToString());
                urun.fiyat = int.Parse(dr["fiyat"].ToString());
                urun.ciro = int.Parse(dr["ciro"].ToString());

                UrunList.Add(urun);
            }
            conn.Close();

            return UrunList;
        }

        public LoginStatus urunEkle(Urun urun)
        {
            conn.Open();
            cmd = new SqlCommand("sp_UrunEkle", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", urun.id);
            cmd.Parameters.AddWithValue("qrKod", urun.qrKod);
            cmd.Parameters.AddWithValue("@barkod", urun.barkod);
            cmd.Parameters.AddWithValue("@olusturulma_Tarih", urun.olusturulma_tarihi);
            cmd.Parameters.AddWithValue("@guncellem_Tarih", urun.guncellem_Tarih);
            cmd.Parameters.AddWithValue("UrunIsim", urun.UrunIsim);
            cmd.Parameters.AddWithValue("@kilo", urun.kilo);
            cmd.Parameters.AddWithValue("@fiyat", urun.fiyat);
            cmd.Parameters.AddWithValue("@ciro", urun.ciro);
            int returnValues = cmd.ExecuteNonQuery();
            conn.Close();

            if (returnValues == 1)
            {
                return LoginStatus.Başarılı;
            }
            return LoginStatus.Başarısız;
        }


        public LoginStatus UrunGuncelle(Urun urun)
        {
            conn.Open();

            cmd = new SqlCommand("sp_UrunGuncelle", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", urun.id);
            cmd.Parameters.AddWithValue("qrKod", urun.qrKod);
            cmd.Parameters.AddWithValue("@barkod", urun.barkod);
            cmd.Parameters.AddWithValue("@olusturulma_Tarih", urun.olusturulma_tarihi);
            cmd.Parameters.AddWithValue("@guncellem_Tarih", urun.guncellem_Tarih);
            cmd.Parameters.AddWithValue("UrunIsim", urun.UrunIsim);
            cmd.Parameters.AddWithValue("@kilo", urun.kilo);
            cmd.Parameters.AddWithValue("@fiyat", urun.fiyat);
            cmd.Parameters.AddWithValue("@ciro", urun.ciro);
            int returnValues = cmd.ExecuteNonQuery();
            conn.Close();

            if (returnValues == 1)
            {
                return LoginStatus.Başarılı;
            }
            else
            {
                return LoginStatus.Başarısız;

            }
        }

        public LoginStatus UrunSilme(string id)
        {
            conn.Open();
            cmd = new SqlCommand("delete from urun where id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            int returnValues = cmd.ExecuteNonQuery();
            conn.Close();

            if (returnValues == 1)
            {
                return LoginStatus.Başarılı;
            }
            else
            {
                return LoginStatus.Başarısız;
            }
            
        }

    }

}