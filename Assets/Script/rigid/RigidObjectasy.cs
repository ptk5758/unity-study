using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class RigidObjectasy : RigidObject
{
    Rigidbody rigid;
    float time;

    void Awake()
    {
        //time = 0;
        //rigid = this.transform.GetComponent<Rigidbody>();
        rigid = this.transform.GetComponent<Rigidbody>();
    }

    void Update()
    {
        //time += Time.deltaTime;
        //Debug.Log(time); //3�ʰ� ���� �� ���������� Ȯ��

        //deltaTime�� �� ���� ==�� ���ָ� �ȵ� 
        //if (time >= 3.0f)
        //{
        //    rigid.useGravity = true;
        //}

        //if (Input.GetKey(KeyCode.Space))
        //    rigid.AddForce(new Vector3(0, 10, 0));

        float hori = Input.GetAxisRaw("Horizontal");   
        float ver = Input.GetAxisRaw("Vertical");
        Vector3 vector3 = new Vector3(hori, 0, ver);
        rigid.AddForce(vector3);
    }
}
