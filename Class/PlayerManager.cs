using CSharp_Oyun.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Oyun.Class
{
    class PlayerManager : Manager
    {
        public int Uid=0;
        public static List<Player> Players = new List<Player> { };
        public void Add(Entity entity)
        {
            Player p = (Player)entity;
            Uid += 1;
            p.Id = Uid;
            Players.Add(p);
            Console.WriteLine("Kullanıcı Eklendi");
        }

        public void DeletewithId(int id)
        {
            Players.RemoveAll(r => r.Id == id);
        }

        public Player ReturnById(int id)
        {
            foreach (var player in Players)
            {
                if(player.Id == id)
                {
                    return player;
                }
            }
            return null;
        }

        public void Show()
        {
            Console.WriteLine("-- Kayıtlı Oyuncular --\n");
            if (Players.Count == 0)
            {
                Console.WriteLine("Hiç kullanıcı eklenmemiş");
            }
            foreach (var player in Players)
            {
                Console.WriteLine("Oyuncu Id:" +player.Id +"\nOyuncu Adı/Soyadı:" + player.Ad + " " + player.Soyad+ "\nTc No : " + player.TcNo + "\nDoğum Yılı : " +player.DogumYili);
                Console.WriteLine("\n");
            }
        }
    }
}
