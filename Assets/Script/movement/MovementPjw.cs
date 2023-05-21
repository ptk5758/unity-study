using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPjw : MoveMent
{
    //001커밋이슈 : 각 세이브포인트에 좌표 저장 됨, 1234 키 눌렀을때 정확한 위치로 이동하지않고 그 위치에 머무르지 않음
    //해결_ update마다 현 위치가 돌아가니 그대로 있질 못함 >> 각 GetKey if문에 위치할당하도록 함
    //MoveTowards가 아닌 SmoothDamp로 마무리함

    Vector3 velo = Vector3.zero;
    
    void Awake()
    {
        spawnPoint = new Vector3[4];
        
    }
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            positionX -= Time.deltaTime;
            transform.position = new Vector3(positionX * speed, 0, positionZ * speed);
        }

        if (Input.GetKey(KeyCode.D)) 
        {
            positionX += Time.deltaTime;
            transform.position = new Vector3(positionX * speed, 0, positionZ * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            positionZ -= Time.deltaTime;
            transform.position = new Vector3(positionX * speed, 0, positionZ * speed);
        }

        if (Input.GetKey(KeyCode.W)) 
        {
            positionZ += Time.deltaTime;
            transform.position = new Vector3(positionX * speed, 0, positionZ * speed);
        }

        
        //wasd 이동


        if (Input.GetKey(KeyCode.Alpha1)) //키보드 상단 숫자1~4 눌렀을 때
        {

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) //숫자 + shift 눌렀을 때
            {
                //키 누른 시점의 x,z 좌표를 배열에 저장, 세이브포인트 좌표 출력
                spawnPoint[0] = this.transform.position;
                Debug.Log("세이브포인트 01 : "+spawnPoint[0]);

            }

            //Movetowards 사용하여 해당 인덱스에 담긴 spawnPoint로 이동
            transform.position = Vector3.SmoothDamp(transform.position, spawnPoint[0], ref velo, 0.5f);
            
        }

        if (Input.GetKey(KeyCode.Alpha2))
        { 

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
            {
                spawnPoint[1] = this.transform.position;
                Debug.Log("세이브포인트 02 : " + spawnPoint[1]);
            }

            transform.position = Vector3.SmoothDamp(transform.position, spawnPoint[1],ref velo, 0.5f);
            

        }

        if (Input.GetKey(KeyCode.Alpha3)) 
        {

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
            {
                spawnPoint[2] = this.transform.position;
                Debug.Log("세이브포인트 03 : " + spawnPoint[2]);
            }
            transform.position = Vector3.SmoothDamp(transform.position, spawnPoint[2], ref velo,0.5f);
            
        }

        if (Input.GetKey(KeyCode.Alpha4)) 
        {

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
            {
                spawnPoint[3] = this.transform.position;
                Debug.Log("세이브포인트 04 : " + spawnPoint[3]);
            }

            transform.position = Vector3.SmoothDamp(transform.position, spawnPoint[3],ref velo, 0.5f);
            
        }



    }
}
