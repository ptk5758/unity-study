using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidObjectPjw : RigidObject
{
    Rigidbody rigid;
    float ballDrops;
    
    void Awake()
    {
        this.rigid = transform.GetComponent<Rigidbody>();
        ballDrops = 3;
    }

    void Start()
    {
        //ballDrops = 3;
        //3 2 1 ��(ballDrops�� 0�� �Ǹ�) DropBall ȣ���ϵ���
        //ballDrops -= Time.deltaTime; ����ġ�ٺ��� : ��ŸƮ�� �־���� �־ȶ������� �ϰ��־���
        //�̽�_ballDrop�� ��� �������µ� 0�� �Ǵ� �������� ��� ȣ���� �ȵ�
        //Invoke("DropBall", 3f);

    }
    void Update()
    {
        if(ballDrops >=0)
        {
            ballDrops -= Time.deltaTime;
            Debug.Log((int)ballDrops);
        }
        if ((int)ballDrops == 0) //�� ��ü�� ������ �ȵǰ�����_int�� �ٲٰ� �ذ� ^^
        {
            DropBall();
            Debug.Log("���");
        }

    }
    void DropBall()
    {
        rigid.useGravity = true;
    }

}
