using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Movementasy : MoveMent
{
    //public Vector3[] spawnPoint; -> �����̰� ���� ���� ��ġ�� ������ �迭(�迭�� ������ ��  Vector �������� ����)
    //public Vector3 targetPoint;
    //public float positionX;
    //public float positionZ;
    //public float speed;

    void Awake()
    {
        spawnPoint = new Vector3[4]; //���̺�����
        positionX = 0;  //x ��ǥ �̵�
        positionZ = 0;  //z ��ǥ �̵�
        speed = 0.1f; //float�����̴ϱ� f �ٿ������

    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            positionZ += Time.deltaTime;
            this.transform.position = new Vector3 (positionX, this.transform.position.y, positionZ);
        }

        if (Input.GetKey(KeyCode.S))
        {
            positionZ -= Time.deltaTime;
            this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            positionX -= Time.deltaTime;
            this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
        }

        if (Input.GetKey(KeyCode.D))
        {
            positionX += Time.deltaTime;
            this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
        }


        //Shift + ��ȣ ������ �ش� ��ġ�� spawnPoint �迭�� ���� | ��ȣ�� ������ spawnPoint�� ����� ��ġ�� �̵�

        if (Input.GetKey(KeyCode.Alpha1))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                spawnPoint[0] = this.transform.position;
            }
            this.transform.position = Vector3.MoveTowards(this.transform.position, spawnPoint[0], speed);
            positionX = spawnPoint[0].x;
            positionZ = spawnPoint[0].z;
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                spawnPoint[1] = this.transform.position;
            }
            this.transform.position = Vector3.MoveTowards(this.transform.position, spawnPoint[1], speed);
            positionX = spawnPoint[1].x;
            positionZ = spawnPoint[1].z;
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                spawnPoint[2] = this.transform.position;
            }
            this.transform.position = Vector3.MoveTowards(this.transform.position, spawnPoint[2], speed);
            positionX = spawnPoint[2].x;
            positionZ = spawnPoint[2].z;
        }


        if (Input.GetKey(KeyCode.Alpha4))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                spawnPoint[3] = this.transform.position;
            }
            this.transform.position = Vector3.MoveTowards(this.transform.position, spawnPoint[3], speed);
            positionX = spawnPoint[3].x;
            positionZ = spawnPoint[3].z;
        }



    }
}
