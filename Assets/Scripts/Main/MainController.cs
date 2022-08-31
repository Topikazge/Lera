using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : WindowActive
{
    [SerializeField] private ProfileCreator _profileCreator;
    [SerializeField] private ProfileUser _profileUser;
    public override void Hide()
    {
        _window.SetActive(false);
    }

    public override void View()
    {
        _window.SetActive(true);
    }

    public void OpenChangeProfile(IWindowActive whoCall)
    {
        whoCall.Hide();
        _profileCreator.View();
    }

    public void OpenProfileWindow()
    {
        _profileCreator.Hide();
        _profileUser.View();
    }
}
