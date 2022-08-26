using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowActive : MonoBehaviour,IWindowActive
{
    [SerializeField] protected GameObject _window;

    public virtual void Hide()
    {
        _window.SetActive(false);
    }

    public virtual void View()
    {
        _window.SetActive(true);
    }
}
