using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileCreatorNoWindow : ProfileCreator
{
    [SerializeField] protected IconsContainer _iconsContainer;


    private void Awake()
    {
        _imageField.texture = _FileWindow.IconsContainer.GetSprite(int.Parse(UserContainer.Instance.PathToIcon));
    }

    protected override void SaveChange()
    {
        string nameUser = _nameField.text;
        Texture2D imageUser = (Texture2D)_imageField.texture;       
        string pathToImage = AvatarManager.IdIcon.ToString();
        // byte[] itemBGBytes = imageUser.EncodeToPNG();
        //string path = "\\Resources\\" + nameUser + ".png";
        // File.WriteAllBytes(path, itemBGBytes);
        ChangeUserProfil changeUserProfil = new ChangeUserProfil();
        changeUserProfil.SetUser(UserContainer.Instance).ChangeName(nameUser).ChangeIcon(pathToImage).Save();
        _imageField.texture = _FileWindow.IconsContainer.GetSprite(int.Parse(UserContainer.Instance.PathToIcon));

        _mainController.OpenProfileWindow();
    }
}
