using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;
using UnityEngine.UI;

public class Gazeeeeeeee : MonoBehaviour {
    private GazeAware gazeAware;

    //private int point = 100;

	// Use this for initialization
	void Start () {
        gazeAware = GetComponent<GazeAware>();
        
	}
	
	// Update is called once per frame
	void Update () {

        bool flag = gazeAware.HasGazeFocus;
        Debug.Log(flag);
        if (flag)
        {
            Destroy(this.gameObject);
            /*if (gameObject.tag == "Fruits")
            {
                Destroy(this.gameObject);
                point += 30;
            }
            else if (gameObject.tag == "Poison")
            {
                Destroy(this.gameObject);
                point -= 50;
            }*/
        }
	}

  /*  public int Sentpoint()
    {
        get{ return point; }
        set{ point = value; }
    }
    */

}
