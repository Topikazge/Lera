using System.Collections.Generic;
using System.IO;
using UnityEngine;


public static class WorkJson
{
    public static string PathToFile
    {
        get
        {
#if UNITY_ANDROID && !UNITY_EDITOR
  Debug.Log("���� - "+ Path.Combine(Application.persistentDataPath, "Users.json"));
            return Path.Combine(Application.persistentDataPath, "Users.json");

#else
            // Debug.Log("���� - " + Path.Combine(Application.dataPath, "Users.json"));
            return Path.Combine(Application.dataPath, "Users.json");
#endif
        }
    }


    public static void CheckFile()
    {
        List<User> usersList = new List<User>();
        usersList.Add(new User("123", "123"));
        Users users = new Users(usersList);
        Save(users);
        Load();
    }


    public static Users Load()
    {
        string json = File.ReadAllText(PathToFile);
        Users users = JsonUtility.FromJson<Users>(File.ReadAllText(PathToFile));
        Debug.Log("===============");
        Debug.Log("Users - " + users);
        foreach (User f in users.User)
        {
            Debug.Log("User - " + f.Login);
        }

        return users;
    }

    public static void Save(Users users)
    {
        File.WriteAllText(PathToFile, JsonUtility.ToJson(users));
        Debug.Log("������ � json ����������");
    }

    public static void SaveUser(User usern)
    {
        Users users = Load();
       /* foreach (var item in users.User)
        {
            Debug.Log("item - " + item.Password);
            char[] charItem = item.Password.ToCharArray();
            for (int i = 0; i < charItem.Length; i++)
            {
                Debug.Log(charItem[i]);
            }
        }*/







        char[] chars = usern.Password.ToCharArray();
        foreach (var item in users.User)
        {
            char[] charItem = item.Password.ToCharArray();
            Debug.Log($"charItem.Length: {charItem.Length},� �����{item.Password}/ chars.Length: {chars.Length} ");
            if ((charItem.Length-1 == chars.Length))
            {
                bool isTrue = true;
                for (int i = 0; i < charItem.Length-1; i++)
                {
                    Debug.Log($"charItem[i]: {charItem[i]} / chars[i]: {chars[i]} ");
                    if (charItem[i] != chars[i])
                    {
                        isTrue = false;
                    }
                }
                if (isTrue)
                {
                    Debug.Log("�asdfasfasdasfdasasdasdasdasasdasdasdasdasdasdasdasdasdasdasdasda��");
                    item.Name = usern.Name;
                    item.PathToIcon = usern.PathToIcon;
                }
            }
        }


        /*  for (int i = 0; i < users.User.Count; i++)
          {
              Debug.Log("---------------------------------------");
              Debug.Log($"������������. ����� {user.Login}, ������ {user.Password},��� {user.Name},���� {user.PathToIcon}");
              Debug.Log($"������������. ����� {users.User[i].Login}, ������ {users.User[i].Password},��� {users.User[i].Name},���� {users.User[i].PathToIcon}");
              login = user.Login.ToCharArray();
              password = user.Password.ToCharArray();
              char[] loginMass = users.User[i].Login.ToCharArray();
              Debug.Log("������� ����������: " + loginMass[0] == login[0];
              Debug.Log("Equals: " + string.Equals(loginMass.ToString(), login.ToString()));
              if (string.Equals(users.User[i].Login, user.Login))
              {
                  users.User[i] = user;
                  Debug.Log("User ������ - " + user.Name);
              }
          }*/
        File.WriteAllText(PathToFile, JsonUtility.ToJson(users));
        Debug.Log("������ � json ���������");
    }

}
