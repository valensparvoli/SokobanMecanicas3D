using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static bool movimientoArriba=true;
    public static bool movimientoAbajo = true;
    public static bool movimientoDerecha = true;
    public static bool movimientoIzquierda= true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movimientoArriba == true)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.Translate(0, 0, 1);
            }
        }
        if (movimientoAbajo == true)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.Translate(0, 0, -1);
            }
        }
        if (movimientoDerecha == true)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.Translate(1, 0, 0);
            }

            }
        if (movimientoIzquierda==true)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.Translate(-1, 0, 0);
            }
        }


    }

}
