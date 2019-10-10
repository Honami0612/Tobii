using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    [SerializeField]
    Text timerText;
    [SerializeField]
    float totalTime;
    int second;
    [SerializeField]
    float span = 3f;
    public float current = 0f;

    private eyePosition eyePosition;
	// Use this for initialization
	void Start () {
        eyePosition = GameObject.Find("ThirdPersonController/MainCamera").GetComponent<eyePosition>();


    }
	
	// Update is called once per frame
	void Update () {
        current += Time.deltaTime;
        totalTime -= Time.deltaTime;
        second = (int)totalTime;
        timerText.text = "Timer:" + second.ToString();

        if (current>span)
        {
            current = 0f;
            Debug.Log("timersu");
            eyePosition.SubPointTimer();
           
           
        }

      
        if (totalTime <= 0)
        {
            SceneManager.LoadScene("ClearScene");
        }
	}
}
