using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopicsList : WindowActive
{
    [SerializeField] private ListButtonController _listButtonController;

    public override void View()
    {
        base.View();
        _listButtonController.View();
    }
}
