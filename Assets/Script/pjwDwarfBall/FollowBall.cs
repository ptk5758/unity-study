using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public GameObject ball;
    float cameraYposition;

    private void Awake()
    {
        cameraYposition = 64;
    }
    //�� �����Ӹ��� ������ �Ҵ�
    void Update()
    {
        transform.position = ball.transform.position + new Vector3(0, cameraYposition, -25);
    }
}
