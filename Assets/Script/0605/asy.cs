using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class asy : pjwCamera
{
    //space�ٸ� ������ �� ��ƽ�� �����Ÿ� �ڷ� ���ٰ�
    //space�ٸ� �� ������ ��ƽ�� ���� ��ġ���� �� ������ �����ߵ�
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
        // �¿�� ������ ���콺�� �̵��� * �ӵ��� ���� ī�޶� �¿�� ȸ���� �� ���
        float yRotateSize = Input.GetAxis("Mouse X") * rotateSpeed;
        // ���� y�� ȸ������ ���� ���ο� ȸ������ ���
        float yRotate = transform.eulerAngles.y + yRotateSize;

        // ���Ʒ��� ������ ���콺�� �̵��� * �ӵ��� ���� ī�޶� ȸ���� �� ���(�ϴ�, �ٴ��� �ٶ󺸴� ����)
        float xRotateSize = -Input.GetAxis("Mouse Y") * rotateSpeed;
        // ���Ʒ� ȸ������ ���������� -45�� ~ 80���� ���� (-45:�ϴù���, 80:�ٴڹ���)
        // Clamp �� ���� ������ �����ϴ� �Լ�
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
