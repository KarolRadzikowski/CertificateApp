
namespace CertyficateApp
{
    internal interface IContestant
    {
        public Statistics GetStatistics();
        public void AddGrade(float grade);
        public void AddGrade(string grade);
        public void AddGrade(int grade);
        public void AddGrade(double grade);
       

        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }



    }
}
