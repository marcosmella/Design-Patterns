namespace AdapterPattern
{
    public abstract class Engine
    {
        public abstract void Start();
        public abstract void Accelerate();
        public abstract void Stop();
        public abstract void LoadFuel();
    }
}
