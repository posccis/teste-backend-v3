using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatricalPlayersRefactoringKata.Application.Interfaces;
using TheatricalPlayersRefactoringKata.Domain.Domains;

namespace TheatricalPlayersRefactoringKata.Application.Services
{
    public class TragedyCalc : ITypeCalc
    {
        public int CalculatePerformance(Performance performance)
        {
            var thisAmount = 0;
            if (performance.Audience > 30)
            {
                thisAmount += 1000 * (performance.Audience - 30);
            }

            return thisAmount;

        }
    }
}
