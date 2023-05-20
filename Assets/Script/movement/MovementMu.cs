using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class MovementMu : MoveMent
{
    /* MoveMent 에서 선언된것
    public Vector3[] spawnPoint; 이걸 쓰는게 중요한데
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
        // WASD 이동
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

        // 위치저장

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                spawnPoint[0] = this.transform.position;
                Debug.Log("1번에 좌표 " + spawnPoint[0] + "가 저장되었습니다.");
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
                Debug.Log("2번에 좌표 " + spawnPoint[1] + "가 저장되었습니다.");
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
                Debug.Log("3번에 좌표 " + spawnPoint[2] + "가 저장되었습니다.");
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
                Debug.Log("4번에 좌표 " + spawnPoint[3] + "가 저장되었습니다.");
            }
            else
            {
                positionX = spawnPoint[3].x;
                positionZ = spawnPoint[3].z;
                this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
            }
        }


        // 좌표 저장된 값 확인하는거

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("1번 좌표는 " + spawnPoint[0] + "입니다.");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("2번 좌표는 " + spawnPoint[1] + "입니다.");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("3번 좌표는 " + spawnPoint[2] + "입니다.");
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("4번 좌표는 " + spawnPoint[3] + "입니다.");
        }

        /* 저장된 포지션으로 이동해야 하는데 수정해야하는 부분
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

        /* 이걸로 가야댐
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