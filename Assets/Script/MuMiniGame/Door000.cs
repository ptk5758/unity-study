using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen000 : MuMiniGame
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Presss1();
            if (s1)
            {
                Vector3 newPosition = transform.position;
                newPosition.y = -5f;
                transform.position = newPosition;

                Debug.Log("문이 열렸습니다!");
            }
            else
            {
                Vector3 newPosition = transform.position;
                newPosition.y = 0f;
                transform.position = newPosition;
            }
        }
        if (s1 == false && s2 == false && s3 == false)
        {

        }

    }
}
