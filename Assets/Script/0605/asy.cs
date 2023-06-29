using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class asy : pjwCamera
{
    //space바를 눌렀을 때 스틱이 일정거리 뒤로 갔다가
    //space바를 안 누르면 스틱이 원래 위치보다 더 앞으로 나가야됨
    MeshRenderer mesh;
    Material mat;
    float X, Y, Z;
    Vector3[] Point = new Vector3[1];
    float turnSpeed = 5;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "stick")
        {
            mat.color = new Color(0,0,0);
        }
    }

    void MouseRotation()
    {
        // 좌우로 움직인 마우스의 이동량 * 속도에 따라 카메라가 좌우로 회전할 양 계산
        float yRotateSize = Input.GetAxis("Mouse X") * rotateSpeed;
        // 현재 y축 회전값에 더한 새로운 회전각도 계산
        float yRotate = transform.eulerAngles.y + yRotateSize;

        // 위아래로 움직인 마우스의 이동량 * 속도에 따라 카메라가 회전할 양 계산(하늘, 바닥을 바라보는 동작)
        float xRotateSize = -Input.GetAxis("Mouse Y") * rotateSpeed;
        // 위아래 회전량을 더해주지만 -45도 ~ 80도로 제한 (-45:하늘방향, 80:바닥방향)
        // Clamp 는 값의 범위를 제한하는 함수
        xRotate = Mathf.Clamp(xRotate + xRotateSize, -45, 80);
    }

    void Update() 
    {
        transform.rotation= Quaternion.Lerp(transform.rotation, Quaternion.Euler(xRotate,yRotate,0), rotateSpeed);

        Point[0] = this.transform.position;

        Vector3 move1 = new Vector3(Point[0].x + 1, Point[0].y, Point[0].z);
        Vector3 move2 = new Vector3(Point[0].x - 1, Point[0].y, Point[0].z);

        if (Input.GetKey(KeyCode.Z))
        {
            Debug.Log("Z");
            this.transform.position = Vector3.MoveTowards(transform.position, move1, 0.01f);
        }

        if (Input.GetKey(KeyCode.X))
        {
            Debug.Log("X");
            this.transform.position = Vector3.MoveTowards(transform.position, move2, 0.05f);
        }

        if (Input.GetKey(KeyCode.C))
        {
            Debug.Log("C");
            this.transform.position = Vector3.MoveTowards(transform.position, Point[0], 1f);
        }
    }
}
