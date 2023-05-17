using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertyficateApp
{
    internal interface IPlayer
    {
        string FirstName { get; }
        string LastName { get; }
       
        

        void CalculatePlayerRaiting();
        void CalculateRedCardsRaiting();
        void CalculateYelowCardsRaiting();
        void CalculateGolasScoredRaiting();
        void CalculateAssistRaiting();
        void CalculateMinutesPlayedRaiting();

    }
}
