using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbitFlower : MonoBehaviour
{
    public GameObject body;
    public GameObject questionScreen;
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
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Stop();
        questionScreen.SetActive(false);
    }
}
