using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidObjectPjw : RigidObject
{
    Rigidbody rigid;
    float horizon, vertical;
    
    void Awake()
    {
        this.rigid = transform.GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) rigid.AddForce(new Vector3(0, 8, 0));

        horizon = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector3 wasd = new Vector3(horizon, 0, vertical);
        rigid.AddForce(wasd);
        
    }
  
}
