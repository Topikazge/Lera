using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Windowcontroler : WindowActive
{
    [SerializeField] private WindowActive _mainController;
    [SerializeField] private WindowActive _authorization;

    public void OpenMain(IWindowActive whoCall)
    {
        whoCall.Hide();
        _authorization.Hide();
        _mainController.View();
    }

    public void OpenAuthorization(IWindowActive whoCall)
    {
        whoCall.Hide();
        _authorization.View();
    }
}
