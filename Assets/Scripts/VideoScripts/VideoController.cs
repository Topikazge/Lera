using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    [SerializeField] private VideoPlayer _videoPlayer;
    [SerializeField] private Button _goTest;
    [SerializeField] private GameObject _videoObject;
    private long _frame;
    private bool _isPause;

    private void OnEnable()
    {
        _videoPlayer.Pause();
        _isPause = true;
        _videoPlayer.loopPointReached += FinishedVideo;
    }

    private void FinishedVideo(UnityEngine.Video.VideoPlayer vp)
    {
        _goTest.interactable = true;
        _isPause = true;
        Debug.Log("Кнопка заработала");
        CloseVideoObject();
    }

    public void OpenVideoObject()
    {
        _videoObject.SetActive(true);
        _isPause = false;
        _videoPlayer.frame = _frame;
        _videoPlayer.Play();
    }

    public void CloseVideoObject()
    {
        _isPause = true;
        _videoPlayer.Pause();
        _frame = _videoPlayer.frame;
        _videoObject.SetActive(false);
    }

    public void OnClickPauseButton()
    {
        _isPause = !_isPause;
        if (_isPause)
        {
            _frame = _videoPlayer.frame;
            _videoPlayer.Pause();
        }
        else
        {
             _videoPlayer.frame = _frame;
            _videoPlayer.Play();
        }
    }
}
