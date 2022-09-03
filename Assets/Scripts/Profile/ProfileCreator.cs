using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using SimpleFileBrowser;
using System.IO;

public class ProfileCreator : WindowActive
{
    [SerializeField] protected TextMeshProUGUI _nameField;
    [SerializeField] protected RawImage _imageField;
    [SerializeField] private Windowcontroler _controllerEnterWidow;
    [SerializeField] protected ProfileCreator _profileWindow;
    [SerializeField] protected AvatarManager _FileWindow;
    [SerializeField] protected MainController _mainController;



    public override void View()
    {
        Debug.Log("¿€¬¿€¬¿");
        _window.SetActive(true);
        gameObject.SetActive(true);
    }

    public void OnClick()
    {
        SaveChange();
    }

   
    public void CloseFile()
    {
        _FileWindow.Hide();
        _profileWindow.View();
    }

    public void OpenFiles()
    {
        _profileWindow.Hide();
        _FileWindow.View();
    }

    protected virtual void SaveChange()
    {
		string nameUser = _nameField.text;
        Texture2D imageUser = (Texture2D)_imageField.texture;
        Debug.Log(AvatarManager.PathToImage);
        string pathToImage = AvatarManager.PathToImage;
        // byte[] itemBGBytes = imageUser.EncodeToPNG();
        //string path = "\\Resources\\" + nameUser + ".png";
        // File.WriteAllBytes(path, itemBGBytes);
        ChangeUserProfil changeUserProfil = new ChangeUserProfil();
        changeUserProfil.SetUser(UserContainer.Instance).ChangeName(nameUser).ChangeIcon(pathToImage).Save();
        _controllerEnterWidow.OpenMain(this);
    }
}
