using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigoVolador : superclase
{
    [SerializeField] private Vector3 startpos;
    float velocidadX;
    private void Start()
    {
        startpos = transform.position;
    }
    public void Update()
    {
        Enemigo();
    }
    public override void Enemigo()
    {
        velocidadX+= 1f;
        transform.position = new Vector3(0, velocidadX, 0);
        Debug.Log("vuela");
    }

    public void volador()
    {
        Debug.Log("vuela");
    }
    public  override void gameover()
    { 
        Debug.Log("fin del juego");
    }
}
    

