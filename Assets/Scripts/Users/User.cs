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
    private Texture2D _icon;

    public User(string login, string password, string name = "Нет имени", Texture2D icon = null)
    {
        _login = login;
        _password = password;
        _name = name;
        _icon = icon;
    }

    public string Login => _login;
    public string Password => _password;
    public string Name => _name;
    public Texture2D Icon => _icon;
}
