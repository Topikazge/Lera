using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
public class AvatarManager : WindowActive
{
    [SerializeField] private ProfileCreator _creator;
    public GameObject fileListPan, fileContent, filePrefab;
    public RawImage avatarImg;
    private DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\Macroflai\Documents\GitHub\FirstSite\Image\Portfolio");
  // private DirectoryInfo dirInfo = new DirectoryInfo("/mnt/sdcard");
    private FileInfo[] files;
    private GameObject[] instanceObjs;

    public static AvatarManager instance;
    private void Awake()
    {
        instance = this;
    }

    public override void View()
    {
        base.View();
        LoadAvatarsList();
    }


    public void LoadAvatarsList()
    {
        fileListPan.SetActive(true); avatarImg.gameObject.SetActive(false);
        files = new string[] { "*.jpeg", "*.jpg", "*.png" }.SelectMany(ext => dirInfo.GetFiles(ext, SearchOption.AllDirectories)).ToArray();
        instanceObjs = new GameObject[files.Length];
        for (int i = 0; i < files.Length; i++)
        {
            FileScript file = Instantiate(filePrefab, fileContent.transform).GetComponent<FileScript>();
            file.fileNameText.text = files[i].Name;
            file.index = 1;
            instanceObjs[i] = file.gameObject;
        }
    }
    public void SelectAvatar(int index)
    {
        Debug.Log("Âûגאûגאûגאûגאûגאûגאאגאף");
        WWW www = new WWW("file://" + files[index].FullName);
        avatarImg.texture = www.texture;
        fileListPan.SetActive(false); avatarImg.gameObject.SetActive(true);
        foreach (GameObject obj in instanceObjs)
            Destroy(obj);
        _creator.CloseFile();
    }
}