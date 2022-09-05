using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLectures : WindowActive
{
    [SerializeField] private LecturesController _lecturesController;


    public void OnClick()
    {
        _lecturesController.OpenFirstLectures();
    }
}
