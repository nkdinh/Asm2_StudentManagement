using PersonNP;
using TeacherNP;
using IPersonFactoryNP;

namespace TeacherFactoryNP
{
    public class Giaovienft : IPersonFactory
    {
        public People CreatePerson()
        {

            Console.Write("Enter Teacher ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter teacher's name: ");
            string name = Console.ReadLine();

            Console.Write("Course entry: ");
            string teachingSubject = Console.ReadLine();

            return new Giaovien(id, name, teachingSubject);
        }
    }
}