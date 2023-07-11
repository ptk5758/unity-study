using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Transform playerTransform; //공의 현재 위치를 받아올 변수
    Vector3 Offset; //카메라가 공에 딱 붙어있는 게 아니라 공에서 좀 떨어져서 하게 할려고 위치를 지정

    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform; //Player라는 이름의 객체에 대한 위치 정보를 받아옴
        Offset = transform.position - playerTransform.position;
        //카메라와 공 사이의 거리를 빼서 그 거리만큼 카메라가 떨어져있게? 위치를 지정
        //공의 위치가 바뀌어도 저 거리만큼을 유지하면서 카메라가 계속 따라다님
    }

    // Update is called once per frame
    void LateUpdate() //Update에 작성된 코드가 다 끝나면
    {
        transform.position = playerTransform.position + Offset;
        //카메라의 현재 위치를 Offset(원래 설정해둔 공과 카메라 사이의 거리)만큼 지정해줌
    }
}
