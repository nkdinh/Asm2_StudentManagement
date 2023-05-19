using PersonNP;
using StudentNP;
using IPersonFactoryNP;


namespace StudentFactoryNP
{

    public class SinhVienft : IPersonFactory
    {
        public People CreatePerson()
        {

            float grade = 0;

            Console.Write("Enter ID student: ");
            string id = Console.ReadLine();

            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter student phone number: ");
            string phone = Console.ReadLine();

            try
            {
                Console.Write("Enter student class: ");
                grade = float.Parse(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine("\nEnter the wrong student's class, please re-enter");
                Console.Write("Enter student class: ");
                grade = float.Parse(Console.ReadLine());
            }

            return new SinhVien(id, name, grade, phone);
        }
    }
}