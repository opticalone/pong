using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLaunch : MonoBehaviour
{


    public BallLaunch Ball;



    [Range (1 , 50)]
    public float speed;

    public GameObject ball;
    
	// Use this for initialization
	void Start ()
    {
        PushBall();
        
	}

    void PushBall()
    {
        int rand = Random.Range(0, 2);
        if (rand == 0)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(speed,0f,0f) ;
        }
        else if(rand ==1)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(-speed, 0f,0f);
        }
    }
}
