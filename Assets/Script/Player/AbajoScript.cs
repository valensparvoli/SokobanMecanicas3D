using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbajoScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            Player.movimientoAbajo = false;
        }
        if (other.CompareTag("Box"))
        {
            BoxScript.BoxAbajo = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Player.movimientoAbajo = true;
        BoxScript.BoxAbajo = false;
    }


}
