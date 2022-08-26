using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ControllerEnterWidow : MonoBehaviour
{
    [SerializeField] private RegistrationWindow _registrationWindow;
    [SerializeField] private LoginWindow _loginWindow;
    [SerializeField] private StartWindow _startWindow;
    [SerializeField] private ProfileCreator _profileCreator;

    public void OpenLogin(IWindowActive whoCall)
    {
        whoCall.Hide();
        _loginWindow.View();
    }

    public void OpenLogin()
    {
        _loginWindow.View();
    }

    public void OpenRegistration(IWindowActive whoCall)
    {
        whoCall.Hide();
        _registrationWindow.View();
    }

    public void OpenRegistration()
    {
        _registrationWindow.View();
    }

    public void OpenStrtWindow(IWindowActive whoCall)
    {
        whoCall.Hide();
        _startWindow.View();
    }
    public void OpenpProfileCreate(IWindowActive whoCall)
    {
        whoCall.Hide();
        _profileCreator.View();
    }

}
