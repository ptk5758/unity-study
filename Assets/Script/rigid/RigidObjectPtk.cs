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
        // Input.GetAxis // Input Manager �� ��ϵǾ��ִ� Axis�� ���� ������

        // float temp = Input.GetAxis("Horizontal");
        float horizon = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");
        Vector3 temp = new Vector3(horizon, 0, verti);
        rigid.AddForce(temp);
        
        
    }
}
