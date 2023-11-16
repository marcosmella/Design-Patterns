namespace Strategy.Core
{
    public class Player
    {
        Weapon _strategy;
        public void CambiarEstrategia(Weapon strategy)
        {
            if (strategy == null) throw new Exception("The shooting strategy can't be null");
            _strategy = strategy;
        }

        public string Name { get; set; }

        public string Shoot()
        {
            if (_strategy == null) return "Weapon not available, You should choose 1 weapon";
            return _strategy.Shoot();
        }
    }
}
