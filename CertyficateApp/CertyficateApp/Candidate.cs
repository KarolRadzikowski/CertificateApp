
namespace CertyficateApp
{
    public abstract class Candidate 
    { 
    public Candidate(string lastName, string firstName, int age) 
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Age = age;
        }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
    }
    
        
   

}
