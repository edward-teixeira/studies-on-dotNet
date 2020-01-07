using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Agencias
{
    public class ValidacaoEventArgs: EventArgs
    {
        public string Text { get; private set; }
        public bool ehValido { get; set; }

        public ValidacaoEventArgs(string texto)
        {
            Text = texto;
            ehValido = true;
        }
    }
}
