public class RegistrationUser
{
    private readonly string _login;
    private readonly string _password;
    private Users _users;

    public RegistrationUser(string login, string password)
    {
        _login = login;
        _password = password;
    }

    public bool LoadUsers()
    {
        _users = WorkJson.Load();
        return _users != null ? true : false;
    }

    public bool TryRegistration()
    {
        foreach (User user in _users.User)
        {
            if (user.Login == _login)
            {
                return false;
            }
        }
        return true;
    }

    public User Registration()
    {
        User user = new User(_login, _password);
        _users.User.Add(user);
        WorkJson.Save(_users);
        return user;
    }
}
