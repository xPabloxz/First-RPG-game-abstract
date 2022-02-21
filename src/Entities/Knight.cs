namespace Abstracting_a_game.src.Entities
{
    public class Knight : Heroes
    {
        public Knight(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;   
            this.HP = HP;
            this.MP = MP;
        }

        public  int SpecialDamage(int HP,int MP)
        { 
            if(MP >= 35 && HP != 0)
            {
                return HP - 100;
            }
            else
                return MP - 35;
        }
    }
}