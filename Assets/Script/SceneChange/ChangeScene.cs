using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
