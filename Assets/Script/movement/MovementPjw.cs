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
        //wasd �̵�

        if (Input.GetKey(KeyCode.Alpha1)) //Ű���� ��� ����1~4 ������ ��
        {

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) //���� + shift ������ ��
            {
                //Ű ���� ������ x,z ��ǥ�� �迭�� ����, ���̺�����Ʈ ��ǥ ���
                spawnPoint[0] = new Vector3(positionX, 0, positionZ);
                Debug.Log("���̺�����Ʈ 01 : "+spawnPoint[0]);

            }

            //Movetowards ����Ͽ� �ش� �ε����� ��� spawnPoint�� �̵�
            transform.position = Vector3.MoveTowards(transform.position, spawnPoint[0], speed);
            
        }

        if (Input.GetKey(KeyCode.Alpha2))
        { 

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
            {
                spawnPoint[1] = new Vector3(positionX, 0, positionZ);
                Debug.Log("���̺�����Ʈ 02 : " + spawnPoint[1]);
            }

            transform.position = Vector3.MoveTowards(transform.position, spawnPoint[1], speed);
            

        }

        if (Input.GetKey(KeyCode.Alpha3)) 
        {

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
            {
                spawnPoint[2] = new Vector3(positionX, 0, positionZ);
                Debug.Log("���̺�����Ʈ 03 : " + spawnPoint[2]);
            }
            transform.position = Vector3.MoveTowards(transform.position, spawnPoint[2], speed);
            
        }

        if (Input.GetKey(KeyCode.Alpha4)) 
        {

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
            {
                spawnPoint[3] = new Vector3(positionX, 0, positionZ);
                Debug.Log("���̺�����Ʈ 04 : " + spawnPoint[3]);
            }

            transform.position = Vector3.MoveTowards(transform.position, spawnPoint[3], speed);
            
        }



    }
}
