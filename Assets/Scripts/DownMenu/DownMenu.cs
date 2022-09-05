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
    [Header("Лекции")]
    [SerializeField] private LecturesController _lecturesController;
    [SerializeField] private Sprite _lectureOpen;
    [SerializeField] private Sprite _lectureClose;
    [SerializeField] private Image _imageLecture;



    public void  OpenMain()
    {
        _profileObject.SetActive(false);
        _imageMain.sprite = _mainOpen;
        _imageProfile.sprite = _profileClose;
        _imageLecture.sprite = _lectureClose;
        _lecturesController.Hide();
        _profileUser.Hide();
        _centerSwitcher.View();
      
    }

    public void OpenProfile()
    {
        _mainObject.SetActive(false);
        _imageMain.sprite = _mainClose;
        _imageProfile.sprite = _profileOpen;
        _imageLecture.sprite = _lectureClose;
        _lecturesController.Hide();
        _centerSwitcher.Hide();
        _profileUser.View();
    }

    public void OpenLecture()
    {
        _imageMain.sprite = _mainClose;
        _imageProfile.sprite = _profileClose;
        _imageLecture.sprite = _lectureOpen;
        _centerSwitcher.Hide();
        _profileUser.Hide();
        _lecturesController.View();
    }

}
