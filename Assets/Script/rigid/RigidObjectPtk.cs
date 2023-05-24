using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidObjectPtk : RigidObject
{
    Rigidbody rigid;
    public float count;

    private void Awake()
    {
        rigid = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        count -= Time.deltaTime;
        if (count <= 0) rigid.useGravity = true;
    }
}
