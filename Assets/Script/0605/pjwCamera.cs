using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pjwCamera : MonoBehaviour
{
    //카메라 이동_마우스 이동에 따라 카메라 각도 조정, wasd 키로 좌우앞뒤 이동
    public float positionX;
    public float positionZ;
    public float positionY;
    public float speed;
    public static float xRotate, yRotate, xRotateMove, yRotateMove;
    public static float rotateSpeed;
    void Awake()
    {
        //positionY를 카메라에 고정
        //이슈_키 누를 때마다 고정위치로 가서 이동함,기본 xyz가 000으로 초기화되니까 이동함
        //Awake에서 기존 위치로 초기화함으로써 일단 땜빵
        positionY = 16;
        positionZ = -31;
        rotateSpeed = 500.0f;

    }

    
    void Update()
    {
        //wasd로 카메라 위치 이동
        if (Input.GetKey(KeyCode.A))
        {
            positionX -= Time.deltaTime*speed;
            transform.position = new Vector3(positionX , positionY, positionZ);
        }

        if (Input.GetKey(KeyCode.D))
        {
            positionX += Time.deltaTime * speed;
            transform.position = new Vector3(positionX, positionY, positionZ);
        }

        if (Input.GetKey(KeyCode.S))
        {
            positionZ -= Time.deltaTime * speed;
            transform.position = new Vector3(positionX , positionY, positionZ );
        }

        if (Input.GetKey(KeyCode.W))
        {
            positionZ += Time.deltaTime * speed;
            transform.position = new Vector3(positionX , positionY, positionZ );
        }

        //마우스 클릭한 상태로 드래그 시 그에 따라 카메라 각도 변화
        if(Input.GetMouseButton(0))
        {
            //GetAxis_-1에서 1 범위로 취득, 마우스가 위로 올라가면 유니티 좌표계에선 x가 바뀜 =>xRotateMove에 MouseY가 들어감
            xRotateMove = -Input.GetAxis("Mouse Y") * Time.deltaTime * rotateSpeed;
            yRotateMove = Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed;

            //오일러 각_0-360도 안에서만 값이 출력(360이상은 정확한 연산 불가)
            //rotation은 쿼터니언을 전제로 회전 : Vector값에 '+' 연산자 사용 불가 
            //쿼터니언 : xyzw로 이뤄짐, 하나의 벡터와 하나의 스칼라 w(roll)을 의미
            //쿼터니언은 세 축을 동시에 회전,벡터값이 동시에 변경됨
            //벡터와 마찬가지로 회전과원점의 특정 방향을 비교함으로써 회전 측정
            //elurAngles : x y z 축을 사용해서 0-360도로 회전시키는 기본좌표계
            //그러나 짐벌 락 문제로 가상의 축(위에서의 w)이 추가된 쿼터니언을 사용
            //짐벌 락 : 각각의 좌표가 겹쳐 자유도가 3개의 축이 아닌 2개의 축으로 한정되는 문제
            //유니티에서 제공하는 쿼터니언 함수 사용

            yRotate = yRotate + yRotateMove;
            xRotate = xRotate + xRotateMove;
            //위에서 연산된 값을 할당

            xRotate = Mathf.Clamp(xRotate, -90, 90); //뒤로 더 넘어가지 않도록 위,아래 고정
            //Mathf : 수학 함수 모음
            //Clamp : 최소, 최대값을 설정하여 float값이 범위 이외의 값 넘지 않도록 함

            Quaternion quat = Quaternion.Euler(new Vector3(xRotate, yRotate, 0));
            //쿼터니언_오일러 각 할당

            transform.rotation = Quaternion.Slerp(transform.rotation, quat, Time.deltaTime);
            //부드럽게 이동, 시작 회전 각부터 일정 시간을 두고 목표 회전 (쿼터니언A, 쿼터니언B,t)
            //A에서 B로 회전속도는 t, 서서히 타겟 방향으로 회전

        }
    }
}
