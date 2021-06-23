using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IzquierdaScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            Player.movimientoIzquierda = false;
        }
        if (other.CompareTag("Box"))
        {
            BoxScript.BoxIzquierda = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Player.movimientoIzquierda = true;
        BoxScript.BoxIzquierda = false;
    }
}
