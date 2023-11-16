namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine1 = new EnginePetrol();
            engine1.Accelerate();
            engine1.Start();
            engine1.Stop();
            engine1.LoadFuel();


            Engine engine2 = new DieselEngine();
            engine2.Accelerate();
            engine2.Start();
            engine2.Stop();
            engine2.LoadFuel();


            Engine engine3 = new EngineElectricoAdapter();
            engine3.Accelerate();
            engine3.Start();
            engine3.Stop();
            engine3.LoadFuel();

            Console.ReadKey();
        }
    }
}
