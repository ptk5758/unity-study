using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorStudyAsy : VectorStudy
{
    public float x;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        //this.transform.position = spawnPoint;
    }

    private void Awake()
    {
        x = 0;
        y = 0;
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
        this.transform.position = new Vector3(x,y,0);

        if (Input.GetKey(KeyCode.A))
        {
            x -= Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            x += Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            y -= Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            y += Time.deltaTime;
        }

        
    }
}
