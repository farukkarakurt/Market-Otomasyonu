using Market_Otomasyonu.dao;
using Market_Otomasyonu.enumaration;
using Market_Otomasyonu.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Otomasyonu.Controller
{
    public class UserController
    {
        Repository repository;


        public UserController()
        {
            repository = new Repository();

        }
        public User login(string kullaniciAdi, string sifre)
        {
            User result;
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                result = repository.login(kullaniciAdi, sifre);

                return result;
            }
            else
            {
                User user = new User();
                user.status = LoginStatus.Eksik_Bilgi;
                return user;

            }
        }

        public List<LoginTable> getLoginTable()
        {
            List<LoginTable> loginTableList = repository.getLoginTables();

            return loginTableList;
        }


        public LoginStatus doAuthentication(string kullaniciAdi, string guvenlikSorusu, string guvenlikCevabi)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(guvenlikSorusu) && !string.IsNullOrEmpty(guvenlikCevabi))
            {
                LoginStatus result = repository.doAuthentication(kullaniciAdi, guvenlikSorusu, guvenlikCevabi);

                if (result == LoginStatus.Başarılı)
                {
                    return result;
                }
                else
                {
                    return LoginStatus.Başarısız;
                }
            }
            else
            {
                return LoginStatus.Eksik_Bilgi;
            }


        }

        public LoginStatus changePassword(string kullaniciAdi, string sifre)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                return repository.changePassword(kullaniciAdi, sifre);
            }
            else
            {
                return LoginStatus.Eksik_Bilgi;
            }
        }

        public string checkEmailAdress(string kullaniciAdi)
        {
            return repository.checkEmailAdress(kullaniciAdi);

        }

        public Urun urunuGetir(string barkod)
        {
            if (!string.IsNullOrEmpty(barkod))
            {
                return repository.urunuGetir(barkod);
            }
            return null;
        }
        public List<User> tumKullanicilariGetir()
        {
            return repository.tumKullanicilariGetir();
        }

        public LoginStatus KullaniciEkle(User user)
        {

            if (!string.IsNullOrEmpty(user.kulaniciAdi) && !string.IsNullOrEmpty(user.sifre) && !string.IsNullOrEmpty(user.email) && !string.IsNullOrEmpty(user.guvenlikSorusu) && !string.IsNullOrEmpty(user.guvenlikCevabi))
            {
                UserController controller = new UserController();
                LoginStatus sonuc = repository.KullaniciEkle(user);
                return sonuc;
            }
            else
            {
                return LoginStatus.Eksik_Bilgi;
            }
        }
        public LoginStatus KayitGuncelleme(User user)
        {
            return repository.KayitGuncelleme(user);
        }

        public LoginStatus KayitlariSil(int id)
        {
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                return repository.KayitlariSil(id);
            }
            else
            {
                return LoginStatus.Eksik_Bilgi;
            }
        }

        public List<Urun> tumUrunleriGetir()
        {

            return repository.tumUrunleriGetir();
        }


        public LoginStatus urunEkle(Urun urun)
        {
            if (!string.IsNullOrEmpty(urun.id) && !string.IsNullOrEmpty(urun.UrunIsim) && !string.IsNullOrEmpty(urun.barkod))
            {
                return repository.urunEkle(urun);
            }
            else
            {
                return LoginStatus.Eksik_Bilgi;
            }
        }

        public LoginStatus UrunGuncelle(Urun urun)
        {
            if (!string.IsNullOrEmpty(urun.id) && !string.IsNullOrEmpty(urun.UrunIsim) && !string.IsNullOrEmpty(urun.barkod))
            {
                return repository.UrunGuncelle(urun);
            }
            else
            {
                return LoginStatus.Eksik_Bilgi;
            }

        }

        public LoginStatus UrunSilme(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                return repository.UrunSilme(id);
            }
            else
            {
                return LoginStatus.Eksik_Bilgi;   
            }
        }




    }
}
