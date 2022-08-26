using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeUserProfil
{
    private User _user;
    public ChangeUserProfil SetUser(User user)
    {
        _user = user;
        return this;
    }

    public ChangeUserProfil ChangeName(string name)
    {
        _user.Name = name;
        return this;
    }
    public ChangeUserProfil ChangeLogin(string login)
    {
        _user.Login = login;
        return this;
    }

    public ChangeUserProfil ChangePassword(string password)
    {
        _user.Password = password;
        return this;
    }

    public ChangeUserProfil ChangeIcon(string pathToIcon)
    {
        _user.PathToIcon = pathToIcon;
        return this;
    }

    public void Save()
    {
        UserContainer.Instance = _user;
        WorkJson.SaveUser(UserContainer.Instance);
    }


}
