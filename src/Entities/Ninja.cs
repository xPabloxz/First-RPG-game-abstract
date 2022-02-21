namespace Abstracting_a_game.src.Entities
{
    public class Ninja : Heroes
    {
        public Ninja(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;   
            this.HP = HP;
            this.MP = MP;
        }

         public override string Attack()
            {
                return this.Name + " Atacou com sua adaga";
            } 

         public override string SpecialAttack()
            {
                return this.Name + " Atacou com um super especial.";
            }

            public  int SpecialDamage(int HP,int MP)
        { 
            if(MP >= 40 && HP != 0)
            {
                return HP - 90;
            }
            else
                return MP - 40;
        }
    }
}