using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DerechaBox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            BoxScript.puedeIzquierda = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {

    }
}
