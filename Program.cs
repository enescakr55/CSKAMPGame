using CSharp_Oyun.Class;
using System;
using System.Collections.Generic;

namespace CSharp_Oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            GameLibrary gameLibrary = new GameLibrary();
            PlayerManager playerManager = new PlayerManager();
            CampaignManager campaignManager = new CampaignManager();
            GameManager gameManager = new GameManager();
            gameManager.Add(new Game { GameName = "Oyun1", GamePrice = 250 });
            gameManager.Add(new Game { GameName = "Oyun2", GamePrice = 300 });
            gameManager.Add(new Game { GameName = "Oyun3", GamePrice = 400 });
            playerManager.Add(new Player { Ad = "Enes", Soyad = "Çakır", TcNo = "15321246342", DogumYili = "2100" });
            playerManager.Add(new Player { Ad = "Ahmet", Soyad = "Yılmaz", TcNo = "15321246343", DogumYili = "2200" });
            campaignManager.Add(new Campaign { IndirimOrani = 15, KampanyaAdi = "%15 indirim kampanyası" });
            campaignManager.Add(new Campaign { IndirimOrani = 30, KampanyaAdi = "Özel indirim" });
            Console.Clear();
            Console.WriteLine("Test Amaçlı başlangıçta birkaç öğe kayıt edilmiştir");
            while (1 == 1)
            {
                int secim = 0, ksecim=0;
                do
                {
                    Console.WriteLine("-- Panel --\n1)Kullanıcıları Yönet\n2)Oyunları Yönet\n3)Kampanyaları Yönet");
                    try { secim = Convert.ToInt16(Console.ReadLine()); } catch { Console.WriteLine("Bir hata olustu.\nLutfen 1 - 2 -3 sayilarindan birini giriniz."); }
                } while (secim != 1 && secim != 2 && secim != 3);
                Console.Clear();
                switch (secim)
                {
                    case 1:
                        
                        Console.WriteLine("Kullanıcılar\n1)Kullanıcı Ekle\n2)Kullanıcı Sil\n3)Kullanıcıları Listele\n4)Kullanıcının kütüphanesine oyun ekle\n5)Kullanıcının oyunlarını listele");
                        ksecim = Convert.ToInt32(Console.ReadLine());
                        switch (ksecim)
                        {
                            case 1:
                                Console.WriteLine("TC No:");
                                string tc = Console.ReadLine();
                                Console.WriteLine("Ad:");
                                string ad = Console.ReadLine();
                                Console.WriteLine("Soyad:");
                                string soyad = Console.ReadLine();
                                Console.WriteLine("Doğum yılı:");
                                string dogumYili = Console.ReadLine();
                                Player player = new Player { TcNo = tc, Ad = ad, Soyad = soyad, DogumYili = dogumYili };
                                playerManager.Add(player);
                                break;
                            case 2:
                                
                                playerManager.Show();
                                Console.WriteLine("Silinecek kullanicinin ID sini giriniz : ");
                                playerManager.DeletewithId(Convert.ToInt32(Console.ReadLine()));
                                break;
                            case 3:
                                playerManager.Show();
                                break;
                            case 4:
                                Console.Clear();
                                int oyuncuid = -1;
                                int oyunid = -1;
                                int kampanyaid = -1;
                                playerManager.Show();
                                Console.WriteLine("Oyun eklenecek kullanıcı Id sini giriniz");
                                oyuncuid = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                gameManager.Show();
                                Console.WriteLine("Eklenecek oyunu seçiniz");
                                oyunid = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                campaignManager.Show();
                                Console.WriteLine("Kampanya seç (Kampanya istemiyorsanız -1 yazın)");
                                kampanyaid = Convert.ToInt32(Console.ReadLine());
                                gameLibrary.OyunSatis(oyuncuid, oyunid, kampanyaid);
                                break;
                            case 5:
                                Console.Clear();
                                playerManager.Show();
                                Console.WriteLine("Oyunlarını listelemek istediğiniz kullanıcının Id sini girin");
                                gameLibrary.OyunlariListele(Convert.ToInt32(Console.ReadLine()));
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Oyunlar\n1)Oyun Ekle\n2)Oyun Sil\n3)Oyunları Listele");
                        ksecim = Convert.ToInt32(Console.ReadLine());
                        switch (ksecim)
                        {
                            case 1:
                                Console.WriteLine("Oyun Adı:");
                                string oyunadi = Console.ReadLine();
                                Console.WriteLine("Oyun Fiyatı");
                                int oyunfiyati = Convert.ToInt32(Console.ReadLine());
                                Game game = new Game { GameName=oyunadi,GamePrice=oyunfiyati };
                                gameManager.Add(game);
                                break;
                            case 2:

                                gameManager.Show();
                                Console.WriteLine("Silinecek oyunun idsini giriniz : ");
                                gameManager.DeletewithId(Convert.ToInt32(Console.ReadLine()));
                                break;
                            case 3:
                                gameManager.Show();
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Kampanyalar\n1)Kampanya Ekle\n2Kampanya Sil\n3)Kampanyaları Listele");
                        ksecim = Convert.ToInt32(Console.ReadLine());
                        switch (ksecim)
                        {
                            case 1:
                                Console.WriteLine("Kampanya Adı:");
                                string kampanyaad = Console.ReadLine();
                                Console.WriteLine("Kampanya indirim oranı(0 ile 100 arasında bir tamsayı girin)");
                                int indirimyuzde = Convert.ToInt32(Console.ReadLine());
                                Campaign campaign = new Campaign { IndirimOrani=indirimyuzde,KampanyaAdi=kampanyaad };
                                campaignManager.Add(campaign);
                                break;
                            case 2:

                                campaignManager.Show();
                                Console.WriteLine("Silinecek oyunun idsini giriniz : ");
                                campaignManager.DeletewithId(Convert.ToInt32(Console.ReadLine()));
                                break;
                            case 3:
                                campaignManager.Show();
                                break;
                        }
                        break;

                }
                
            }
        }
    }
}
