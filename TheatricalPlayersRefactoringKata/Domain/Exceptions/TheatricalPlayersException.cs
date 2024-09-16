using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatricalPlayersRefactoringKata.Domain.Exceptions
{
    public class TheatricalPlayersException : Exception
    {
        public int codigo;

        public TheatricalPlayersException(string message, int codigo = 0) : base(message)
        {
            codigo = codigo;
        }
    }
}
