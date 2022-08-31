using UnityEngine;

public class CenterSwitcher : WindowActive
{
    [SerializeField] private VideoWindowController _videoWindowController;
    [SerializeField] private ProfileUser _profileUser;

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

    public void OpenProfileWindwo(IWindowActive whoCalled)
    {
          whoCalled.Hide();
        _profileUser.View();
    }

}
