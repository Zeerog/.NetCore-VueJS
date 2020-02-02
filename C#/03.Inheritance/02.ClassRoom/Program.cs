using System;

namespace _02.ClassRoom
{
    class Program
    {
        static void Main()
        {
            ClassRoom cRoom = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil(), new GoodPupil());

            cRoom.PrintInfoRead();
            cRoom.PrintInfoRelax();
            cRoom.PrintInfoStudy();
            cRoom.PrintInfoWrite();

            Console.ReadLine();
        }
    }
    class Pupil
    {
        public virtual void Study()
        { }

        public virtual void Read()
        { }

        public virtual void Write()
        { }

        public virtual void Relax()
        { }
    }
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("ExcelentPupil: Study. Study. Only study");
        }
        public override void Read()
        {
            Console.WriteLine("ExcelentPupil: Read science books");
        }
        public override void Write()
        {
            Console.WriteLine("ExcelentPupil: Write homework");
        }
        public override void Relax()
        {
            Console.WriteLine("ExcelentPupil: Study is my life");
        }

    }
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("GoodPupil: Study, maybe. Not sure");
        }
        public override void Read()
        {
            Console.WriteLine("GoodPupil: Read sometimes");
        }
        public override void Write()
        {
            Console.WriteLine("GoodPupil: Cheats off homework");
        }
        public override void Relax()
        {
            Console.WriteLine("GoodPupil: Relax with friends");
        }

    }
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("BadPupil: Play football");
        }
        public override void Read()
        {
            Console.WriteLine("BadPupil: Play football");
        }
        public override void Write()
        {
            Console.WriteLine("BadPupil: Play football");
        }
        public override void Relax()
        {
            Console.WriteLine("BadPupil: Cross stitch");
        }

    }
    class ClassRoom
    {
        Pupil[] arrPupil;

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            arrPupil = new Pupil[] { p1, p2, p3, p4 };
        }
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            arrPupil = new Pupil[] { p1, p2, p3 };
        }
        public ClassRoom(Pupil p1, Pupil p2)
        {
            arrPupil = new Pupil[] { p1, p2 };
        }

        public void PrintInfoStudy()
        {
            Console.WriteLine("Study: ");
            foreach (Pupil item in arrPupil)
                item.Study();
        }
        public void PrintInfoRead()
        {
            Console.WriteLine("Read: ");
            foreach (Pupil item in arrPupil)
                item.Read();
        }
        public void PrintInfoWrite()
        {
            Console.WriteLine("Write: ");
            foreach (Pupil item in arrPupil)
                item.Write();
        }
        public void PrintInfoRelax()
        {
            Console.WriteLine("Relax: ");
            foreach (Pupil item in arrPupil)
                item.Relax();
        }
    }
}
