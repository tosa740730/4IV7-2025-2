using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Vidas
    {
        private int _vidas;
        public int _Vidas
        {
            get { return _vidas; }
            set { _vidas = value; }
        }
        public Vidas()
        {
            _vidas = 0;
        }
    }
}
