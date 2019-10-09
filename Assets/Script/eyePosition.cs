using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Tobii.Gaming;
using UnityEngine.SceneManagement;
//このコードをコンポネントした時、指定したコンポネントを強制的につけてくれる。外すことも出来なくする。
[RequireComponent(typeof(GazeAware))]

public class eyePosition : MonoBehaviour
{

    [SerializeField]
    Text text;
    [SerializeField]
    List<GameObject> Fruits = new List<GameObject>();
    [SerializeField]
    GameObject Poison ;
    private int fruitsNumber;

    private float rotationSpeed = 1f;
    private float rotation_x = 0f;
    private float rotation_y = 0f;
    private float speed = 3f;

    [SerializeField]
    float timeOutFruit;
    [SerializeField]
    float timeOutPoison;
    [SerializeField]
    private float timeElapsedFruits;
    [SerializeField]
    private float timeElapsedPoison;
    [SerializeField]
    List<GameObject> sumObj = new List<GameObject>();

    int point = 100;

    Vector3 playerPos;

    Rigidbody rb;

    [SerializeField]
    List<Sprite> character = new List<Sprite>();
    [SerializeField]
    SpriteRenderer characterObject;
    float roteSpeed = 3.0f;

    AudioSource audioSource;
    [SerializeField]
    List<AudioClip> soundEffect = new List<AudioClip>();
   
    //Transform transform;



    // public Transform MainCamera;

    // Use this for initialization
    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        text.text = "Life:" + point.ToString();
        playerPos = transform.position;
        rb = GetComponent<Rigidbody>();
        characterObject = GameObject.FindGameObjectWithTag("Character").GetComponent<SpriteRenderer>();
        //transform = characterObject.transform;

    }

    // Update is called once per frame
    void Update()
    {

        //Vector3 pos = transform.position;
        //pos.y = 0.5f;
        //transform.position = pos;
        characterObject.transform.Rotate(0, roteSpeed, 0);
        timeOutFruit = Random.Range(1.0f, 5.0f);
        timeOutPoison = Random.Range(3.0f, 5.0f);
        fruitsNumber = Random.Range(0, Fruits.Count);
        timeElapsedFruits += Time.deltaTime;
        timeElapsedPoison += Time.deltaTime;
        if (timeElapsedFruits >= timeOutFruit)
        {

            sumObj.Add(Instantiate(Fruits[fruitsNumber], new Vector3(Random.Range(-60.0f, 70.0f), 3.0f, Random.Range(-70.0f, 25.0f)), Quaternion.identity));
            timeElapsedFruits = 0.0f;

        }
        if (timeElapsedPoison >= timeOutPoison)
        {

            sumObj.Add(Instantiate(Poison, new Vector3(Random.Range(-60.0f, 70.0f), 3.0f, Random.Range(-70.0f, 25.0f)), Quaternion.identity));
            timeElapsedPoison= 0.0f;

        }



        Life();
        if (point <= 0)
        {
            characterObject.sprite = character[5];
            SceneManager.LoadScene("GameOver");
        }
    }

    //void GoBack()
    //{
    //    if (Input.GetKey(KeyCode.W))
    //    {
    //        Debug.Log("W");
    //        float up = Time.deltaTime * speed;
    //        transform.position += transform.forward * up;
    //    }
    //    else if (Input.GetKey(KeyCode.S))
    //    {
    //        Debug.Log("S");
    //        float down = Time.deltaTime * speed;
    //        transform.position -= transform.forward * down;
    //    }

    //}

    //void RightLeft()
    //{
    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        Debug.Log("A");
    //        float left = Time.deltaTime * speed;
    //        //  MainCamera.transform.Rotate(0, left, 0);
    //    }
    //    else if (Input.GetKey(KeyCode.D))
    //    {
    //        Debug.Log("D");
    //        float right = Time.deltaTime * speed;
    //        // MainCamera.transform.Rotate(0, right, 0);
    //    }
    //}
    /*
    void HitObj(flag)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


        RaycastHit hit_info = new RaycastHit();
        float max_distance = 100f;

        bool is_hit = Physics.Raycast(ray, out hit_info, max_distance);


        if (flag)
        {
            if (gameObject.tag == "Fruits")
            {
                Debug.Log("Hit");
                Destroy(this.gameObject);
                point += 30;
                text.text = "Point:" + point.ToString();
            }
            else if (gameObject.tag == "Poison")
            {
                Destroy(this.gameObject);
                point -= 50;
                text.text = "Point:" + point.ToString();
            }
        }
    }*/

      public  void AddPoint()
    {
        point += 30;
        text.text = "Life:" + point.ToString();
    }
      public void SubPoint()
    {
        point -= 35;
        text.text = "Life:" + point.ToString();
    }

    public void SubPointTimer()
    {
        point -= 6;
        text.text = "Life:" + point.ToString();
    }

    void Life()
    {
        if (point >= 200)
        {
            characterObject.sprite = character[4];
            audioSource.PlayOneShot(soundEffect[0]);
        }
        else if (point >= 120)
        {
            characterObject.sprite = character[3];
        }
        else if (point >= 80)
        {
            characterObject.sprite = character[2];
        }
        else if (point >= 50)
        {
            characterObject.sprite = character[1];
        }
        else if (point <= 20)
        {
            characterObject.sprite = character[0];
            audioSource.PlayOneShot(soundEffect[1]);
        }
        else if (point >= 250)
        {
            characterObject.sprite = character[6];
            SceneManager.LoadScene("FatOverScene");
        }
    }
     

   
}
