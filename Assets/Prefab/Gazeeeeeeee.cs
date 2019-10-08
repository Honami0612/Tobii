﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;
using UnityEngine.UI;

public class Gazeeeeeeee : MonoBehaviour {
    private GazeAware gazeAware;
    [SerializeField]
    Text lifeText;
    private int score = 100;

    eyePosition eyeposition;

	// Use this for initialization
	void Start () {
        gazeAware = GetComponent<GazeAware>();
        
	}
	
	// Update is called once per frame
	void Update () {
        lifeText.text = point.ToString();
        bool flag = gazeAware.HasGazeFocus;
        Debug.Log(flag);
        if (flag)
        {
            if (gameObject.tag == "Fruits")
            {
                Destroy(this.gameObject);
                point += 30;
            }
            else if (gameObject.tag == "Poison")
            {
                Destroy(this.gameObject);
                point -= 50;
            }
        }
	}

    
}