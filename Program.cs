using System;
using Abstracting_a_game.src.Entities;
using Abstracting_a_game.src.Model;

namespace Abstracting_a_game
{
    public class Program : Characters
    {
        static void Main()
        {
            int ChoiceCharacter;
            string Question = "S";

            while(Question == "S")
            {
                do
                {
                    ChoiceCharacter = MainMenu();

                } while(ChoiceCharacter <= 0 || ChoiceCharacter > 3);

                    Console.WriteLine("Você está lutando contra o Mago das trevas Tepapa.");
                    Console.WriteLine();

                    Battle(ChoiceCharacter);

                Console.WriteLine();
                
                Question = FinalMessage();
                
            }
            
         }



        public static int  MainMenu()
        {

            Console.WriteLine($@"
                    --------Selecione o seu personagem---------
                    1 - {Arus} 2 - {Wedge} 3 - {Jennica}
                    Digite o numero para a escolha: ");

            int ChoiceCharacter = int.Parse(Console.ReadLine());
    
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

            return ChoiceCharacter;
        }



        public static void Battle(int ChoiceCharacter)
        {
            int ChoiceAttack;
            bool WrongChoice = false;

            int FirstPlayerHP = ChoosenCharacter.HP;
            int FirstPlayerMP = ChoosenCharacter.MP;
            int FirstEnemyHP = Tepapa.HP;
            int FirstEnemyMP = Tepapa.MP;

            do
                {
                    if(Tepapa.MP > 300)
                    {
                        WrongChoice = false;
                    }

                    Console.WriteLine("-----Status-----");
                    Console.WriteLine($@"{ChoosenCharacter.Name} HP: {FirstPlayerHP}/{ChoosenCharacter.HP} e {ChoosenCharacter.Name} MP: {FirstPlayerMP}/{ChoosenCharacter.MP}");
                    Console.WriteLine($@"Tepapa HP: {FirstEnemyHP}/{Tepapa.HP} e Tepapa MP: {FirstEnemyMP}/{Tepapa.MP}");

                    ChoiceAttack = AttackMenu();

                    if(ChoiceAttack == 1 || ChoiceAttack == 2)
                    {
                        if(ChoiceCharacter == 1)
                        {
                            if(ChoiceAttack == 1)
                            {
                                Console.WriteLine(Arus.Attack());
                                Tepapa.HP = Arus.Damage(Tepapa.HP);
                                Console.WriteLine($"Tepapa HP: {FirstEnemyHP}/{Tepapa.HP}");
                                Console.WriteLine("Pressione [Enter]");
                                Console.ReadLine();
                            }
                            else
                            {
                                if(ChoosenCharacter.MP < 35)
                                {
                                    Console.WriteLine("Arus tentou atacar, mas esta sem Magical Points.");
                                    Console.WriteLine("Pressione [Enter]");
                                    Console.ReadLine();
                                }
                                else
                                {
                                Console.WriteLine(Arus.SpecialAttack());
                                Tepapa.HP = Arus.SpecialDamage(Tepapa.HP,ChoosenCharacter.MP);
                                ChoosenCharacter.MP = Arus.SpecialDamage(0,ChoosenCharacter.MP);
                                Console.WriteLine($"Tepapa HP: {FirstEnemyHP}/{Tepapa.HP}");
                                Console.WriteLine("Pressione [Enter]");
                                Console.ReadLine();
                                }
                            }
                        }
                        else if (ChoiceCharacter == 2)
                        {
                            if(ChoiceAttack == 1)
                            {
                                Console.WriteLine(Wedge.Attack());
                                Tepapa.HP = Wedge.Damage(Tepapa.HP);
                                Console.WriteLine($"Tepapa HP: {FirstEnemyHP}/{Tepapa.HP}");
                                Console.WriteLine("Pressione [Enter]");
                                Console.ReadLine();
                            }
                            else
                            {
                                if(ChoosenCharacter.MP < 40)
                                {
                                    Console.WriteLine("Wedge tentou atacar, mas esta sem Magical Points.");
                                    Console.WriteLine("Pressione [Enter]");
                                    Console.ReadLine();
                                }
                                else
                                {
                                Console.WriteLine(Wedge.SpecialAttack());
                                Tepapa.HP = Wedge.SpecialDamage(Tepapa.HP,ChoosenCharacter.MP);
                                ChoosenCharacter.MP = Wedge.SpecialDamage(0,ChoosenCharacter.MP);
                                Console.WriteLine($"Tepapa HP: {FirstEnemyHP}/{Tepapa.HP}");
                                Console.WriteLine("Pressione [Enter]");
                                Console.ReadLine();
                                }
                            }
                        }
                        else if (ChoiceCharacter == 3)
                        {
                            if(ChoiceAttack == 1)
                            {
                                Console.WriteLine(Jennica.Attack());
                                Tepapa.HP = Jennica.Damage(Tepapa.HP);
                                Console.WriteLine($"Tepapa HP: {FirstEnemyHP}/{Tepapa.HP}");
                                Console.WriteLine("Pressione [Enter]");
                                Console.ReadLine();
                            }
                            else
                            {
                                if(ChoosenCharacter.MP < 50)
                                {
                                    Console.WriteLine("Jennica tentou atacar, mas esta sem Magical Points.");
                                    Console.WriteLine("Pressione [Enter]");
                                    Console.ReadLine();
                                }
                                else
                                {
                                Console.WriteLine(Jennica.SpecialAttack());
                                Tepapa.HP = Jennica.SpecialDamage(Tepapa.HP,ChoosenCharacter.MP);
                                ChoosenCharacter.MP = Jennica.SpecialDamage(0,ChoosenCharacter.MP);
                                Console.WriteLine($"Tepapa HP: {FirstEnemyHP}/{Tepapa.HP}");
                                Console.WriteLine("Pressione [Enter]");
                                Console.ReadLine();
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
                                        Console.WriteLine("Pressione [Enter]");
                                        Console.ReadLine();
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
                            Console.WriteLine($"{ChoosenCharacter.Name} HP: {FirstPlayerHP}/{ChoosenCharacter.HP}");
                            Console.WriteLine("Pressione [Enter]");
                            Console.ReadLine();
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

                Tepapa.HP = FirstEnemyHP;
                Tepapa.MP = FirstEnemyMP;
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
                    Console.WriteLine();
                    System.Console.WriteLine("Saindo....");
                    Console.ReadLine();
                    return Question;
                }        
        }



    }
}

        