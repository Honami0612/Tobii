using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;


[RequireComponent(typeof(GazeAware))]

public class Gazeeeeeeee : MonoBehaviour {
    private GazeAware gazeAware;
    private eyePosition eyePosition;


  

	// Use this for initialization
	void Start () {
       
        gazeAware = GetComponent<GazeAware>();
       eyePosition = GameObject.Find("ThirdPersonController/MainCamera").GetComponent<eyePosition>();
    }

    // Update is called once per frame
    void Update () {

    //bool flag = gazeAware.HasGazeFocus;
       

        //  Debug.Log(flag);
        if (gazeAware.HasGazeFocus)
        {
            Debug.LogError("flagin%%%%%%%%%%");
            if (this.gameObject.tag == "Fruits")
            {
                Debug.Log("Fruits!!!!!");
                eyePosition.AddPoint();
                Destroy(this.gameObject);
            }
            else if (this.gameObject.tag == "Poison")
            {
                Debug.Log("Poison");
                eyePosition.SubPoint();
                Destroy(this.gameObject);

            }
        }
	}

   

}
