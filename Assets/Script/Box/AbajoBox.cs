using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbajoBox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            BoxScript.puedeSubir = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {

    }
}
