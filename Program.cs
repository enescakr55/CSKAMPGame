using CSharp_Oyun.Class;
using System;
using System.Collections.Generic;

namespace CSharp_Oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager();
            CampaignManager campaignManager = new CampaignManager();
            GameManager gameManager = new GameManager();
            while (1 == 1)
            {
                int secim = 0, ksecim=0;
                do
                {
                    Console.WriteLine("-- Panel --\n1)Kullanıcıları Yönet\n2)Oyunları Yönet\n3)Kampanyaları Yönet");
                    try { secim = Convert.ToInt16(Console.ReadLine()); } catch { Console.WriteLine("Bir hata olustu.\nLutfen 1 - 2 -3 sayilarindan birini giriniz."); }
                } while (secim != 1 && secim != 2 && secim != 3);
                switch (secim)
                {
                    case 1:
                        
                        Console.WriteLine("Kullanıcılar\n1)Kullanıcı Ekle\n2)Kullanıcı Sil\n3)Kullanıcıları Listele");
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
                                string oyunfiyati = Console.ReadLine();
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
