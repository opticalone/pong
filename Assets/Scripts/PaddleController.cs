using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaddleController : MonoBehaviour
{
    // two - player input controller
    //left paddle is P1 (w/s)
    //Right paddle is P2 (up/down)

    public GameObject LeftPaddle;
    public GameObject RightPaddle;

    [Range (1,25)]
    public float driveSpeed;

	void Start ()
    {
		
	}

    

	void Update ()
    {


        //if nothing is being pressed dont move
        if (!Input.anyKey)
        {
            LeftPaddle.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
        

        //up/down

		if (Input.GetKey(KeyCode.W)) //move paddle up
        {
            LeftPaddle.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, driveSpeed);
        }
        else if (Input.GetKey(KeyCode.S)) //move paddle down
        {
            LeftPaddle.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -driveSpeed);
        }




        //if nothing is being pressed dont move
        if (!Input.anyKey)
        {
            RightPaddle.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }


        //up/down

        if (Input.GetKey(KeyCode.UpArrow)) //move paddle up
        {
            RightPaddle.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, driveSpeed);
        }
        else if (Input.GetKey(KeyCode.DownArrow)) //move paddle down
        {
            RightPaddle.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -driveSpeed);
        }


        if (Input.GetKey(KeyCode.K))
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
