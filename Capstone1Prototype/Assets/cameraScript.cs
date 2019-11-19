using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public float spinAngle;
    public float upAngle;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Up()
    {
        transform.Translate(0, upAngle, 0);
    }

    public void Down()
    {
        transform.Translate(0, -upAngle, 0);
    }

    public void turnLeft()
    {

        transform.Translate(-upAngle, 0, 0);
    }

    public void turnRight()
    {

        transform.Translate(upAngle, 0, 0);
    }

    public void zoomIn()
    {
        transform.Translate(0, 0, upAngle);
    }

    public void zoomOut()
    {
        transform.Translate(0, 0, -upAngle);
    }

    public void rotateLeft()
    {
        transform.Rotate(0, -spinAngle, 0);
    }

    public void rotateRight()
    {
        transform.Rotate(0, spinAngle, 0);
    }


}
