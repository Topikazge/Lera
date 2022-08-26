using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : WindowActive
{
    public override void Hide()
    {
        _window.SetActive(false);
    }

    public override void View()
    {
        _window.SetActive(true);
    }
}
