using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResultTest : WindowActive
{
    [SerializeField] private TestViewer _testViewer;     
    [SerializeField] private TextMeshProUGUI _resultText;
    [SerializeField] private VideoWindow _videoWindow;

    public void ViewResult(int result,int max)
    {
        View();
        _resultText.text = result.ToString() +"/"+ max.ToString();
        Debug.Log("fgd");
    }

    public void ReturnToVideo()
    {
        _testViewer.OpenVideo(this, _videoWindow);
    }
}
