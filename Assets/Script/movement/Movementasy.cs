using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Movementasy : MoveMent
{
    //public Vector3[] spawnPoint; -> 움직이고 나서 현재 위치를 저장할 배열(배열을 선언할 때  Vector 형식으로 선언)
    //public Vector3 targetPoint;
    //public float positionX;
    //public float positionZ;
    //public float speed;

    void Awake()
    {
        spawnPoint = new Vector3[4]; //세이브지점
        positionX = 0;  //x 좌표 이동
        positionZ = 0;  //z 좌표 이동
        speed = 0.1f; //float형식이니까 f 붙여줘야함

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


        //Shift + 번호 누르면 해당 위치를 spawnPoint 배열에 저장 | 번호만 누르면 spawnPoint에 저장된 위치로 이동

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
