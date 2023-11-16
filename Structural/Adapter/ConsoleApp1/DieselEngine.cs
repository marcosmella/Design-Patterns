namespace AdapterPattern
{
    public class DieselEngine : Engine
    {
        public override void Start()
        {
            Console.WriteLine("Starting the engine diesel..");
        }

        public override void Accelerate()
        {
            Console.WriteLine("Accelerating the engine diesel..");
        }

        public override void LoadFuel()
        {
            Console.WriteLine("Fueling the engine diesel..");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping the engine diesel..");
        }
    }
}
