using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superclase : MonoBehaviour
{
    [SerializeField]
    string jugador;
    [SerializeField]
    string objeto;
    [SerializeField]
    int velocidad;
    [SerializeField]
    enemigoVolador velocidadVertical;

    public virtual void Enemigo()
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