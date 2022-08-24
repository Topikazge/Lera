using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LoginWindow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _enterLogin;
    [SerializeField] private TextMeshProUGUI _enterPassword;

    [SerializeField] private RegistrationWindow _registrationWindow;
    [SerializeField] private LoginWindow _LoginWindow;

    public void OnClickLogin()
    {
        Login();
    }

    private void Login()
    {
        if (TryFindUser())
        {
            Debug.Log("Вы вошли");
        }
        else
        {
            throw new System.Exception("Польозватель не найден");
        }


    }

    private bool TryFindUser()
    {
        string login = _enterLogin.text;
        string password = _enterLogin.text;
        Users users = WorkJson.Load();
        Debug.Log("Проверка на корректность входа");
        Debug.Log($"Введенн пароль: {login}. Введен пароль: {password}");
        foreach (User user in users.User)
        {
            Debug.Log($"Логин из массива: {user.Login}. Пароль из массива: {user.Password}");
            if ((user.Login == login) && (user.Password == password))
            {
                return true;
            }
        }
        return false;
    }
}
