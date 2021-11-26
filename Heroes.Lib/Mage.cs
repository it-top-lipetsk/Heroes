using System;

namespace Heroes.Lib
{
    public class Mage : Hero
    {
        public Mage(Action<string> death) : base(death)
        {
            Health = 150;
            Damage = 15;
        }
    }
}
