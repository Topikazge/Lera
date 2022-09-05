using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FileScriptTWO : FileScript
{
    protected override void CallManager()
    {
        AvatarManagerTWO.instanceTWO.SelectAvatar(index);
    }
}
