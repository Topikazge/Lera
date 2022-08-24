using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Users
{
    [SerializeField]
    private List<User> _users;

    public Users(List<User> users)
    {
        _users = users;
    }

    public List<User> User => _users;
}
