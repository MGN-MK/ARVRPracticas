using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;

public class SimpleBarcodeScanner : MonoBehaviour
{
    public TextMeshProUGUI barcodeAsText;
    BarcodeBehaviour mBarcodeBehaviour;

    void Start()
    {
        mBarcodeBehaviour = GetComponent<BarcodeBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        BarcodeManager.Instance.GoToWebSite_Btn_Status();
        if (mBarcodeBehaviour != null && mBarcodeBehaviour.InstanceData != null)
        {
            BarcodeManager.Instance.StoreHistoryItem(mBarcodeBehaviour.InstanceData.Text);
            barcodeAsText.text = BarcodeManager.Instance.GetLastItemFromHistory();
        }
        else
        {
            barcodeAsText.text = "";
        }
    }

    private void OnDestroy()
    {
        BarcodeManager.Instance.wasDetected = false;
    }
}
