using System;

namespace Heroes.Lib
{
    public class Warrior : Hero
    {
        public Warrior(Action<string> death) : base(death)
        {
            Health = 100;
            Damage = 200;
        }
    }
}
