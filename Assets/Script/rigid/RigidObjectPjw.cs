using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidObjectPjw : RigidObject
{
    Rigidbody rigid;
    void Awake()
    {
        this.rigid = transform.GetComponent<Rigidbody>();
            
    }

    void Start()
    {
        Invoke("DropBall", 3f);
    }

    void DropBall()
    {
        rigid.useGravity = true;
    }
    
    void Update()
    {
        
    }
}
