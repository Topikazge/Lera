using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ProfileCreator : MonoBehaviour, IWindowActive
{
    [SerializeField] private TextMeshProUGUI _nameField;
    [SerializeField] private Image _imageField;

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void View()
    {
        gameObject.SetActive(true);
    }

    public void OnClick()
    {
        SaveChange();
    }

   

    private void SaveChange()
    {
        string nameUser = _nameField.text;
        Sprite imageUser = _imageField.sprite;
       // Texture2D itemBGTex = imageUser.texture;
       // byte[] itemBGBytes = itemBGTex.EncodeToPNG();
      //  string path = "/Resources" + nameUser + ".png";
      //  File.WriteAllBytes(path, itemBGBytes);
        ChangeUserProfil changeUserProfil = new ChangeUserProfil();
        changeUserProfil.SetUser(UserContainer.Instance).ChangeName(nameUser).ChangeIcon("Assets/Resources/1.png").Save();

    }
}
