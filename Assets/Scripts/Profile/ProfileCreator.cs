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
    [SerializeField] private Image _imageField;
    [SerializeField] private Windowcontroler _controllerEnterWidow;
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
		OpenFileBrowser();
		/*string nameUser = _nameField.text;
        Sprite imageUser = _imageField.sprite;
       // Texture2D itemBGTex = imageUser.texture;
       // byte[] itemBGBytes = itemBGTex.EncodeToPNG();
      //  string path = "/Resources" + nameUser + ".png";
      //  File.WriteAllBytes(path, itemBGBytes);
        ChangeUserProfil changeUserProfil = new ChangeUserProfil();
        changeUserProfil.SetUser(UserContainer.Instance).ChangeName(nameUser).ChangeIcon("Assets/Resources/1.png").Save();
        _controllerEnterWidow.OpenMain(this);*/
    }

	void OpenFileBrowser()
	{
		
		StartCoroutine(ShowLoadDialogCoroutine());
	}

	IEnumerator ShowLoadDialogCoroutine()
	{
		// Show a load file dialog and wait for a response from user
		// Load file/folder: both, Allow multiple selection: true
		// Initial path: default (Documents), Initial filename: empty
		// Title: "Load File", Submit button text: "Load"
		yield return FileBrowser.WaitForLoadDialog(FileBrowser.PickMode.FilesAndFolders, true, null, null, "Load Files and Folders", "Load");

		// Dialog is closed
		// Print whether the user has selected some files/folders or cancelled the operation (FileBrowser.Success)
		Debug.Log(FileBrowser.Success);

		if (FileBrowser.Success)
		{
			// Print paths of the selected files (FileBrowser.Result) (null, if FileBrowser.Success is false)
			for (int i = 0; i < FileBrowser.Result.Length; i++)
				Debug.Log(FileBrowser.Result[i]);

			// Read the bytes of the first file via FileBrowserHelpers
			// Contrary to File.ReadAllBytes, this function works on Android 10+, as well
			byte[] bytes = FileBrowserHelpers.ReadBytesFromFile(FileBrowser.Result[0]);

			// Or, copy the first file to persistentDataPath
			string destinationPath = Path.Combine(Application.persistentDataPath, FileBrowserHelpers.GetFilename(FileBrowser.Result[0]));
			FileBrowserHelpers.CopyFile(FileBrowser.Result[0], destinationPath);
		}
	}
}
