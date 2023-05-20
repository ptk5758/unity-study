using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPjw : MoveMent
{
    void Awake()
    {
        spawnPoint = new Vector3[4];
        
    }
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            positionX -= Time.deltaTime;
            
        }

        if (Input.GetKey(KeyCode.D)) 
        {
            positionX += Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.S))
        {
            positionZ -= Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.W)) 
        {
            positionZ += Time.deltaTime;

        }

        transform.position = new Vector3(positionX * speed, 0, positionZ * speed);
        //wasd 이동

        if (Input.GetKey(KeyCode.Alpha1)) //키보드 상단 숫자1~4 눌렀을 때
        {

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) //숫자 + shift 눌렀을 때
            {
                //키 누른 시점의 x,z 좌표를 배열에 저장, 세이브포인트 좌표 출력
                spawnPoint[0] = new Vector3(positionX, 0, positionZ);
                Debug.Log("세이브포인트 01 : "+spawnPoint[0]);

            }

            //Movetowards 사용하여 해당 인덱스에 담긴 spawnPoint로 이동
            transform.position = Vector3.MoveTowards(transform.position, spawnPoint[0], speed);
            
        }

        if (Input.GetKey(KeyCode.Alpha2))
        { 

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
            {
                spawnPoint[1] = new Vector3(positionX, 0, positionZ);
                Debug.Log("세이브포인트 02 : " + spawnPoint[1]);
            }

            transform.position = Vector3.MoveTowards(transform.position, spawnPoint[1], speed);
            

        }

        if (Input.GetKey(KeyCode.Alpha3)) 
        {

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
            {
                spawnPoint[2] = new Vector3(positionX, 0, positionZ);
                Debug.Log("세이브포인트 03 : " + spawnPoint[2]);
            }
            transform.position = Vector3.MoveTowards(transform.position, spawnPoint[2], speed);
            
        }

        if (Input.GetKey(KeyCode.Alpha4)) 
        {

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
            {
                spawnPoint[3] = new Vector3(positionX, 0, positionZ);
                Debug.Log("세이브포인트 04 : " + spawnPoint[3]);
            }

            transform.position = Vector3.MoveTowards(transform.position, spawnPoint[3], speed);
            
        }



    }
}
