using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class animales : MonoBehaviour
{
    string Nombre;
    string Color;
    int Edad;

    public virtual void comer()
    {
        Debug.Log("Comer");
    }
    public void Dormir()
    {
        Debug.Log("Dormir");
    }
}




