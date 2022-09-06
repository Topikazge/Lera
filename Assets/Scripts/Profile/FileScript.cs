using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FileScript : MonoBehaviour
{
    public TextMeshProUGUI fileNameText;
    [SerializeField] private Sprite _image;
    [SerializeField] private Image _imageUI;

    public int index;

    public void Awake()
    {
        _imageUI.sprite = _image;
    }

    public void OnClick()
    {
        Debug.Log("Вызывю картинку");
        CallManager();
    }

    protected virtual void CallManager()
    {
        AvatarManager.instance.SelectAvatar(index);
    }
}