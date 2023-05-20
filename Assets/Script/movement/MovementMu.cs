using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class MovementMu : MoveMent
{
    /* MoveMent ���� ����Ȱ�
    public Vector3[] spawnPoint; �̰� ���°� �߿��ѵ�
    public float positionX; 
    public float positionZ;
    public float speed;
    */ 

    private void Start()
    {
        spawnPoint = new Vector3[4];
        positionX = 0;
        positionZ = 0;
        speed = 5.0f;
    }

    void Update()
    {
        // WASD �̵�
        if (Input.GetKey(KeyCode.W))
        {
            positionX += Time.deltaTime;  
            this.transform.position = new Vector3(positionX, this.transform.position.y, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            positionX -= Time.deltaTime;
            this.transform.position = new Vector3(positionX, this.transform.position.y, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            positionZ += Time.deltaTime;
            this.transform.position = new Vector3(this.transform.position.x, 0, positionZ);
        }
        if (Input.GetKey(KeyCode.D))
        {
            positionZ -= Time.deltaTime;
            this.transform.position = new Vector3(this.transform.position.x, 0, positionZ);
        }
        this.transform.position = new Vector3(positionX * speed, this.transform.position.y, positionZ * speed);

        // ��ġ����

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                spawnPoint[0] = this.transform.position;
                Debug.Log("1���� ��ǥ " + spawnPoint[0] + "�� ����Ǿ����ϴ�.");
            }
            else
            {
                positionX = spawnPoint[0].x;
                positionZ = spawnPoint[0].z;
                this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                spawnPoint[1] = this.transform.position;
                Debug.Log("2���� ��ǥ " + spawnPoint[1] + "�� ����Ǿ����ϴ�.");
            }
            else
            {
                positionX = spawnPoint[1].x;
                positionZ = spawnPoint[1].z;
                this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                spawnPoint[2] = this.transform.position;
                Debug.Log("3���� ��ǥ " + spawnPoint[2] + "�� ����Ǿ����ϴ�.");
            }
            else
            {
                positionX = spawnPoint[2].x;
                positionZ = spawnPoint[2].z;
                this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                spawnPoint[3] = this.transform.position;
                Debug.Log("4���� ��ǥ " + spawnPoint[3] + "�� ����Ǿ����ϴ�.");
            }
            else
            {
                positionX = spawnPoint[3].x;
                positionZ = spawnPoint[3].z;
                this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
            }
        }


        // ��ǥ ����� �� Ȯ���ϴ°�

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("1�� ��ǥ�� " + spawnPoint[0] + "�Դϴ�.");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("2�� ��ǥ�� " + spawnPoint[1] + "�Դϴ�.");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("3�� ��ǥ�� " + spawnPoint[2] + "�Դϴ�.");
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("4�� ��ǥ�� " + spawnPoint[3] + "�Դϴ�.");
        }

        /* ����� ���������� �̵��ؾ� �ϴµ� �����ؾ��ϴ� �κ�
        if (Input.GetKey(KeyCode.Alpha1))
        {
            this.transform.position = spawnPoint[0];
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            this.transform.position = spawnPoint[1];
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            this.transform.position = spawnPoint[2];
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            this.transform.position = spawnPoint[3];
        }
        */

        /* �̰ɷ� ���ߴ�
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            positionX = spawnPoint[0].x;
            positionZ = spawnPoint[0].z;
            this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            positionX = spawnPoint[1].x;
            positionZ = spawnPoint[1].z;
            this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            positionX = spawnPoint[2].x;
            positionZ = spawnPoint[2].z;
            this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            positionX = spawnPoint[3].x;
            positionZ = spawnPoint[3].z;
            this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
        }
        */
    }
}