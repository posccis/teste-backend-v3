using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatricalPlayersRefactoringKata.Application.Interfaces;
using TheatricalPlayersRefactoringKata.Domain.Domains;

namespace TheatricalPlayersRefactoringKata.Application.Services
{
    public class ComedyCalc : ITypeCalc
    {
        public int CalculatePerformance(Performance performance)
        {
            var thisAmount = 0;
            if (performance.Audience > 20)
            {
                thisAmount += 10000 + 500 * (performance.Audience - 20);
            }
            thisAmount += 300 * performance.Audience;
            return thisAmount;
        }
    }
}
