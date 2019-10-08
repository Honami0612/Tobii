using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;
using UnityEngine.UI;

public class Gazeeeeeeee : MonoBehaviour {
    private GazeAware gazeAware;
    private eyePosition eyePosition;


    //private int point = 100;

	// Use this for initialization
	void Start () {
        gazeAware = GetComponent<GazeAware>();
        eyePosition= GameObject.Find("MainCamera").GetComponent<eyePosition>();

    }
	
	// Update is called once per frame
	void Update () {

        bool flag = gazeAware.HasGazeFocus;
        Debug.Log(flag);
        if (flag)
        {
            Destroy(this.gameObject);
            if (gameObject.tag == "Fruits")
            {
                eyePosition.AddPoint();
                Destroy(this.gameObject);
            }
            else if (gameObject.tag == "Poison")
            {
                eyePosition.SubPoint();
                Destroy(this.gameObject);

            }
        }
	}

    //public int Point
    //{
    //    get{ return point; }
    //    set{ point = value; }
    //}


}
