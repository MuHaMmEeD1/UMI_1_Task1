using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMI_1_Task1
{
    public class ConcretePrototype : Prototype
    {

        private Prototype field1; 

        public ConcretePrototype(Prototype prototype) 
        {
            this.field1 = ((ConcretePrototype)prototype).field1;

        }

        public Prototype clone()
        {

            return new ConcretePrototype(this);
        }
    }
}
