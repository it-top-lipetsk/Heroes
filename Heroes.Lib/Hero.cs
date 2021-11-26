namespace Heroes.Lib
{
    public abstract class Hero
    {
        public uint Health { get; set; }
        protected uint Damage { get; set; }

        public virtual void Attack(Hero enemy)
        {
            if (enemy is null) throw new ArgumentNullException(nameof(enemy));
            
            enemy.Health -= Damage;
        }
    }
}