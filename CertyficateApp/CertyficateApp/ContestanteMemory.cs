using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CertyficateApp
{
    internal class ContestanteMemory : ContestanteBase
    {
        private string firstName;
        private string lastName;
        private int age;
        private List<float> grades;
        public ContestanteMemory(string lastName, string firstName, int age)
            : base(lastName, firstName, age)
        {

        }

        public override void AddGrade(float grade)
        {
            if (grade > 0 && grade < 10)
            {
                this.grades.Add(grade);



            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float resault))
            {
                this.AddGrade(resault);
            }
        }

        public override void AddGrade(int grade)
        {
            float gradesAsFloat = (float)grade;
            this.AddGrade(gradesAsFloat);
        }

        public override void AddGrade(double grade)
        {
            float gradesAsFloat = (float)grade;
            this.AddGrade(gradesAsFloat);
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach (var grade in this.grades) 
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}
