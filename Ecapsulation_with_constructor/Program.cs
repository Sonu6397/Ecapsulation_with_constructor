using System;

namespace Ecapsulation_with_constructor
{
    public class Student
    {
        private int StdNo;
        private string StdName;

        public Student(int StdNo, string StdName)
        {
            this.StdNo = StdNo;
            this.StdName = StdName;
        }

        public int GetStdNo()
        {
            return StdNo;
           
        }

        public string GetStdName()
        {
            return StdName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student(12,"sonu kumar");
            S.GetStdNo();
            S.GetStdName();
            Console.WriteLine(S.GetStdNo());
            Console.WriteLine(S.GetStdName());
            Console.ReadLine();
        }
    }
}
