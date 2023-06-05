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
        //3 2 1 후(ballDrops가 0이 되면) DropBall 호출하도록
        //ballDrops -= Time.deltaTime; 오늘치바보짓 : 스타트에 넣어놓고 왜안떨어지지 하고있었음
        //이슈_ballDrop은 계속 떨어지는데 0이 되는 시점에서 드랍 호출이 안됨
        //Invoke("DropBall", 3f);

    }
    void Update()
    {
        if(ballDrops >=0)
        {
            ballDrops -= Time.deltaTime;
            Debug.Log((int)ballDrops);
        }
        if ((int)ballDrops == 0) //이 자체가 실행이 안되고있음_int로 바꾸고 해결 ^^
        {
            DropBall();
            Debug.Log("드랍");
        }

    }
    void DropBall()
    {
        rigid.useGravity = true;
    }

}
