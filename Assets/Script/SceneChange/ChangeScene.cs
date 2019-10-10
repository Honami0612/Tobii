using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Tobii.Gaming;

public class ChangeScene : MonoBehaviour {


    private GazeAware gazeAware;

    // Use this for initialization
    void Start () {
        gazeAware = GameObject.Find("Canvas/Button").GetComponent<GazeAware>();
    }
	
	// Update is called once per frame
	void Update () {
        //if (gazeAware.HasGazeFocus)
        //{
        //    SceneManager.LoadScene("MainScene");
        //}
    }



    public void OnClick(int number)
    {
        switch (number)
        {
            case 0:
                SceneManager.LoadScene("MainScene");
                break;
            case 1:
                SceneManager.LoadScene("ClearScene");
                break;
        }
    }
}
