namespace SafraBootcamp.Module2.LetsDate;

public enum Gender
{
    Male,
    Female,
    GenderNeutral,
    Agender,
    NonBinary,
    Unkown,
    Other
}

public static class GenderExtension
{
    public static void ListGender()
    {
        foreach (var gender in Enum.GetNames(typeof(Gender)))
        {
            Console.WriteLine(gender);
        }
    }
}