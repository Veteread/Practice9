using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private void OnTriggerEnter(Collider sphereIn)
    {
        sphereIn.GetComponent<Rigidbody>().useGravity = false;
    }

    private void OnTriggerExit(Collider sphereOut)
    {
        sphereOut.GetComponent<Rigidbody>().useGravity = true;
    }
}
