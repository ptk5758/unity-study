using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorStudyMu : VectorStudy
{
    public float playTime;
    public float front;
    public float side;
    public float jump;
    private void Start()
    {
        playTime = 0;
        front = 0;
        side = 0;
    }
    private void Update()
    {
        playTime += Time.deltaTime;
        Debug.Log(Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
        {
            front += Time.deltaTime;
            this.transform.position = new Vector3(front, this.transform.position.y, 0);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            side += Time.deltaTime;
            this.transform.position = new Vector3(this.transform.position.x, 0, side);
        }
        if (Input.GetKey(KeyCode.S))
        {
            front -= Time.deltaTime;
            this.transform.position = new Vector3(front, this.transform.position.y, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            side -= Time.deltaTime;
            this.transform.position = new Vector3(this.transform.position.x, 0, side);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            this.transform.position = new Vector3(this.transform.position.x, 1, this.transform.position.z);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            this.transform.position = new Vector3(front, 0, side);
        }
        this.transform.position = new Vector3(front, this.transform.position.y, side);
    }
}
