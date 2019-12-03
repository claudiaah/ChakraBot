using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbitFlower : MonoBehaviour
{
    public GameObject body;
    public GameObject questionScreen;
    public GameObject A1;
    public GameObject A2;
    public Collider flowerCollider;
    float speed;


    // Start is called before the first frame update
    void Start()
    {
        speed = 10;

    }

    // Update is called once per frame
    void Update()
    {
        OrbitAround();

        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (flowerCollider.Raycast(r, out hit, 1000.0f))
            {
                questionScreen.SetActive(true);
                AudioSource audioSource = GetComponent<AudioSource>();
                audioSource.Play();
               
            }


        }
    }

    void OrbitAround()
    {
        transform.RotateAround(body.transform.position, Vector3.up, speed * Time.deltaTime);

    }

    public void CloseInfoScreen()
    {
        questionScreen.SetActive(false);
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Stop();

    }

    public void OpenA1()
    {
        questionScreen.SetActive(false);
        A1.SetActive(true);
    }

    public void CloseA1()
    {
        A1.SetActive(false);
        questionScreen.SetActive(true);
    }

    public void OpenA2()
    {
        questionScreen.SetActive(false);
        A2.SetActive(true);

    }

    public void CloseA2()
    {
        A2.SetActive(false);
        questionScreen.SetActive(true);
   
    }






}
