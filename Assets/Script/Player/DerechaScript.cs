using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DerechaScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            Player.movimientoDerecha = false;
        }
        if (other.CompareTag("Box"))
        {
            BoxScript.BoxDerecha = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Player.movimientoDerecha = true;
        BoxScript.BoxDerecha = false;
    }



}
