using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CircleFormation : MonoBehaviour
{    
    public GameObject Prefab;
    public int numberOfObjects = 5;
    public float radius = 8.3f;   
    public float speed;
   
    void Start()
    {
        
       // numberOfObjects = SceneManagement.points;
        for (int i = 0; i < numberOfObjects; i++)
        {
            float angle = i * Mathf.PI * 2 / numberOfObjects;
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;
            Vector3 pos = transform.position + new Vector3(x, 1, z);
            float angleDegrees = -angle * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
            Instantiate(Prefab, pos, rot);
        }
    }

   
}