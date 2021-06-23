using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public static bool BoxDerecha = true;
    public static bool BoxIzquierda = true;
    public static bool BoxArriba = true;
    public static bool BoxAbajo = true;

    public static bool puedeSubir = false;
    public static bool puedeBajar = false;
    public static bool puedeDerecha = false;
    public static bool puedeIzquierda = false;

    public static bool Movimiento = true;

    public bool movimientoArriba = false;

    private void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            if (BoxDerecha == true)
            {
                if (puedeIzquierda == true)
                {
                    transform.Translate(-1, 0, 0);
                }
            }
            if (BoxIzquierda == true)
            {
                if (puedeDerecha == true)
                {
                    transform.Translate(1, 0, 0);
                }
            }
            if (BoxArriba == true)
            {
                if (puedeBajar == true)
                {
                    transform.Translate(0, 0, -1);
                }
            }
            if (BoxAbajo == true)
            {
                if (puedeSubir == true)
                {
                    Debug.Log("Subiendo");
                    transform.Translate(0,0,1);
                }
            }
        }
       
    }
}
