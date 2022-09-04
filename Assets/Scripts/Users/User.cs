using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class User
{
    [SerializeField]
    private string _login;
    [SerializeField]
    private string _password;
    [SerializeField]
    private string _name;
    [SerializeField]
    private string _pathToIcon;

    public User(string login, string password, string name = "Некто", string pathToIcon = "1")
    {
        _login = login;
        _password = password;
        _name = name;
        _pathToIcon = pathToIcon;
    }

    public string Login 
    {
        get { return _login; }  
        set { _login = value; }
    }
    public string Password
    {
        get { return _password; }
        set { _password = value; }
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string PathToIcon
    {
        get { return _pathToIcon; }
        set { _pathToIcon = value; }
    }
}
