/* Person p1 = new Person()
{
    FirstName = "Shodmon",
    LastName = "Inoyazoda",
    Age = 21,
    Adress = "Hisor"
};
System.Console.WriteLine(p1.GetFullName());
System.Console.WriteLine(p1.GetBirthYear()); */


/* Rectangle r1 = new Rectangle()
{
    Width = 4,
    Height = 5
};
System.Console.WriteLine(r1.GetArea());

r1.Width = 6;
r1.Height = 5;
System.Console.WriteLine(r1.GetArea()); */




var studentList = new List<Students>();
for (int i = 1; i <= 5; i++)
{
    System.Console.WriteLine($"Student {i}");
    Students student = new Students()
    {
        FirstName = Console.ReadLine(),
        LastName = Console.ReadLine(),
        Grade = int.Parse(Console.ReadLine()),
    };
    student.Ball = new List<double>();
    for (int j = 0; j < 5; j++)
    {
        double ball = Convert.ToDouble(Console.ReadLine());
        student.Ball.Add(ball);
    }
    studentList.Add(student);
}

foreach (var student in studentList)
{
    System.Console.WriteLine(student.Congratulate());
}