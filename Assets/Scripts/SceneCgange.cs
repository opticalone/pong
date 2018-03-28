using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneCgange : MonoBehaviour
{
    public void sceneChange(int scene_num)
    {
        SceneManager.LoadScene(scene_num);
    }
	
}
