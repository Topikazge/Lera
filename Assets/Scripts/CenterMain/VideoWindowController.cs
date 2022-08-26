using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoWindowController : WindowActive
{
    [SerializeField] private VideoWindow _videoWindow;
    [SerializeField] private TestViewer _testViewer;
    [SerializeField] private VideoWindow VideoWindow;

    public void OpenWindowVideo(IWindowActive WhoToCall)
    {
        View();
        WhoToCall.View();
        VideoWindow.View();
    }



    public void OpenTestFirst(IWindowActive WhoToCall)
    {
        WhoToCall.Hide();
        View();
        _testViewer.View();
    }

}
