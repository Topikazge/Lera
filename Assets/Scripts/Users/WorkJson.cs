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
  Debug.Log("Путь - "+ Path.Combine(Application.persistentDataPath, "Users.json"));
            return Path.Combine(Application.persistentDataPath, "Users.json");

#else
            Debug.Log("Путь - " + Path.Combine(Application.dataPath, "Users.json"));
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
        Debug.Log("Данные в json загруженны");
    }
}
