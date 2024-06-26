using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : superclase
{
    public void Esquiva()
    {
        Debug.Log("Esquiva obstaculos");
    }
    public void Salta()
    {
        Debug.Log("salto los ovstaculos");
    }
    public override void gameover()
    {
        Debug.Log("fin del juego");
    }
}
