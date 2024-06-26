using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perro : animales
{
    public void Ladrar()
    {
        Debug.Log("Ladrar");
    }
    public void corretearCartero()
    {
        Debug.Log("corretear al cartero");
    }
    public override void comer()
    {
        Debug.Log("el perrito come");
    }
}


