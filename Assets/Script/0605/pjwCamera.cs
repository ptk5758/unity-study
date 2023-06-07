using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pjwCamera : MonoBehaviour
{
    //ī�޶� �̵�_���콺 �̵��� ���� ī�޶� ���� ����, wasd Ű�� �¿�յ� �̵�
    public float positionX;
    public float positionZ;
    public float positionY;
    public float speed;
    public static float xRotate, yRotate, xRotateMove, yRotateMove;
    public static float rotateSpeed;
    void Awake()
    {
        //positionY�� ī�޶� ����
        //�̽�_Ű ���� ������ ������ġ�� ���� �̵���,�⺻ xyz�� 000���� �ʱ�ȭ�Ǵϱ� �̵���
        //Awake���� ���� ��ġ�� �ʱ�ȭ�����ν� �ϴ� ����
        positionY = 16;
        positionZ = -31;
        rotateSpeed = 500.0f;

    }

    
    void Update()
    {
        //wasd�� ī�޶� ��ġ �̵�
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

        //���콺 Ŭ���� ���·� �巡�� �� �׿� ���� ī�޶� ���� ��ȭ
        if(Input.GetMouseButton(0))
        {
            //GetAxis_-1���� 1 ������ ���, ���콺�� ���� �ö󰡸� ����Ƽ ��ǥ�迡�� x�� �ٲ� =>xRotateMove�� MouseY�� ��
            xRotateMove = -Input.GetAxis("Mouse Y") * Time.deltaTime * rotateSpeed;
            yRotateMove = Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed;

            //���Ϸ� ��_0-360�� �ȿ����� ���� ���(360�̻��� ��Ȯ�� ���� �Ұ�)
            //rotation�� ���ʹϾ��� ������ ȸ�� : Vector���� '+' ������ ��� �Ұ� 
            //���ʹϾ� : xyzw�� �̷���, �ϳ��� ���Ϳ� �ϳ��� ��Į�� w(roll)�� �ǹ�
            //���ʹϾ��� �� ���� ���ÿ� ȸ��,���Ͱ��� ���ÿ� �����
            //���Ϳ� ���������� ȸ���������� Ư�� ������ �������ν� ȸ�� ����
            //elurAngles : x y z ���� ����ؼ� 0-360���� ȸ����Ű�� �⺻��ǥ��
            //�׷��� ���� �� ������ ������ ��(�������� w)�� �߰��� ���ʹϾ��� ���
            //���� �� : ������ ��ǥ�� ���� �������� 3���� ���� �ƴ� 2���� ������ �����Ǵ� ����
            //����Ƽ���� �����ϴ� ���ʹϾ� �Լ� ���

            yRotate = yRotate + yRotateMove;
            xRotate = xRotate + xRotateMove;
            //������ ����� ���� �Ҵ�

            xRotate = Mathf.Clamp(xRotate, -90, 90); //�ڷ� �� �Ѿ�� �ʵ��� ��,�Ʒ� ����
            //Mathf : ���� �Լ� ����
            //Clamp : �ּ�, �ִ밪�� �����Ͽ� float���� ���� �̿��� �� ���� �ʵ��� ��

            Quaternion quat = Quaternion.Euler(new Vector3(xRotate, yRotate, 0));
            //���ʹϾ�_���Ϸ� �� �Ҵ�

            transform.rotation = Quaternion.Slerp(transform.rotation, quat, Time.deltaTime);
            //�ε巴�� �̵�, ���� ȸ�� ������ ���� �ð��� �ΰ� ��ǥ ȸ�� (���ʹϾ�A, ���ʹϾ�B,t)
            //A���� B�� ȸ���ӵ��� t, ������ Ÿ�� �������� ȸ��

        }
    }
}
