using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FileScript : MonoBehaviour
{
    public TextMeshProUGUI fileNameText;

    public int index;
    public void OnClick()
    {
        Debug.Log("������ ��������");
        AvatarManager.instance.SelectAvatar(index);
    }
}