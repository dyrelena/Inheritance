using System;

namespace InheritanceClassRoom
{
    class Program
    {
        Pupil st1 = new Pupil();
        

        static void Main(string[] args)
        {
             
            Console.WriteLine("Hello World!");
        }
    }

    class ClassRoom
    { 
        Pupil[] arrStudents = new Pupil[4];
        int index = 0;
        public ClassRoom(Pupil student1, Pupil student2) 
        {
            //arrStudents = new Pupil[] {student1, student2};
            arrStudents[0]
        }

        public ClassRoom(Pupil student1, Pupil student2, Pupil student3)
        {
            arrStudents = new Pupil[] { student1, student2, student3};
        }
    }

    class Pupil
    {
        string firstName;
        string lastName;        
        double readPoints;
        double writePoints;
        double relaxPoints;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }        
        public double ReadPoints { get => readPoints; set => readPoints = value; }
        public double WritePoints { get => writePoints; set => writePoints = value; }
        public double RelaxPoints { get => relaxPoints; set => relaxPoints = value; }

        public virtual void Study()
        {
            Console.WriteLine("Student Performance: {0}", ReadPoints + WritePoints);
        }

        public virtual void Read()
        {
            Console.WriteLine("Reading: {0}", ReadPoints);
        }

        public virtual void Write()
        {
            Console.WriteLine("Writening: {0}", WritePoints);
        }

        public virtual void Relax()
        {
            Console.WriteLine("Ability to relax: {0}", RelaxPoints);
        }
    }

    class ExcelentPupil:Pupil
    {
        public override void Study()
        {
            base.Study();
            Console.WriteLine("Good job!");
        }
        public override void Read()
        {
            base.Read();
            Console.WriteLine("High result");
        }

        public override void Write()
        {
            base.Write();
            Console.WriteLine("High result");
        }

        public override void Relax()
        {
            base.Relax();
            Console.WriteLine("Excelent!");
        }
    }

    class GoodPupil:Pupil
    {
        public override void Study()
        {
            base.Study();
            Console.WriteLine("Not bad!");
        }
        public override void Read()
        {
            base.Read();
            Console.WriteLine("Good result");
        }

        public override void Write()
        {
            base.Write();
            Console.WriteLine("Good result");
        }

        public override void Relax()
        {
            base.Relax();
            Console.WriteLine("Well done!");
        }
    }

    class BadPupil:Pupil
    {
        public override void Study()
        {
            base.Study();
            Console.WriteLine("Very weak!");
        }
        public override void Read()
        {
            base.Read();
            Console.WriteLine("Try your best");
        }

        public override void Write()
        {
            base.Write();
            Console.WriteLine("Try your best");
        }

        public override void Relax()
        {
            base.Relax();
            Console.WriteLine("No time to relax");
        }
    }
}
