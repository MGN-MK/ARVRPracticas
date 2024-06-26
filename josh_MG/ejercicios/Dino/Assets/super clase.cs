using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superclase : MonoBehaviour
{
    string jugador;
    string objeto;
    int velocidad;

    public void Enemigo()
    {
        Debug.Log("Volador");
    }
    public void Obstaculo()
    {
        Debug.Log("Tierra");
    }
    public virtual void gameover()
    {
        Debug.Log("fin del juego");
    }
}