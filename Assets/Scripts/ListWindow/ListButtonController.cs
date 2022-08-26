using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListButtonController : WindowActive
{
    [SerializeField] private CenterSwitcher _centerSwitcher;


    public void OpenVideoWindow(IWindowActive WhoToCall)
    {
        _centerSwitcher.OpenVideoWindow(this,WhoToCall);
    }
}
