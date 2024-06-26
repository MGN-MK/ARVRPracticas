using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIButtons : MonoBehaviour
{
    public void OpenQR(TextMeshProUGUI getText)
    {
        if(getText.text != null)
        {
            OpenURL(getText.text);
        }
    }

    public void OpenURL(string url)
    {
        Application.OpenURL(url);
    }
}
