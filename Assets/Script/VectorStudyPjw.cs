using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorStudyPjw : VectorStudy 
{
    
    void Start()
    {
        Vector3 vec = new Vector3(2, 3, 3);
        transform.Translate(vec);
    }

   
}
