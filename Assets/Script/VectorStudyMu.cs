using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorStudyMu : VectorStudy
{
    private bool joy = false;
    private void Start()
    {
        this.transform.position = new Vector3 (0, 0, 0);
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Space Bar ´©¸§");
            if (joy == false)
            {
                this.transform.position = new Vector3(0, 0, 0);
                joy = true;
            }
            else if (joy == true)
            {
                this.transform.position = spawnPoint;
                joy = false;
            }
        }       
    }
}
