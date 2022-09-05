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
        CallManager();
    }

    protected virtual void CallManager()
    {
        AvatarManager.instance.SelectAvatar(index);
    }
}