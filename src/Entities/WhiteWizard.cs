namespace Abstracting_a_game.src.Entities
{
    public class WhiteWizard : Heroes
    {
        public WhiteWizard(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;   
            this.HP = HP;
            this.MP = MP;
        }
            public override string Attack()
            {
                    return this.Name + " Lançou magia Branca";
            } 
            
            public  int SpecialDamage(int HP,int MP)
            { 
                if(MP >= 50 && HP != 0)
                {
                    return HP - 40;
                }
                else
                    return MP - 50;
            }
    }
}