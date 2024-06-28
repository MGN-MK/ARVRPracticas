using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class BarcodeManager : MonoBehaviour
{
    public static BarcodeManager Instance;
    public GameObject GoToWebButton, HistoryTitleElementPrefab, HistoryConteiner, HistoryWindow;
    public List<string> History;
    public List<GameObject> HistoryTitleElements;
    public bool wasDetected = false;
    public int lasWebSiteLinkIndex = 0;

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
        if (History.Count > 0 && lasWebSiteLinkIndex >= 0 && History[lasWebSiteLinkIndex] != null)
        {
            Application.OpenURL(History[lasWebSiteLinkIndex]);
        }
        else
        {
            Debug.Log("Fuera del array o está vacío");
        }
    }

    public void AccessToURL(string _url)
    {
        if(_url != null)
        {
            Application.OpenURL(_url);
        }
    }

    public string GetLastItemFromHistory()
    {
        return History[lasWebSiteLinkIndex];
    }

    public void GoToWebSite_Btn_Status()
    {
        if (!wasDetected)
        {
            GoToWebButton.transform.GetChild(0).GetComponent<Button>().interactable = false;
            GoToWebButton.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().color = Color.gray;
            GoToWebButton.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Analizando...";
        }
        else
        {
            GoToWebButton.transform.GetChild(0).GetComponent<Button>().interactable = true;
            GoToWebButton.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().color = new Color32(245, 56, 85, 255);
            GoToWebButton.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "ACCEDER";
        }
    }

    public void ActiveHistoryWindow()
    {
        HistoryWindow.SetActive(true);
    }

    public void DeactiveHistoryWindow()
    {
        HistoryWindow.SetActive(false);
    }

    public void StoreHistoryItem(string _item)
    {       
        if (!wasDetected)
        {
            //Agregamos al historial el elemento a guardar
            History.Add(_item);

            //Creamos un gameobject para el HistoryTitleItem
            GameObject item = Instantiate(HistoryTitleElementPrefab);

            //Agregar al hisotrial el texto del elemento
            item.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = _item;

            //Almacenamos el GO en su lista
            HistoryTitleElements.Add(item);

            //Hacemos hijo de HistoryContainer al nuevo item
            item.transform.parent = HistoryConteiner.transform;
            item.transform.localPosition = new Vector3(0, 0, 0);

            //Activamos que el item fue detectado
            wasDetected = true;

            //Revisar si nuestro historial es mayor a 0
            if (History.Count == 1)
            {
                lasWebSiteLinkIndex = 0;
            }
            else
            {
                lasWebSiteLinkIndex++;
            }
        }
    }
}
