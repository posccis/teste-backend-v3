using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatricalPlayersRefactoringKata.Domain.Domains;

namespace TheatricalPlayersRefactoringKata.Application.Interfaces
{
    public interface ITypeCalc
    {
        string CalculatePerformance(Performance performance);
    }
}
