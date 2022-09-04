using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SDFSDFSDF : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _MASSAGE; 

    public void OnCleck()
    {
        _MASSAGE.text = WorkJson.PathToFile;
    }
}
