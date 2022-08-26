using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UserContainer
{
    private static User instance;

    private UserContainer()
    { }

    public static User Instance {
        get
        {
            if (instance == null)
                instance = new User("Некто", "Некто");
            return instance;
        }
        set
        {
            if (value == null)
                throw new ArgumentNullException("Пользователь пуст");
            instance = value;
        }
    }
}
