using System;
using UnityEngine;
using UnityEngine.UI;

public class Moving : MonoBehaviour
{
    public Transform Target;    
    public float Speed;
            
       void Update()
    {
        transform.LookAt(Target);
        transform.position = Vector3.MoveTowards(transform.position, Target.position, Time.deltaTime * Speed);
    }
}
