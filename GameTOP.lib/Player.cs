using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Player : IPlayer
    {
        public Player(string name)
        {
            Name = name;
        }
        public string Name {get; set;}
        public int Age { get; protected set; }

        public string Run()
        {
            return $"{Name} is running";
        }
    }
}