using System;
using GameTOP.Interface;

namespace GameTOP
{
    public class FockGame
    {
        private readonly IPlayer _player1;
        private readonly IPlayer _player2;

        public FockGame(IPlayer player1, IPlayer player2)
        {
            this._player1 = player1;
            this._player2 = player2;
        }
        public void BeginGame()
        {
            Console.WriteLine(_player1.Run());
            Console.WriteLine(_player2.Run());
        }  
    }
}