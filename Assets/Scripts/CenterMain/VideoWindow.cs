using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoWindow : WindowActive
{
    [SerializeField] private VideoWindowController _videoWindowController;

    public void OpenVideoController()
    {
        _videoWindowController.OpenTestFirst(this);
    }

    public void OpenMain()
    {
        _videoWindowController.OpenMain(this);
    }
} 
