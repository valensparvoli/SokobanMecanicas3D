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
        if (other.CompareTag("Wall"))
        {
            Debug.Log("No seguir");
        }
       
    }
    private void OnTriggerExit(Collider other)
    {
       
    }

}
