using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExceções.Entites.Exceções
{
     class TratamentoDeExceções : ApplicationException
    {
        public TratamentoDeExceções(string message) : base(message) { }
    }
}
