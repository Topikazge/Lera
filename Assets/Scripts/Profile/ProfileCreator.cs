using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using SimpleFileBrowser;
using System.IO;

public class ProfileCreator : MonoBehaviour, IWindowActive
{
    [SerializeField] private TextMeshProUGUI _nameField;
    [SerializeField] private RawImage _imageField;
    [SerializeField] private Windowcontroler _controllerEnterWidow;
    [SerializeField] private ProfileCreator _profileWindow;
    [SerializeField] private AvatarManager _FileWindow;
    [SerializeField] private MainController _mainController;

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

    private void SaveChange()
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
