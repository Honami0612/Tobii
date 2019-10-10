using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationCharacter : MonoBehaviour {

    float roteSpeed = 1.5f;
    [SerializeField]
    Image characterObject;

    // Use this for initialization
    void Start () {
        characterObject = GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update () {
        characterObject.transform.Rotate(0,0, roteSpeed);
    }
}
