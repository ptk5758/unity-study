using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorStudyAsy : VectorStudy
{
    // Start is called before the first frame update
    void Start()
    {
        //this.transform.position = spawnPoint;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            this.transform.position = spawnPoint;
        }
        if (Input.GetKeyUp(KeyCode.G))
        {
            this.transform.position = new Vector3(0,0,0);
        }
    }
}
