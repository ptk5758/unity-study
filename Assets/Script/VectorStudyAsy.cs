using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class VectorStudyAsy : VectorStudy
{
    //public float x;
    //public float y;
    //public Vector3 target;
    public float speed;

    public Vector3 target1;
    public Vector3 target2;
    public Vector3 target3;
    public Vector3 target4;
    public Vector3 target5;

    void Start()
    {
        
    }

    private void Awake()
    {
        
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.Alpha1))
        {
            transform.position = Vector3.MoveTowards(transform.position, target1, speed);
        }

        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.Alpha2))
        {
            this.transform.position = Vector3.MoveTowards(transform.position, target2, speed);
        }

        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.Alpha3))
        {
            this.transform.position = Vector3.MoveTowards(transform.position, target3, speed);
        }

        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.Alpha4))
        {
            this.transform.position = Vector3.MoveTowards(transform.position, target4, speed);
        }

        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.Alpha5))
        {
            this.transform.position = Vector3.MoveTowards(transform.position, target5, speed);
        }

    }
}
