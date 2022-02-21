using System;
using Abstracting_a_game.src.Entities;
using Abstracting_a_game.src.Model;

namespace Abstracting_a_game
{
    public class Program
    {
        static void Main()
        {
            int ChoiceCharacter, ChoiceAttack, InitialHP;
            string Question = "S";
            bool WrongChoice = false;
            
            

            while(Question == "S")
            {
                Knight Arus = new Knight("Arus",42,"Knight",749,72);  
                Ninja Wedge = new Ninja("Wedge",42,"Ninja",574,89);
                WhiteWizard Jennica = new WhiteWizard("Jennica",42,"White Wizard",601,482);  
                BlackWizard Tepapa = new BlackWizard("Tepapa",42,"Black Wizard",385,641);
                Choice ChoosenCharacter = new Choice("",0,0);
                do
                {
                    

                    Console.WriteLine($@"
                    --------Selecione o seu personagem---------
                    1 - {Arus} 2 - {Wedge} 3 - {Jennica}
                    Digite o numero para a escolha: ");
                    ChoiceCharacter = int.Parse(Console.ReadLine());

                    switch(ChoiceCharacter)
                    {
                        case 1:
                        Console.WriteLine("Voce escolheu o Cavaleiro Arus." );
                        ChoosenCharacter.HP = Arus.HP;
                        ChoosenCharacter.MP = Arus.MP;
                        ChoosenCharacter.Name = Arus.Name;
                        break;
                        case 2:
                        Console.WriteLine("Voce escolheu o Ninja Wedge." );
                        ChoosenCharacter.HP = Wedge.HP;
                        ChoosenCharacter.MP = Wedge.MP;
                        ChoosenCharacter.Name = Wedge.Name;
                        break;
                        case 3:
                        Console.WriteLine("Voce escolheu a Maga Branca Jennica." );
                        ChoosenCharacter.HP = Jennica.HP;
                        ChoosenCharacter.MP = Jennica.MP;
                        ChoosenCharacter.Name = Jennica.Name;
                        break;
                        default:
                        Console.WriteLine("Escolha errada!");
                        break;
                    }
                } while(ChoiceCharacter <= 0 || ChoiceCharacter > 3);

                    InitialHP = ChoosenCharacter.HP;

                    Console.WriteLine("Você está lutando contra o Mago das trevas Tepapa.");
                    Console.WriteLine();

                do
                {
                    if(Tepapa.MP > 300)
                    {
                        WrongChoice = false;
                    }

                    Console.WriteLine("-----Status-----");
                    Console.WriteLine($@"{ChoosenCharacter.Name} HP: {ChoosenCharacter.HP} e {ChoosenCharacter.Name} MP: {ChoosenCharacter.MP}");
                    Console.WriteLine($@"Tepapa HP: {Tepapa.HP} e Tepapa MP: {Tepapa.MP}");

                    ChoiceAttack = AttackMenu();

                    if(ChoiceAttack == 1 || ChoiceAttack == 2)
                    {
                        if(ChoiceCharacter == 1)
                        {
                            if(ChoiceAttack == 1)
                            {
                                Console.WriteLine(Arus.Attack());
                                Tepapa.HP = Arus.Damage(Tepapa.HP);
                                Console.WriteLine($"Tepapa HP: {Tepapa.HP}");
                            }
                            else
                            {
                                if(ChoosenCharacter.MP < 35)
                                {
                                    Console.WriteLine("Arus tentou atacar, mas esta sem Magical Points.");
                                }
                                else
                                {
                                Console.WriteLine(Arus.SpecialAttack());
                                Tepapa.HP = Arus.SpecialDamage(Tepapa.HP,ChoosenCharacter.MP);
                                ChoosenCharacter.MP = Arus.SpecialDamage(0,ChoosenCharacter.MP);
                                Console.WriteLine($"Tepapa HP: {Tepapa.HP}");
                                }
                            }
                        }
                        else if (ChoiceCharacter == 2)
                        {
                            if(ChoiceAttack == 1)
                            {
                                Console.WriteLine(Wedge.Attack());
                                Tepapa.HP = Wedge.Damage(Tepapa.HP);
                                Console.WriteLine($"Tepapa HP: {Tepapa.HP}");
                            }
                            else
                            {
                                if(ChoosenCharacter.MP < 40)
                                {
                                    Console.WriteLine("Wedge tentou atacar, mas esta sem Magical Points.");
                                }
                                else
                                {
                                Console.WriteLine(Wedge.SpecialAttack());
                                Tepapa.HP = Wedge.SpecialDamage(Tepapa.HP,ChoosenCharacter.MP);
                                ChoosenCharacter.MP = Wedge.SpecialDamage(0,ChoosenCharacter.MP);
                                Console.WriteLine($"Tepapa HP: {Tepapa.HP}");
                                }
                            }
                        }
                        else if (ChoiceCharacter == 3)
                        {
                            if(ChoiceAttack == 1)
                            {
                                Console.WriteLine(Jennica.Attack());
                                Tepapa.HP = Jennica.Damage(Tepapa.HP);
                                Console.WriteLine($"Tepapa HP: {Tepapa.HP}");
                            }
                            else
                            {
                                if(ChoosenCharacter.MP < 50)
                                {
                                    Console.WriteLine("Jennica tentou atacar, mas esta sem Magical Points.");
                                }
                                else
                                {
                                Console.WriteLine(Jennica.SpecialAttack());
                                Tepapa.HP = Jennica.SpecialDamage(Tepapa.HP,ChoosenCharacter.MP);
                                ChoosenCharacter.MP = Jennica.SpecialDamage(0,ChoosenCharacter.MP);
                                Console.WriteLine($"Tepapa HP: {Tepapa.HP}");
                                }
                            }
                        }
                        Console.WriteLine();
                        if(Tepapa.HP > 0)
                        {
                            if(WrongChoice == false)
                            {
                                if(Tepapa.MP < 300)
                                    {
                                        Console.WriteLine("Tepapa tentou atacar, mas esta sem Magical points.");
                                        WrongChoice = true;
                                    }
                                    else
                                    {
                                    Console.WriteLine(Tepapa.SpecialAttack());
                                    ChoosenCharacter.HP = Tepapa.SpecialDamage(ChoosenCharacter.HP,Tepapa.MP);
                                    Tepapa.MP = Tepapa.SpecialDamage(0,Tepapa.MP);
                                    }
                            }
                            else
                            {
                                Console.WriteLine(Tepapa.Attack());
                                ChoosenCharacter.HP = Tepapa.Damage(ChoosenCharacter.HP);
                            }
                            Console.WriteLine($"{ChoosenCharacter.Name} HP: {ChoosenCharacter.HP}");
                            Console.WriteLine();
                            ChoosenCharacter.MP += 5;
                            Tepapa.MP += 5;
                        } 
                        else
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Escolha Errada.");
                    }
                 } while (Tepapa.HP > 0 && ChoosenCharacter.HP > 0);
                if(Tepapa.HP > 0)
                {
                    Console.WriteLine("Você foi destruído pelo Mago das Trevas Tepapa!");
                }
                else
                {
                    Console.WriteLine("Parabéns!!!! Você derrotou o Mago das Trevas Tepapa!");
                }
                
                Console.WriteLine();
                
                Question = FinalMessage();
                
            }
            
         }

        static int AttackMenu()
        {
            Console.WriteLine(@"
---Escolha o Seu Ataque---
1 - Ataque Comum
2 - Ataque Especial

Digite o Número: ");
                
               return int.Parse(Console.ReadLine());
        }
        static string FinalMessage()
        {
            string Question;
                Console.WriteLine("Você gostaria de Continuar o Jogo?");
                Console.WriteLine("Digite 'S' para sim ou qualquer letra para não [S/N]: ");
                Question = Console.ReadLine().ToUpper();
                if(Question == "S")
                {
                    return "S";
                }
                else
                {
                    System.Console.WriteLine("Saindo....");
                    return Question;
                }        
        }
    }
}

        