using Abstracting_a_game.src.Model;

namespace Abstracting_a_game.src.Entities
{
    public abstract class Heroes
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

        public virtual string Attack()
        {
            return this.Name + " Atacou com a espada.";
        }
         public virtual string SpecialAttack()
        {
            return this.Name + " Atacou com um super especial.";
        }

        public virtual int Damage(int HP)
        {
            return HP - 20;
        }


        public override string ToString()
        {
            return $@"Name: {this.Name}         
                      Level: {this.Level} 
                      HeroType: {this.HeroType}
                      HP: {this.HP} 
                      MP: {this.MP}
                      ";
        }
    }
}