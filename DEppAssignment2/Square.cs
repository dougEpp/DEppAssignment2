using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEppAssignment2
{
    class Square
    {
        public bool isFull;
        public string xOrO;
        public Square()
        {
            this.isFull = false;
            this.xOrO = "";
        }

        public void selectSquare(string xOrO)
        {
            this.isFull = true;
            this.xOrO = xOrO;
        }
    }
}
