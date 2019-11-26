using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chakraPointsScript : MonoBehaviour
{
    public GameObject body;
    public GameObject infoScreen;
    public Collider ChakraCollider;

    // Start is called before the first frame update
    void Start()
    {
       
        }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (ChakraCollider.Raycast(r, out hit, 1000.0f))
            {
                AudioSource audioSource = GetComponent<AudioSource>();
                audioSource.Play();
                infoScreen.SetActive(true);

            }


        }
    }

        public void CloseInfoScreen()
        {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Stop();
        infoScreen.SetActive(false);
        }
    }
