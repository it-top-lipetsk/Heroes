using System;

namespace Heroes.Lib
{
    public abstract class Hero
    {
        protected Hero(Action<string> death)
        {
            Death = death;
        }

        private uint _health;
        public uint Health
        {
            get //get => _health;
            {
                return _health;
            }
            protected set
            {
                if (value <= 0)
                {
                    _health = 0;
                    Death?.Invoke("Умер"); // if (Death != null) Death("Умер");
                }
                else
                {
                    _health = value;
                }
            }
        }
        public uint Damage { get; protected set; }

        protected Action<string> Death;

        public virtual void Attack(Hero enemy)
        {
            if (enemy is null) throw new ArgumentNullException(nameof(enemy));
            
            enemy.Health -= Damage;
        }
    }
}