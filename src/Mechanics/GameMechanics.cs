using static System.Console;
using Abstraindo_um_Jogo_de_RPG.src.Entities;

namespace Abstraindo_um_Jogo_de_RPG.src.Mechanics
{
    public class GameMechanics
    {
        public void Actions(Character character)
        {
            string option = "";
            while (option.ToUpper() != "X")
            {
                WriteLine($@"{character.Name}, select your action:
            (S) Status
            (F) Fight
            (X) Exit
            ");

                option = ReadLine();

                switch (option.ToUpper())
                {
                    case "S":
                        WriteLine("  Character Status:");
                        character.ShowStatus();
                        WriteLine("Press ENTER to continue");
                        ReadLine();
                        break;

                    case "F":
                        if (character.CurrentHp > 0)
                            Fight(character);
                        else{
                            WriteLine("Dead heroes can't fight.");
                            option = "X";
                        }

                        break;

                    default:
                        WriteLine("Type a valid option.");
                        break;
                }
            }
            WriteLine("\nGame Over.");
            ReadLine();
        }

        static void Fight(Character Character)
        {
            Character enemy = new Character()
            {
                Name = "Orc",
                HeroType = HeroType.Enemy,
                BaseHp = 5,
                CurrentHp = 5
            };

            Console.WriteLine($"A wild {enemy.Name} appeared!");
            enemy.ShowStatus();

            while (Character.CurrentHp > 0 | enemy.CurrentHp > 0)
            {
                Console.WriteLine("Press ENTER to Attack");
                Console.ReadLine();
                Character.Attack(enemy);
                if (enemy.CurrentHp <= 0)
                {
                    Character.GainExp(enemy);
                    break;
                }

                enemy.Attack(Character);

                if (Character.CurrentHp <= 0)
                {
                    Console.WriteLine("\nYou died.");
                    break;
                }
            }
        }
    }
}