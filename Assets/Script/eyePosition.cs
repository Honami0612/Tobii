using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eyePosition : MonoBehaviour {

    [SerializeField]
    Text text;
    [SerializeField]
    List<GameObject> Fruits = new List<GameObject>();
    private int fruitsNumber;

    private float rotationSpeed = 1f;
    private float rotation_x = 0f;
    private float rotation_y = 0f;
    private float speed = 3f;

    [SerializeField]
    float timeOut;
    private float timeElapsed;
    [SerializeField]
    List<GameObject> sumObj = new List<GameObject>();

    int point = 100;

    Vector3 playerPos;

    Rigidbody rb;

    private float z;
    private float x;
    public Transform MainCamera;

	// Use this for initialization
	void Start () {
        text.text = "Point" + point.ToString();
        playerPos = transform.position;
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        timeOut = Random.Range(1.0f, 5.0f);
        fruitsNumber = Random.Range(0, Fruits.Count);
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= timeOut)
        {
            sumObj.Add(Instantiate(Fruits[fruitsNumber], new Vector3(Random.Range(-30.0f, 50.0f), 3.0f, Random.Range(-19.0f, 20.0f)),Quaternion.identity));
            timeElapsed = 0.0f;
        }
        GoBack();
        RightLeft();
        HitObj();
        if (point <= 0)
        {
            //GameOver
        }
	}

    void GoBack()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W");
            float up = Time.deltaTime * speed;
            transform.position += transform.forward * up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S");
            float down = Time.deltaTime * speed;
            transform.position -= transform.forward * down;
        }

    }

    void RightLeft()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
            float left = Time.deltaTime * speed;
            MainCamera.transform.Rotate(0, left, 0);
        }else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
            float right = Time.deltaTime * speed;
            MainCamera.transform.Rotate(0, right, 0);
        }
    }

    void HitObj()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit_info = new RaycastHit();
        float max_distance = 100f;

        bool is_hit = Physics.Raycast(ray, out hit_info, max_distance);
        if (is_hit)
        {
            if (hit_info.transform.tag == "Fruits")
            {
                Debug.Log("Hit");
                Destroy(hit_info.collider.gameObject);
                point += 30;
                text.text = "Point:" + point.ToString();
            }else if (hit_info.collider.tag == "Poison")
            {
                Destroy(hit_info.collider.gameObject);
                point -= 50;
                text.text = "Point:" + point.ToString();
            }
        }
    }

}
