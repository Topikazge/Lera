using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Icons", order = 2)]
public class IconsContainer : ScriptableObject
{
   [SerializeField] private Texture2D[] _icons;

    public Texture2D GetSprite(int index)
    {
        Debug.Log("index - " + index);
        Debug.Log("_icons - " + _icons.Length);
        return _icons[index-1];
    }
}
