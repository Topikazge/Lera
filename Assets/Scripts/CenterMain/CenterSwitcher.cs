using UnityEngine;

public class CenterSwitcher : WindowActive
{
    [SerializeField] private VideoWindowController _videoWindowController;
    [SerializeField] private ProfileUser _profileUser;
    [SerializeField] private TopicsList _topicsList;
    [SerializeField] private VideoController _videoController;

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

    public void OpenMain(IWindowActive whoCalled)
    {
        whoCalled.Hide();
        _topicsList.View();
    }

    public override void Hide()
    {
    //    _videoController.CloseVideoObject();
        base.Hide();
    }

    public override void View()
    { 
        base.View();
     //   _videoController.OpenVideoObject();
    }

}
