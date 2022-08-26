using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuthorizationFacade : MonoBehaviour, IWindowActive
{
    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void View()
    {
        gameObject.SetActive(true);
    }
}
