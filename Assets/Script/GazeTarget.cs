using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;

public class GazeTarget : MonoBehaviour {

    private GazeAware gazeAware;

	// Use this for initialization
	void Start () {
        gazeAware = GetComponent<GazeAware>();
	}
	
	// Update is called once per frame
	void Update () {
        bool flg = gazeAware.HasGazeFocus;
        Debug.Log("flg");
	}
}
