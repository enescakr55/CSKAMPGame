using CSharp_Oyun.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Oyun.Class
{
    class GameManager : Manager
    {
        public int Gid=0;
        public static List<Game> Games = new List<Game> { };
        public void Add(Entity entity)
        {
            Game p = (Game)entity;
            Gid += 1;
            p.Id = Gid;
            Games.Add(p);
            Console.WriteLine("Oyun Eklendi");

        }



        public void DeletewithId(int id)
        {
            Games.RemoveAll(r => r.Id == id);
        }

        public Game ReturnById(int id)
        {
            foreach (var game in Games)
            {
                if (game.Id == id)
                {
                    return game;
                }
            }
            return null;
        }

        public void Show()
        {
            if(Games.Count == 0)
            {
                Console.WriteLine("Hiç oyun eklenmemiş");
            }
            foreach (var game in Games)
            {
                Console.WriteLine("Oyun Id :"+game.Id+"\nOyun Adı:" + game.GameName + "\nOyun Fiyatı " +game.GamePrice+"\n");
            }
        }


    }
}
