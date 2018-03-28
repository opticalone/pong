using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float Rotate_X;
    public float Rotate_Y;
    public float Rotate_Z;

    

    // Update is called once per frame
    void Update ()
    {
       transform.Rotate(Rotate_X, Rotate_Y, Rotate_Z);
        
	}
}
