using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListElement : MonoBehaviour
{
    [SerializeField] private ListButtonController _listButtonController;
    [SerializeField] private VideoWindow _videoWindow;
    public void OnClick()
    {
        _listButtonController.OpenVideoWindow(_videoWindow);
    }
}
