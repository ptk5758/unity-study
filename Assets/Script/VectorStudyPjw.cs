using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorStudyPjw : VectorStudy 
{
    float cubePosition,cubePosition1;
    public float cubeSpeed;
    public Vector3 target, target1, target2, target3;
    // 인스펙터 창에서 각각 타겟벡터값 설정

     void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            
            if(Input.GetKey(KeyCode.Q))
            {
                this.transform.position = Vector3.MoveTowards(this.transform.position, target, cubeSpeed);
            }
            if (Input.GetKey(KeyCode.W))
            {
                this.transform.position = Vector3.MoveTowards(this.transform.position, target1, cubeSpeed);
            }
            if (Input.GetKey(KeyCode.E))
            {
                this.transform.position = Vector3.MoveTowards(this.transform.position, target2, cubeSpeed);
            }
            if (Input.GetKey(KeyCode.R))
            {
                this.transform.position = Vector3.MoveTowards(this.transform.position, target3, cubeSpeed);
            }

           
        }

        

    }


}
