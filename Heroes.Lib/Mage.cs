using System;

namespace Heroes.Lib
{
    public class Mage : Hero
    {
        public Mage(Action<string> infoDeath) : base(infoDeath)
        {
            Health = 150;
            Damage = 15;
        }
    }
}
