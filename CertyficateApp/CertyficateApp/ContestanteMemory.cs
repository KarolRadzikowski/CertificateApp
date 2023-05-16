using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertyficateApp
{
    internal class ContestanteMemory : ContestanteBase
    {
        public ContestanteMemory(string lastName, string firstName, int age)
            : base(lastName, firstName, age)
        {
            
        }

        public override void AddGrade(float grade)
        {
            if (grade > 0 && grade < 10)
            { 
            
            }
        }

        public override void AddGrade(string grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }
        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
