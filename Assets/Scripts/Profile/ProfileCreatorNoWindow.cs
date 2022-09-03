using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileCreatorNoWindow : ProfileCreator
{

    protected override void SaveChange()
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
        _mainController.OpenProfileWindow();
    }
}
