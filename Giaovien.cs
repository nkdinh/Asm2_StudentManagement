using PersonNP;
using System.Xml.Linq;

namespace TeacherNP
{
    public class Giaovien : People
    {
        public string TeachingSubject { get; set; }

        public Giaovien(string id, string name, string teachingSubject)
        {
            Id = id;
            Name = name;
            TeachingSubject = teachingSubject;
        }

    }

}