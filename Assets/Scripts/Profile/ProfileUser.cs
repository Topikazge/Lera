using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProfileUser : WindowActive
{
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private TextMeshProUGUI _email;
    [SerializeField] private RawImage _icon;
    [SerializeField] private MainController _mainController;

    private void Start()
    {
        _name.text = UserContainer.Instance.Name;
        _email.text = UserContainer.Instance.Login;
        WWW www = new WWW("file://" + UserContainer.Instance.PathToIcon);
        _icon.texture = www.texture;
    }
    public override void View()
    {
        base.View();
    }

    public void ChangeProfile()
    {
        _mainController.OpenChangeProfile(this);
    }
}
