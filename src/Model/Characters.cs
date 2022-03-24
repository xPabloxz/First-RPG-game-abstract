using Abstracting_a_game.src.Entities;

namespace Abstracting_a_game.src.Model
{
    public class Characters
    {
        public static Knight Arus = new Knight("Arus",42,"Knight",749,72);  
        public static Ninja Wedge = new Ninja("Wedge",42,"Ninja",574,89);
        public static WhiteWizard Jennica = new WhiteWizard("Jennica",42,"White Wizard",601,482);  
        public static BlackWizard Tepapa = new BlackWizard("Tepapa",42,"Black Wizard",385,641);
        public static Choice ChoosenCharacter = new Choice("",0,0);
        
    }
}