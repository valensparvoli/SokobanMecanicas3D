using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Box"))
        {
            Debug.Log("Ola");
        }
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("Xd");
            
        }
    }
}
