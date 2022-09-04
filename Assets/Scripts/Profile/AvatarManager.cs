using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using Unity.VisualScripting;

public class AvatarManager : WindowActive
{
    public FileInfo[] FileS
    {
        get
        {
            Debug.Log("Return  files");
            return files;
        }
        set
        {
            Debug.Log("set  files value: " + value);
            files = value;
        }
    }
    public static int IdIcon = 1;
    [SerializeField] private ProfileCreator _creator;
    public GameObject fileListPan, fileContent, filePrefab;
    public RawImage avatarImg;
   // private DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\LordJ\OneDrive\Desktop\Картинки");
    private DirectoryInfo dirInfo = new DirectoryInfo("/storage");
    private FileInfo[] files;
    private GameObject[] instanceObjs;
    [SerializeField] private IconsContainer _iconsContainer;

    public  IconsContainer IconsContainer => _iconsContainer;

    public static AvatarManager instance;
    public void Awake()
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
       fileListPan.SetActive(true); 
        avatarImg.gameObject.SetActive(false);
       /*  FileS = new string[] { "*.jpeg", "*.jpg", "*.png" }.SelectMany(ext => dirInfo.GetFiles(ext, SearchOption.AllDirectories)).ToArray();
        instanceObjs = new GameObject[FileS.Length];
        for (int i = 0; i < FileS.Length; i++)
        {
            FileScript file = Instantiate(filePrefab, fileContent.transform).GetComponent<FileScript>();
            file.fileNameText.text = FileS[i].Name;
            file.index = i;
            instanceObjs[i] = file.gameObject;
        }
        Debug.Log("file in Load: " + FileS.Length);*/
    }
    public void SelectAvatar(int index)
    {
        /* Debug.Log("file in Load: " + FileS.Length);
         WWW www = new WWW("file://" + FileS[index].FullName);*/
        IdIcon = index;
        avatarImg.texture = _iconsContainer.GetSprite(index);
       // PathToImage = www.url;
        fileListPan.SetActive(false); 
        avatarImg.gameObject.SetActive(true);
        /*foreach (GameObject obj in instanceObjs)
            Destroy(obj);*/
        _creator.CloseFile();
    }
}