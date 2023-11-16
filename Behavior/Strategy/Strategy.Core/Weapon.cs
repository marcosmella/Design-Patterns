namespace Strategy.Core
{
    public abstract class Weapon
    {

        public override string ToString()
        {
            return this.GetType().Name;
        }
        public abstract string Shoot();

    }
}
