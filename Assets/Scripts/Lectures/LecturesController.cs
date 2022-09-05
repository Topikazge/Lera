using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LecturesController : WindowActive
{
    [SerializeField] private WindowActive _listLectures;
    [SerializeField] private WindowActive _lecturesWindow;


    public void OpenFirstLectures()
    {
        _listLectures.Hide();
        _lecturesWindow.View();
    }

    public void OpenListLectures()
    {
        _lecturesWindow.Hide();
        _listLectures.View();
    }

    public override void View()
    {
        base.View();
        OpenListLectures();


    }
}
