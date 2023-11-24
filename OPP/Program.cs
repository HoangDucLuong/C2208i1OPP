using OPP;

//object by contructor
Student stu1 = new Student(1, "luong", true, new DateTime(2004,01,22));
Student stu2 = new (2, "luong", true, new DateTime(2004, 01, 22));

//object initializer
Student stu3 = new()
{
    Id = 3,
    Gender = false,
    Fullname = "luong",
    Dob = DateTime.Now
};

Console.WriteLine(stu3);