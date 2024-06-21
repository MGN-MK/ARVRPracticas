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
        if (mBarcodeBehaviour != null && mBarcodeBehaviour.InstanceData != null)
        {
            if(!BarcodeManager.Instance.wasDetected)
            {
                BarcodeManager.Instance.History.Add(mBarcodeBehaviour.InstanceData.Text);
                BarcodeManager.Instance.wasDetected = true;
            }

            barcodeAsText.text = mBarcodeBehaviour.InstanceData.Text;
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
