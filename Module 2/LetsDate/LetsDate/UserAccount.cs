namespace SafraBootcamp.Module2.LetsDate;

public class UserAccount
{
    private static int _nextID = 0;
    private int _userID = _nextID;
    private string _password;
    private string _firstName;
    private int _age;
    private Gender _gender;
    private List<string> _interests;
    private string _aboutMe;
    private string _work;
    private double _maxDistance;
    private Location _location;
    private int _ageRangeMin;
    private int _ageRangeMax;
    private List<Like> _likesReceived;
    private List<Like> _likesGiven;
    private List<Like> _dislikesGiven;

    public UserAccount(string password, string firstName, int age, Location location)
    {
        _password = password;
        _firstName = firstName;
        _age = age;
        _location = location;
        _likesReceived = new List<Like>();
        _interests = new List<string>();
        _ageRangeMin = 18;
        _ageRangeMax = 100;
        _maxDistance = 100.0d;
        _gender = Gender.Unkown;
        _nextID++;
    }

    public int UserId { get => _userID; }

    public Gender Gender { get; set; }

    public string AboutMe { get; set; }

    public string Work { get; set; }

    public double MaxDistance { get; set; }

    public double Location { get; set; }
    
    public string Password { get; set; }
    
    public string FirstName { get; set; }

    public void AddLike(UserAccount user)
    {
        _likesReceived.Add(new Like(user));
    }

    public List<Like> LikesReceived
    {
        get => _likesReceived;
    }

    public void AddInterest(string interest)
    {
        if (_interests.Count == 5)
        {
            Console.WriteLine("O número máximo de interesses é 5");
            return;
        }
        Console.WriteLine("Interesse adicionado");
        _interests.Add(interest);
    }

    public void RemoveInterest(string interest)
    {
        if (!_interests.Contains(interest))
        {
            Console.WriteLine("Interesse não encontrado");
            return;
        }
        Console.WriteLine("Interesse removido");
        _interests.Remove(interest);
    }

    public void ListInterest()
    {
        foreach (var interest in _interests)
        {
            Console.WriteLine(interest);
        }
    }

    public int Age
    {
        get => _age; 
        set
        {
            switch (value)
            {
                case < 18:
                    Console.WriteLine("Essa é um app voltado para maiores de idade!");
                    Environment.Exit(0);
                    break;
                case > 123:
                    Console.WriteLine("Curiosidade: ");
                    Console.WriteLine("O título de pessoa mais velha da história é atribuído à francesa Jeanne Calment, " +
                                      "que morreu em 4 de agosto de 1997, aos 122 anos e 164 dias.");
                    Environment.Exit(0);
                    break;
            }
            _age = value;
        }
    }

    public int AgeRangeMin
    {
        get => _ageRangeMin;
        set
        {
            if (_ageRangeMin > _ageRangeMax)
            {
                Console.WriteLine("Idade mínima deve ser menor que a máxima");
                return;
            }

            if (_ageRangeMin < 18)
            {
                Console.WriteLine("Idade inválida, tente novamente");
                return;
            }
            _ageRangeMin = value;
        }
    }

    public int AgeRangeMax
    {
        get => _ageRangeMax;
        set
        {
            if (_ageRangeMax > _ageRangeMin)
            {
                Console.WriteLine("Idade máxima deve ser maior que a mínima");
                return;
            } 
            _ageRangeMax = value;
        }
    }
}