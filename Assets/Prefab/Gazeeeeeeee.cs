using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;


[RequireComponent(typeof(GazeAware))]

public class Gazeeeeeeee : MonoBehaviour {
    private GazeAware gazeAware;
    private eyePosition eyePosition;

    AudioSource audioSource;
    [SerializeField]
    List<AudioClip> soundPoint = new List<AudioClip>();


    // Use this for initialization
    void Start () {

        audioSource = GetComponent<AudioSource>();
        gazeAware = GetComponent<GazeAware>();
       eyePosition = GameObject.Find("ThirdPersonController/MainCamera").GetComponent<eyePosition>();
    }

    // Update is called once per frame
    void Update () {

    //bool flag = gazeAware.HasGazeFocus;
       

        //  Debug.Log(flag);
        if (gazeAware.HasGazeFocus)
        {

            if (this.gameObject.tag == "Fruits")
            {
                Debug.Log("Fruits!!!!!");
                audioSource.PlayOneShot(soundPoint[0]);
                eyePosition.AddPoint();
                Destroy(this.gameObject);
            }
            else if (this.gameObject.tag == "Poison")
            {
                Debug.Log("Poison");
                audioSource.PlayOneShot(soundPoint[1]);
                eyePosition.SubPoint();
                Destroy(this.gameObject);

            }
        }
	}

   

}
