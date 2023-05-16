using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertyficateApp
{
    internal class ContestanteFile : ContestanteBase
    {
        public ContestanteFile(string lastName, string firstName, int age) 
            : base(lastName, firstName, age)
        {
            personFileName = $"{ lastName}{FileName}";
        }
        private const string FileName = ".grades.txt";
        private string personFileName;
        public override void AddGrade(float grade)
        {
            if (grade > 0 && grade <= 10)
            {
                using (var writer = File.AppendText($"{personFileName}"))
                {
                    writer.WriteLine(grade);
                }

            }
        }

        public override void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float resault))
            {
                this.AddGrade(resault);
            }
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }
        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            if(File.Exists($"{personFileName}"))
            {
                using( var reader = File.OpenText($"{personFileName}"))
                {

                }
            }
        }
    }
}
