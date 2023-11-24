using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP;
internal class Student
{
    //vua la field vua la property
    public int Id { get; set; }
    public string? Fullname { get; set; }
    public bool Gender { get; set; }
    public DateTime Dob { get; set; }

    //contructor
    public Student() { }

    public Student(int id, string? fullname, bool gender, DateTime dob)
    {
        Id = id;
        Fullname = fullname;
        Gender = gender;
        Dob = dob;
    }

    //override tostring
    public override string ToString()
    {
        return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Fullname)}={Fullname}, {nameof(Gender)}={Gender.ToString()}, {nameof(Dob)}={Dob.ToString()}}}";
    }
}
