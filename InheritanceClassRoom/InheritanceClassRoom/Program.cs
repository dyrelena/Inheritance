using System;
using System.Collections;
using System.Collections.Generic;

namespace InheritanceClassRoom
{
    class Program
    {     
        static void Main(string[] args)
        {
            ClassRoom DP146 = new ClassRoom(
                new ExcelentPupil { FirstName = "Jon", LastName = "Smith", ReadPoints = 10, WritePoints = 9, RelaxPoints = 8},
                new GoodPupil { FirstName = "Potter", LastName = "Garry", ReadPoints = 8, WritePoints = 7, RelaxPoints = 7 },
                new BadPupil {FirstName = "Bob", LastName = "Window", ReadPoints = 5, WritePoints = 4, RelaxPoints = 9});
            
            foreach (Pupil element in DP146)
            {
                element.Study();
                element.Read();
                element.Write();
                element.Relax();
                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }
    class ClassRoom
    {
        List<Pupil> pupilGroup = new List<Pupil>();

        public IEnumerator GetEnumerator()
        {
            return pupilGroup.GetEnumerator();
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupilGroup.Add(pupil1);
            pupilGroup.Add(pupil2);
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3) : this(pupil1, pupil2)
        {
            pupilGroup.Add(pupil3);
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4) : this(pupil1, pupil2, pupil3)
        {
            pupilGroup.Add(pupil4);
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
            Console.Write("Student Performance: {0}", ReadPoints + WritePoints);
        }

        public virtual void Read()
        {
            Console.Write("Reading: {0}", ReadPoints);
        }

        public virtual void Write()
        {
            Console.Write("Writening: {0}", WritePoints);
        }

        public virtual void Relax()
        {
            Console.Write("Ability to relax: {0}", RelaxPoints);
        }
    }

    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            base.Study();
            Console.WriteLine(" - Good job");
        }
        public override void Read()
        {
            base.Read();
            Console.WriteLine(" - High result");
        }

        public override void Write()
        {
            base.Write();
            Console.WriteLine(" - High result");
        }

        public override void Relax()
        {
            base.Relax();
            Console.WriteLine(" - It's time to relax");
        }
    }

    class GoodPupil : Pupil
    {
        public override void Study()
        {
            base.Study();
            Console.WriteLine(" - Not bad");
        }
        public override void Read()
        {
            base.Read();
            Console.WriteLine(" - Good result");
        }

        public override void Write()
        {
            base.Write();
            Console.WriteLine(" - Good result");
        }

        public override void Relax()
        {
            base.Relax();
            Console.WriteLine(" - Well done");
        }
    }

    class BadPupil : Pupil
    {        
        public override void Study()
        {
            base.Study();
            Console.WriteLine(" - Very weak!");
        }
        public override void Read()
        {
            base.Read();
            Console.WriteLine(" - Try your best");
        }

        public override void Write()
        {
            base.Write();
            Console.WriteLine(" - Try your best");
        }

        public override void Relax()
        {
            base.Relax();
            Console.WriteLine(" - Too relaxed");
        }
    }
}
