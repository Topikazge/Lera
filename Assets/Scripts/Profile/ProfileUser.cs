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
    [SerializeField] private AvatarManagerTWO _avatarManagerTWO;

    private void Start()
    {
        _name.text = UserContainer.Instance.Name;
        _email.text = UserContainer.Instance.Login;
        AvatarManager sdfsdf = FindObjectOfType<AvatarManager>();
        Debug.Log(sdfsdf);
        
        _icon.texture = _avatarManagerTWO.IconsContainer.GetSprite(int.Parse(UserContainer.Instance.PathToIcon));
       // WWW www = new WWW("file://" + UserContainer.Instance.PathToIcon);
        //_icon.texture = www.texture;
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
