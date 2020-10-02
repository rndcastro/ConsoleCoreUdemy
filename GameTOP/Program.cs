using System;
using GameTOP.lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player("Raphael");
            var zagueiro = new Zagueiro();
            var game = new FockGame(player, zagueiro);
            game.BeginGame();
        }
    }
}
