using UnityEngine;

public class CenterSwitcher : WindowActive
{
    [SerializeField] private VideoWindowController _videoWindowController;

    public void OpenVideoWindow(IWindowActive whoCalled, IWindowActive WhoToCall)
    {
        whoCalled.Hide();
        _videoWindowController.OpenWindowVideo(WhoToCall);
    }

    public void OpenVideoWindow(IWindowActive whoCalled)
    {
     //   whoCalled.Hide();
        _videoWindowController.View();
    }

}
