using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorStudyPjw : VectorStudy 
{
    float cubePosition, cubePosition1;
    public float cubeSpeed;
    void Awake()
    {
        cubePosition = 0;
        
    }

     void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            cubePosition -= Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            cubePosition += Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            cubePosition1 += Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            cubePosition1-= Time.deltaTime;
        }

        this.transform.position = new Vector3(cubePosition * cubeSpeed, 0, cubePosition1 * cubeSpeed);

    }


}
