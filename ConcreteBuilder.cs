using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ConcreteBuilder : BuilderInter
    {
        private Product _product = new Product();
        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        public void BuildWalls()
        {
            this._product.Add("Walls");
        }

        public void BuildRoof()
        {
            this._product.Add("Roof");
        }

        public void BuildWindows()
        {
            this._product.Add("Windows");
        }
        public void BuildDoors()
        {
            this._product.Add("Doors");
        }
        public void BuildPool()
        {
            this._product.Add("Pool");
        }

        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}
