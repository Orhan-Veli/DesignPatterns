using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder
{
    public class ToyBBuilder
    {
        Toy toy = new Toy();
        public void SetModel()
        {
            toy.Model = "Toy B";
        }

        public void SetHead()
        {
            toy.Head = "1";
        }

        public void SetLimbs()
        {
            toy.Limbs = "4";
        }

        public void SetBody()
        {
            toy.Body = "Steel";
        }

        public void SetLegs()
        {
            toy.Legs = "4";
        }

        public Toy GetToy()
        {
            return toy;
        }
    }
}