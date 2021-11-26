using Heroes.Lib;

namespace Heroes.ConsoleTest
{
    class Program
    {
        static void Main()
        {
            Hero hero;
            Hero enemy;

            Console.WriteLine("Выберите класс персонажа и введите его номер:");
            Console.WriteLine("1: Warrior");
            Console.WriteLine("2: Mage");
            var select = Console.ReadLine();
            switch(select)
            {
                case "1":
                    hero = new Warrior();
                    enemy = new Mage();
                    break;

                case "2":
                    hero = new Mage();
                    enemy = new Warrior();
                    break;

                default:
                    hero = null;
                    enemy = null;
                    break;
            }

            ShowHero(hero);
            Console.WriteLine();
            ShowHero(enemy);

            hero.Attack(enemy);
            enemy.Attack(hero);

            ShowHero(hero);
            Console.WriteLine();
            ShowHero(enemy);
        }

        static void ShowHero(Hero hero)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(hero.GetType().Name);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Health = {hero.Health}");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Damage = {hero.Damage}");

            Console.ResetColor();
        }
    }
}
