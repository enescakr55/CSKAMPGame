using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Oyun.Class
{
    public class PlayersGames
    {
        public int Id { get; set; }
        public Game Oyun { get; set; }
        public Player Oyuncu { get; set; }
    }
}
