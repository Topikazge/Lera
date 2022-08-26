using UnityEngine;
using TMPro;
public class RegistrationWindow : MonoBehaviour, IWindowActive
{
    [SerializeField] private TextMeshProUGUI _enterLogin;
    [SerializeField] private TextMeshProUGUI _enterPassword;
    [SerializeField] private GameObject _objectContainer;
    [SerializeField] private ControllerEnterWidow _controller;

    public void View()
    {
        _objectContainer.SetActive(true);
    }
    public void Hide()
    {
        _objectContainer.SetActive(false);
    }

    public void OnClickRegistration()
    {
        RegistrationUser();
    }

    private void RegistrationUser()
    {
        string login = _enterLogin.text;
        string password = _enterLogin.text;
        //WorkJson.CheckFile();
        RegistrationUser registration = new RegistrationUser(login, password);
        bool isUsersLoad = registration.LoadUsers();
        if (isUsersLoad && registration.TryRegistration())
         UserContainer.Instance =  registration.Registration();
        _controller.OpenpProfileCreate(this);
    }


    public void OnClickAccount()
    {
        _controller.OpenLogin(this);
    }

}