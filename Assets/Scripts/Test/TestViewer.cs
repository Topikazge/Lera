using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestViewer : WindowActive
{
    [SerializeField] private ResultTest _resultTest;
    [SerializeField] private CenterSwitcher _centerSwitcher;
    [SerializeField] private QuestionController _questionController;

    public void ViewResult(IWindowActive whoCall, int result, int max)
    {
        whoCall.Hide();
        _resultTest.ViewResult(result, max);
    }

    public void OpenVideo(IWindowActive whoCall, IWindowActive whoToCall)
    {
        whoCall.Hide();
        _centerSwitcher.OpenVideoWindow(this, whoToCall);
    }

    public override void View()
    {
        base.View();
        _questionController.View();
    }
}
