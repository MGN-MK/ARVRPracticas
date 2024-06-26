using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class BarcodeManager : MonoBehaviour
{
    public static BarcodeManager Instance;
    public List<string> History;
    public bool wasDetected = false;
    public int lastLinkIndex = 0;

    private void Awake()
    {
        if(Instance != null)
        {
            return;
        }
        else
        {
            Instance = this;
        }
    }

    public void AccessToQRWebSite()
    {
        if (History.Count > 0 && lastLinkIndex >= 0 && History[lastLinkIndex] != null)
        {
            Application.OpenURL(History[lastLinkIndex]);
        }
        else
        {
            Debug.Log("Fuera del array o está vacío");
        }
    }
}
