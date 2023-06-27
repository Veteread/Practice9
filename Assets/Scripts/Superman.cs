using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superman : MonoBehaviour
{    
    public AudioSource Kick;
    public Transform Trash;    
    public float Power;

    private void OnTriggerEnter(Collider box)
    {
        if (box.gameObject.name == "Trig")
        {
            GetComponent<Rigidbody>().isKinematic = true;
        }
    }

     private void OnCollisionEnter(Collision badguy)
    {       
        Vector3 direction = Trash.position - transform.position;
        badguy.rigidbody.AddForce(direction * Power, ForceMode.Impulse);
        Kick.Play();     
    }

}
