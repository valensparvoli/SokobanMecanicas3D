using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IzquierdaBox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            BoxScript.puedeDerecha = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {

    }
}
