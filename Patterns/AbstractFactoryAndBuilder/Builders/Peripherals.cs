using System.Collections.Generic;

namespace AbstractFactoryAndBuilder.Builders
{
    public class Peripherals
    {
        public List<object> Parts { get; }

        public Peripherals()
        {
            Parts = new List<object>();
        }

        public void Add(object part)
        {
            Parts.Add(part);
        }
    }
}