using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }

        // Destroy laser bolt
        Destroy(other.gameObject);
        // Destroy gameObject this script is attached to (i.e. the asteroid)
        Destroy(gameObject);
    }
}