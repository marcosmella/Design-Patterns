using System;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        protected string _description;
        protected string _origin;

        public void Render()
        {
            Console.WriteLine(string.Format("{0} Pizza made in {1}", _description, _origin));
        }
    }
}