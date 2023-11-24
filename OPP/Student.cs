using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP;
internal class Student
{
    //cac field
    int id;
    string? fullname;
    bool gender;
    DateTime dob;

    //contructor
    public Student() { }

    public Student(int id, string? fullname, bool gender, DateTime dob)
    {
        this.id = id;
        this.fullname = fullname;
        this.gender = gender;
        this.dob = dob;
    }


}
