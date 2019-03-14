using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_final
{
    public class Hechizo
    {
        public Hechizo(uint c) { costo = c; }
        ~Hechizo() { }

        public void Castear() {  }
        public uint GetCosto() { return costo; }

        protected uint costo;
    }

}
