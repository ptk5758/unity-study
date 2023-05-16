using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorStudyPjw : VectorStudy 
{
    
    void Start()
    {
       //ector3 vec = new Vector3(0,0,0);
        

        //Vector3 vec = spawnPoint;
        //transform.Translate(vec);


    }
    void Update()
    {

        if (Input.GetButton("Horizontal"))
        {
            Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            
            transform.Translate(vec);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 vec = spawnPoint;
            transform.Translate(vec);
        }

    }


}
