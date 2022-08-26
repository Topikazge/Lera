using TMPro;
using UnityEngine;


public class LoginWindow : MonoBehaviour, IWindowActive
{
    [SerializeField] private TextMeshProUGUI _enterLogin;
    [SerializeField] private TextMeshProUGUI _enterPassword;
    [SerializeField] private GameObject _objectContainer;
    [SerializeField] private ControllerEnterWidow _controller;
    [SerializeField] private Windowcontroler _windowcontroler;
    private User _user;

    public void View()
    {
        _objectContainer.SetActive(true);
    }

    public void Hide()
    {
        _objectContainer.SetActive(false);
    }

    public void OnClickLogin()
    {
        Login();
    }



    private void Login()
    {
        Users users = WorkJson.Load();
        if (TryFindUser(users))
        {
            UserContainer.Instance = _user;
            _windowcontroler.OpenMain(this);
        }
        else
        {
            throw new System.Exception("������������ �� ������");
        }


    }


    public void OnClickRegistration()
    {
        _controller.OpenRegistration(this);
    }

    private bool TryFindUser(Users users)
    {
        string login = _enterLogin.text;
        string password = _enterLogin.text;
        
        Debug.Log("�������� �� ������������ �����");
        Debug.Log($"������� ������: {login}. ������ ������: {password}");
        foreach (User user in users.User)
        {
            Debug.Log($"����� �� �������: {user.Login}. ������ �� �������: {user.Password}");
            if ((user.Login == login) && (user.Password == password))
            {
                _user = user;
                return true;
            }
        }
        return false;
    }
}
