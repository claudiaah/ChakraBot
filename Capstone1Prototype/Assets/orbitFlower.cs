using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbitFlower : MonoBehaviour
{
    public GameObject body;
    public Collider crownChakraCollider;
    float speed;


    // Start is called before the first frame update
    void Start()
    {
        speed = 20;

    }

    // Update is called once per frame
    void Update()
    {
        OrbitAround();
    }

    void OrbitAround()
    {
        transform.RotateAround(body.transform.position, Vector3.up, speed * Time.deltaTime);

    }
}
