using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    [SerializeField]
    Text timerText;
    [SerializeField]
    float totalTime;
    int second;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        totalTime -= Time.deltaTime;
        second = (int)totalTime;
        timerText.text = "Timer:" + second.ToString();
        if (totalTime <= 0)
        {
            //Clear
        }
	}
}
