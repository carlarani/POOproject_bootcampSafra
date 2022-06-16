namespace SafraBootcamp.Module2.LetsDate;

public class Like
{
    private UserAccount _user;
    private bool _match = false;

    public Like(UserAccount user)
    {
        _user = user;
    }

    public UserAccount User
    {
        get => _user;
    }
    
}