using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal interface BuilderInter
    {
        void BuildWalls();

        void BuildRoof();

        void BuildWindows();

        void BuildDoors();

        void BuildPool();
    }
}
