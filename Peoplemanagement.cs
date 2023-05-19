using PersonNP;

using PersonIteratorNP;

using StudentNP;

using TeacherNP;

namespace PersonManageNP
{

    public interface IPersonManage
    {
        IIterator CreateIterator();
    }

    public class Peoplemanagement : IPersonManage
    {
        private List<People> _persons = new List<People>();

        public void AddPerson(People Person)
        {
            _persons.Add(Person);
        }

        public IIterator CreateIterator()
        {
            return new PersonIterator(_persons);
        }

        public void DeletepersonById(string id)
        {
            // Browse through the person list
            for (int i = 0; i < _persons.Count; i++)
            {
                if (_persons[i].Id == id)
                {
                    _persons.RemoveAt(i);
                    Console.WriteLine("Remove users with ID student = {0}", id);
                    return;
                }
            }
            Console.WriteLine("User with ID student could not be found = {0}", id);
        }

        // person update function
        public void Update(string id)
        {
            // Find the person with the given id
            People personToUpdate = null;

            foreach (People person in _persons)
            {
                if (person.Id == id)
                {
                    personToUpdate = person;
                    break;
                }
            }

            if (personToUpdate == null)
            {
                Console.WriteLine($"ID student not found = {id}");
                return;
            }

            // Update the person based on its type
            if (personToUpdate is Giaovien)
            {
                Giaovien teacherToUpdate = (Giaovien)personToUpdate;

                try
                {
                    // Prompt the user to enter the new Teacher information
                    Console.Write("Enter the teacher's ID: ");
                    string idT = Console.ReadLine();

                    Console.Write("Enter the teacher's name: ");
                    string name = Console.ReadLine();

                    Console.Write("The above teacher will be in charge of the subject: ");
                    string teachingSubject = Console.ReadLine();
                    // Update the Teacher object with the new information
                    teacherToUpdate.Id = idT;
                    teacherToUpdate.Name = name;
                    teacherToUpdate.TeachingSubject = teachingSubject;


                    Console.WriteLine("Teacher information has been updated!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nWrong information, please re-enter: ");
                }

            }
            else if (personToUpdate is SinhVien)
            {
                // Cast the person to a Toy object
                SinhVien studentToUpdate = (SinhVien)personToUpdate;

                try
                {
                    Console.Write("Enter ID Student: ");
                    string idS = Console.ReadLine();

                    Console.Write("Enter Student Name ");
                    string name = Console.ReadLine();

                    Console.Write("Enter class: ");
                    float grade = float.Parse(Console.ReadLine());

                    Console.Write("Phone number: ");
                    string phone = Console.ReadLine();

                    // Update the toy object with the new information
                    studentToUpdate.Id = idS;
                    studentToUpdate.Name = name;
                    studentToUpdate.Grade = grade;
                    studentToUpdate.Phone = phone;

                    Console.WriteLine("Student information has been updated");
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nWrong information, please re-enter!");
                }

            }

        }

    }

}