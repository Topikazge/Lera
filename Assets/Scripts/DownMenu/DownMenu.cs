using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DownMenu : MonoBehaviour
{
    [Header("Майн")]
    [SerializeField] private Sprite _mainOpen;
    [SerializeField] private Sprite _mainClose;
    [SerializeField] private GameObject _mainObject;
    [SerializeField] private Image _imageMain;
    [SerializeField] private CenterSwitcher _centerSwitcher;
    [Header("Профиль")]
    [SerializeField] private Sprite _profileOpen;
    [SerializeField] private Sprite _profileClose;
    [SerializeField] private GameObject _profileObject;
    [SerializeField] private Image _imageProfile;
    [SerializeField] private ProfileUser _profileUser;

    public void  OpenMain()
    {
        _profileObject.SetActive(false);
        _imageMain.sprite = _mainOpen;
        _imageProfile.sprite = _profileClose;
        _profileUser.Hide();
        _centerSwitcher.View();
      
    }

    public void OpenProfile()
    {
        _mainObject.SetActive(false);
        _imageMain.sprite = _mainClose;
        _imageProfile.sprite = _profileOpen;

        _centerSwitcher.Hide();
        _profileUser.View();
    }
}
