using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FileScript : MonoBehaviour
{
    public TextMeshProUGUI fileNameText;

    public int index;
    public void OnClick()
    {
        Debug.Log("Вызывю картинку");
        AvatarManager.instance.SelectAvatar(index);
    }
}