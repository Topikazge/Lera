using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    [SerializeField] private VideoPlayer _videoPlayer;
    [SerializeField] private Button _goTest;
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
    }

    public void OnClickPauseButton()
    {
        _isPause = !_isPause;
        if (_isPause)
        {
            _videoPlayer.Pause();
        }
        else
        {
            _videoPlayer.Play();
        }
    }
}
