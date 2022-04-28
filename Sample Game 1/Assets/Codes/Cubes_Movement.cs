using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       transform.Rotate(new Vector3(15,30,45)*Time.fixedDeltaTime);
       //Debug.Log(Time.fixedDeltaTime);
    }
}
