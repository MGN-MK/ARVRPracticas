using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigoVolador : superclase
{
    public void volador()
    {
        Debug.Log("vuela");
    }
    public  override void gameover()
    { 
        Debug.Log("fin del juego");
    }
}
    

