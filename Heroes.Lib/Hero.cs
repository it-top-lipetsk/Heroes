using System;

namespace Heroes.Lib
{
    public abstract class Hero
    {
        protected Hero(Action<string> death)
        {
            _death = death;
        }

        private int _health;
        public int Health
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
                    _death.Invoke("Умер"); // if (Death != null) Death("Умер");
                }
                else
                {
                    _health = value;
                }
            }
        }
        public int Damage { get; protected set; }

        private readonly Action<string> _death;

        public virtual void Attack(Hero enemy)
        {
            if (enemy is null) throw new ArgumentNullException(nameof(enemy));
            
            enemy.Health -= Damage;
        }
    }
}