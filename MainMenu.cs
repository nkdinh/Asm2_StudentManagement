using PersonNP;
using PersonManageNP;

using IPersonFactoryNP;
using PersonIteratorNP;
using StudentNP;
using StudentFactoryNP;

using TeacherNP;
using TeacherFactoryNP;

class MainMenu
{
    static void Main(string[] args)
    {
        Peoplemanagement manager = new Peoplemanagement();

        while (true)
        {
            Console.WriteLine("\n ======== STUDENT MANAGEMENT SOFTWARE ========");
            Console.WriteLine("1. Show list of students");
            Console.WriteLine("2. More information");
            Console.WriteLine("3. Edit information");
            Console.WriteLine("4. Delete information");
            Console.WriteLine("5. Exit the app!");

            Console.Write("\n Enter your selection: ");

            int option = 0;

            try
            {
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        IIterator iterator = manager.CreateIterator();

                        if (iterator.HasNext())
                        {
                            Console.WriteLine("\nLIST OF STUDENTS: ");
                            Console.WriteLine(
                                "{0,-10} {1,-20} {2,-30} {3,-30} {4,-20}", "    ", "ID student", "Name", "Class / Teacher ", "phone number");
                            Console.WriteLine("Complete the request!");

                            while (iterator.HasNext())
                            {
                                People person = iterator.Next();

                                Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30} {4,-20}",
                                    person is Giaovien ? "Teacher:" : "Student:", person.Id, person.Name,
                                    person is Giaovien ? ((Giaovien)person).TeachingSubject : ((SinhVien)person).Grade,
                                    person is Giaovien ? "       " : ((SinhVien)person).Phone);

                            }
                        }
                        else
                        {
                            Console.WriteLine("\nList is empty!");
                        }

                        break;
                    case 2:
                        {
                            Console.WriteLine("Please enter information:");
                            Console.Write("Select object 1:Teacher or 2: Student ");

                            int choice = int.Parse(Console.ReadLine());

                            if (choice == 2)
                            {
                                IPersonFactory studentFactory = new SinhVienft();
                                People student = studentFactory.CreatePerson();
                                manager.AddPerson(student);
                                Console.WriteLine("\nStudent information has been added!");
                            }
                            else
                            {
                                IPersonFactory teacherFactory = new Giaovienft();
                                People teacher = teacherFactory.CreatePerson();
                                manager.AddPerson(teacher);
                                Console.WriteLine("\nTeacher information has been added!");
                            }

                        }

                        break;

                    case 3:
                        Console.WriteLine("\nPlease enter the information to edit");
                        Console.Write("Enter ID student: ");
                        string idUpdate = Console.ReadLine();
                        manager.Update(idUpdate);
                        break;
                    case 4:
                        Console.Write("Enter ID student to intervene: ");
                        string idDelete = Console.ReadLine();
                        manager.DeletepersonById(idDelete);
                        break;
                    case 5:
                        Console.WriteLine("Bye bye see you later! ");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\n Error!! PLEASE ENTER");
                        break;
                }


            }
            catch (FormatException)
            {
                Console.WriteLine("\n NO THIS REQUIRED, PLEASE ENTER: ");
            }  

        }
    }
}
