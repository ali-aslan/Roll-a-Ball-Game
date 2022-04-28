using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Cam_Control : MonoBehaviour
{
    public GameObject Ball_lock;
    Vector3 distance;
    void Start()
    {
        distance = transform.position - Ball_lock.transform.position;
        
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = distance+Ball_lock.transform.position;
    }
}
