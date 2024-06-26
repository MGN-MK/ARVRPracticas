using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigoTierra :superclase
{
    public void Tierra()
    {
        Debug.Log("permanece en Tierra");
    }
    public override void gameover()
    {
        Debug.Log("fin del juego");
    }
}