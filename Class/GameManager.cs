using CSharp_Oyun.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Oyun.Class
{
    class GameManager : Manager
    {
        public int Gid=0;
        public List<Game> Games = new List<Game> { };
        public void Add(Entity entity)
        {
            Game p = (Game)entity;
            Gid += 1;
            p.Id = Gid;
            Games.Add(p);

        }



        public void DeletewithId(int id)
        {
            Games.RemoveAll(r => r.Id == id);
        }

        public void Show()
        {
            foreach (var game in Games)
            {
                Console.WriteLine("Oyun Id :"+game.Id+"\nOyun Adı:" + game.GameName + "\nOyun Fiyatı " +game.GamePrice+"\n");
            }
        }


    }
}
