using Abstracting_a_game.src.Entities;

namespace Abstracting_a_game.src.Model
{
    public class Choice : Heroes
    {
        public Choice(string Name, int HP, int MP)
        {
            this.Name = Name;
            this.HP = HP;
            this.MP = MP;
        }
    }
}