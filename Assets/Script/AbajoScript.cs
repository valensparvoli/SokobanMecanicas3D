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
    }
    private void OnTriggerExit(Collider other)
    {
        Player.movimientoAbajo = true;
    }


}
