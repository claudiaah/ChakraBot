using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redFlower : MonoBehaviour
{
    public GameObject body;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

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
