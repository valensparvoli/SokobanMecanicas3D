using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArribaBox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            BoxScript.puedeBajar = true;

        }

    }
    private void OnTriggerExit(Collider other)
    {
        

    }

}
