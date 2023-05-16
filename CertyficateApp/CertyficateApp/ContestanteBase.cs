using System;


namespace CertyficateApp
{
    public abstract class ContestanteBase : Candidate, IContestant
    {
        protected ContestanteBase(string lastName, string firstName, int age)
            : base(lastName, firstName, age)
        {
        }

        public abstract void AddGrade(float grade);
        public abstract void AddGrade(string grade);
        public abstract void AddGrade(int grade);
        public abstract void AddGrade(double grade);
        
        public abstract Statistics GetStatistics();
    }
}
