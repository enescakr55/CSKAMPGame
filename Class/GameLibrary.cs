using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Oyun.Class
{
    class GameLibrary
    {
        PlayerManager playerManager = new PlayerManager();
        GameManager gameManager = new GameManager();
        CampaignManager campaignManager = new CampaignManager();
        public static List<PlayersGames> playersGames = new List<PlayersGames>();
        public void OyunSatis(int playerId,int gameId,int campaignId=-1)
        {
            Campaign campaign = null;
            Player player = playerManager.ReturnById(playerId);
            Game game = gameManager.ReturnById(gameId);
            if(campaignId != -1) {
                campaign = campaignManager.ReturnById(campaignId);
            }
           Console.WriteLine("Oyuncu Adı:"+player.Ad);
            if (player == null || game == null)
            {
                Console.WriteLine("Bir hata oluştu");
            }
            else
            {
                int zatenvar = 0;
                foreach (var g in playersGames)
                {
                    if (g.Oyun == game && g.Oyuncu == player)
                    {
                        zatenvar = 1;
                    }
                }
                if(zatenvar == 0){ 
                    int oyunfiyati = 0;
                    if (campaignId == -1)
                    {

                        oyunfiyati = game.GamePrice;
                        Console.WriteLine("Oyun {0} TL ye kütüphaneye eklendi", Convert.ToString(oyunfiyati));
                    }
                    else
                    {

                        oyunfiyati = game.GamePrice - (game.GamePrice * campaign.IndirimOrani) / 100;
                        Console.WriteLine("Oyun %{0} indirim ile {1} TL ye kütüphaneye eklendi", Convert.ToString(campaign.IndirimOrani), Convert.ToString(oyunfiyati));
                    }

                    PlayersGames pg = new PlayersGames();
                    pg.Oyun = (Game)game;
                    pg.Oyuncu = (Player)player;
                    playersGames.Add(pg);
                }
                else
                {
                    Console.WriteLine("Bu oyun oyuncunun kütüphanesinde zaten mevcut");
                }
            }
            
        }
        public void OyunlariListele(int playerId)
        {
            Console.WriteLine("-- Kullanıcının Oyunları --");
            foreach (var pl in playersGames)
            {
                if(pl.Oyuncu.Id == playerId)
                {
                    Console.WriteLine(pl.Oyun.GameName);
                }
            }
        }
    }
}
