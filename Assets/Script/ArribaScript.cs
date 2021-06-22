using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArribaScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            Player.movimientoArriba = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Player.movimientoArriba = true;
    }


}
