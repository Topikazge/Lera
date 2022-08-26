using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartWindow : MonoBehaviour, IWindowActive
{
    [SerializeField] private GameObject _objectContainer;
    [SerializeField] private ControllerEnterWidow _controller;
    public void Hide()
    {
        _objectContainer.SetActive(true);
    }

    public void View()
    {
        _objectContainer.SetActive(true);
    }

    public void OnClickLogin()
    {
        _controller.OpenLogin(this);
    }

    public void OnClickRegion()
    {
        _controller.OpenRegistration(this);
    }
}
