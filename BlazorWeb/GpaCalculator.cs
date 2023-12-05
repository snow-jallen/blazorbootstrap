namespace BlazorWeb;

public static class GpaCalculator
{
    public static decimal Calculate(IEnumerable<Course> courses)
    {
        return 0M;
    }
}

public record Course(string Name, decimal Points, int Credits);
