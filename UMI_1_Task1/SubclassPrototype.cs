using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMI_1_Task1
{
    public class SubclassPrototype : ConcretePrototype
    {

        private Prototype field2; 


        public SubclassPrototype(Prototype prototype) : base(prototype) { 
        
        }

        public Prototype clone()
        {

            return new SubclassPrototype(this);
        }


    }
}
