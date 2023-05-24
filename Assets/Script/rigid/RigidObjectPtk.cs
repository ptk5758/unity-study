using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidObjectPtk : RigidObject
{
    Rigidbody rigid;
    void Start()
    {        
        
    }

    private void Awake()
    {
        this.rigid = this.transform.GetComponent<Rigidbody>();
        Debug.Log(rigid.useGravity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) rigid.useGravity = true;
    }
}
