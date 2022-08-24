using UnityEngine;
using TMPro;
public class RegistrationWindow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _enterLogin;
    [SerializeField] private TextMeshProUGUI _enterPassword;

    public void Open()
    {
        gameObject.SetActive(true);
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
            registration.Registration();
    }

    private void Close()
    {
        gameObject.SetActive(false);
    }
}