using System;

namespace Heroes.Lib
{
    public class Warrior : Hero
    {
        public Warrior(Action<string> infoDeath) : base(infoDeath)
        {
            Health = 100;
            Damage = 200;
        }
    }
}
