using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertyficateApp
{
    public abstract class PlayerBase : Candidate, IPlayer
    {
        protected PlayerBase(string firstname, string lastname, int age)
            : base(firstname, lastname, age)
        {
        }

        public void CalculateAssistRaiting()
        {
            throw new NotImplementedException();
        }

        public void CalculateGolasScoredRaiting()
        {
            throw new NotImplementedException();
        }

        public void CalculateMinutesPlayedRaiting()
        {
            throw new NotImplementedException();
        }

        public void CalculatePlayerRaiting()
        {
            throw new NotImplementedException();
        }

        public void CalculateRedCardsRaiting()
        {
            throw new NotImplementedException();
        }

        public void CalculateYelowCardsRaiting()
        {
            throw new NotImplementedException();
        }
    }
}
