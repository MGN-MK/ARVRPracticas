using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gato : animales
{
    public void maullar()
    {
        Debug.Log("maullar");
    }
    public override void comer()
    {
        Debug.Log("el gato come");
    }
}
