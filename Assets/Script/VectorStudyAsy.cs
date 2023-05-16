using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorStudyAsy : VectorStudy
{
    public float xyz;
    // Start is called before the first frame update
    void Start()
    {
        //this.transform.position = spawnPoint;
    }

    private void Awake()
    {
        xyz = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.G))
        //{
        //    this.transform.position = spawnPoint;
        //}
        //if (Input.GetKeyUp(KeyCode.G))
        //{
        //    this.transform.position = new Vector3(0,0,0);
        //}

        if(Input.GetKeyDown(KeyCode.A)) 
        {
            xyz += Time.deltaTime;
            this.transform.position = new Vector3(xyz, this.transform.position.y, this.transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            xyz += Time.deltaTime;
            this.transform.position = new Vector3(this.transform.position.x, xyz, this.transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            xyz += Time.deltaTime;
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, xyz);
        }
    }
}
