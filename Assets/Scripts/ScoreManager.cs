using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public GameObject[] PointsP1;//Point capsules on screen
   

    public int scoreP1 = 0;

    // Use this for initialization
    void Start () {
        scoreP1 = 1;
        for(int i = 0; i < PointsP1.Length; i++)
        {
            PointsP1[i].gameObject.SetActive(false);
            
        }
        
    }
	
    BallLaunch ball;
    void OnTriggerEnter(Collider other)
    {
        scoreP1++;
        addPoints();
    }

    void addPoints()
    {
        PointsP1[scoreP1-2].gameObject.SetActive(true);


        //for(int i = 0; i <= scoreP1; i++)
        //{
        //    PointsP1[i].gameObject.SetActive(true);
        //}
     
    }

}
