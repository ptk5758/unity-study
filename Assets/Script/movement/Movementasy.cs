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
            Vector3 temp = Vector3.MoveTowards(this.transform.position, spawnPoint[0], speed);
            //temp라는 새로운 변수를 만들어서 거기다가 spawnPoint[0]으로 가는 도중의 위치를 저장해둠(spawnPoint[0]에 완전히 도착하면 그곳의 위치를 중간에 가다가 멈추면
            //멈춘 위치의 좌표를 저장해둬서 중간에 가다가 멈춰서 WASD를 눌러도 spawnPoint[0]에 저장해둔 위치로 가지 않고 멈춘 위치에서 움직여짐
            positionX = temp.x; //temp.x의 값을 positionX에 저장
            positionZ = temp.z; ////temp.Z의 값을 positionZ에 저장
            this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
            //현재 위치를 this.transform.position에다가 저장
            //this.transform.position = Vector3.MoveTowards(this.transform.position, spawnPoint[0], speed);
            //positionX = spawnPoint[0].x;
            //positionZ = spawnPoint[0].z;
            //이렇게 코드를 작성하면 spawnPoint[0]으로 이동하는 중에 중간에 멈춰서 WASD를 누르면 그 자리에서 움직이는 게 아니라 spawnPoint[0]까지 옮겨가서
            //움직여지는 오류가 발생, positionX=spawnPoint[0].x로 코드를 작성하면 중간에 가다가 멈춘 자리의 X 좌표가 아니라 
            //spawnPoint[0]에 저장되있는 X 좌표가 저장되기 때문에 spawnPoint[0]의 X 좌표로 옮겨가버림
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                spawnPoint[1] = this.transform.position;
            }
            Vector3 temp = Vector3.MoveTowards(this.transform.position, spawnPoint[1], speed);
            positionX = temp.x;
            positionZ = temp.z;
            this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                spawnPoint[2] = this.transform.position;
            }
            Vector3 temp = Vector3.MoveTowards(this.transform.position, spawnPoint[2], speed);
            positionX = temp.x;
            positionZ = temp.z;
            this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
        }


        if (Input.GetKey(KeyCode.Alpha4))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                spawnPoint[3] = this.transform.position;
            }
            Vector3 temp = Vector3.MoveTowards(this.transform.position, spawnPoint[3], speed);
            positionX = temp.x;
            positionZ = temp.z;
            this.transform.position = new Vector3(positionX, this.transform.position.y, positionZ);
        }



    }
}
