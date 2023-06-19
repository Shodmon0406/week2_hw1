public class Students
{
    public string FirstName;
    public string LastName;
    public double Grade;
    public List<double> Ball;
    double sum = 0;
    public void Avarage()
    {
        foreach (var item in Ball)
        {
            sum += item;
        }
        sum = sum / Ball.Count;
    }
    public string Congratulate()
    {
        Avarage();
        if (sum > 85)
        {
            return $"{FirstName} {LastName} on achieving above average scores ({sum}) in grade {Grade}! Keep up the good work!";
        }
        else if (sum < 70)
        {
            return $"{FirstName} {LastName}, if you're having difficulties with your studies, don't hesitate to seek help. Your current average score is ({sum}) in grade {Grade}.";
        }
        else
        {
            return $"{FirstName} {LastName} on achieving an average score of ({sum}) in grade {Grade}! Keep working hard for even better results!";
        }
    }
}