namespace Abstracting_a_game.src.Entities
{
    public class BlackWizard : Heroes
    {
        public BlackWizard(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;   
            this.HP = HP;
            this.MP = MP;
        }
            public override string Attack()
            {
                return this.Name + " Lançou magia negra!";
            } 

            public  int SpecialDamage(int HP,int MP)
        { 
            if(MP >= 300 && HP != 0)
            {
                return HP - 200;
            }
            else
                return MP - 300;
        }

    }
}