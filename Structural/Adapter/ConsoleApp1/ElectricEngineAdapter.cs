namespace AdapterPattern
{
    public class EngineElectricoAdapter : Engine
    {
        ElectricEngine electricEngine = new ElectricEngine();

        public override void Start()
        {
            electricEngine.Move();
        }

        public override void Accelerate()
        {
            electricEngine.Connect();
            electricEngine.Active();

        }

        public override void LoadFuel()
        {
            electricEngine.Plug();
        }

        public override void Stop()
        {
            electricEngine.Deactivate();
            electricEngine.Stop();
        }
    }
}
