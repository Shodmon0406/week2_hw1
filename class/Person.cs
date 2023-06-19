public class Person
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string Adress;
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }  
    public string GetBirthYear()
    {
        return $"My birth year in {2023 - Age}";
    } 
}