namespace AdapterPattern
{
   public class ElectricEngine
    {
        bool _connected;
        bool _active;
        bool _moving;


        public void Connect()
        {
            if (_connected)
                Console.WriteLine("Impossible to connect an electric motor already connected!");
            else
            {
                _connected = true;
                Console.WriteLine("Engine conected!");
            }
        }
               
        public void Active()
        {

            if (!_connected)
                Console.WriteLine("Impossible to activate an unconnected engine");
            else
            {
                _active = true;
                Console.WriteLine("Engine activated!");
            }
            
        }
       
        public void Move()
        {
            if (_connected && _active)
            {
                _moving = true;
                Console.WriteLine("Moving vehicle with electric engine...");
            }
            else
            {
                Console.WriteLine("The engine must be connected and active!");
            }
   
        }

        public void Stop()
        {

            if (_moving)
            {
                _moving = false;
                Console.WriteLine("Stopping a vehicle with an electric engine...");
            }
            else
            {
                Console.WriteLine("Impossible to stop a engine that is not moving!");
            }
            
        }

        public void Disconnect()
        {
            if (_connected)
            {
              
                Console.WriteLine("Engine disconnected...");
            }
            else
            {
                Console.WriteLine("Impossible to disconnect a motor that is not connected!");
            }
   
        }
  
        public void Deactivate()
        {
            if (_active)
            {
                _active = false;
                Console.WriteLine("Engine deactivated...");
            }
            else
            {
                Console.WriteLine("Impossible to deactivate a motor that is not active!");
            }
      }
   
        public void Plug()
        {
            if (!_active)
            {
                _active = false;
                Console.WriteLine("Engine charging the batteries!...");
            }
            else
            {
                Console.WriteLine("Impossible to plug in an active engine!");
            }
         
        }
        
    }
}
