namespace AdapterPattern
{
    public class EnginePetrol : Engine
    {
        public override void Start()
        {
            Console.WriteLine("Starting the petrol engine..");
        }

        public override void Accelerate()
        {
            Console.WriteLine("Accelerating the petrol engine..");
        }

        public override void LoadFuel()
        {
            Console.WriteLine("Fueling the petrol engine..");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping the petrol engine..");
        }
    }
}
