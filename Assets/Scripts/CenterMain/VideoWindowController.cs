using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoWindowController : WindowActive
{
    public void OpenWindowVideo(IWindowActive WhoToCall)
    {
        View();
        WhoToCall.View();
    }
}
