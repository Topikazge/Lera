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
                instance = new User("�����", "�����");
            return instance;
        }
        set
        {
            if (value == null)
                throw new ArgumentNullException("������������ ����");
            instance = value;
        }
    }
}
