using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pato : animales
{
    public void graznar()
    {
        Debug.Log("graznar");
    }
    public void volar()
    {
        Debug.Log("volar");
    }
    public override void comer()
    {
        Debug.Log("el cuack come");
    }
}

