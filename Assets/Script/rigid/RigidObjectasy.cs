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
        time = 0;
        rigid = this.transform.GetComponent<Rigidbody>();
    }

    void Update()
    {
        time += Time.deltaTime;
        Debug.Log(time); //3�ʰ� ���� �� ���������� Ȯ��

        //deltaTime�� �� ���� ==�� ���ָ� �ȵ� 
        if (time >= 3.0f)
        {
            rigid.useGravity = true;
        }
    }
}
