using PersonNP;
using System.Xml.Linq;

namespace StudentNP
{
    public class SinhVien : People
    {
        public float Grade { get; set; }
        public string Phone { get; set; }

        public SinhVien(string id, string name, float grade, string phone)
        {
            Id = id;
            Name = name;
            Grade = grade;
            Phone = phone;
        }

    }

}