using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPjw : MoveMent
{
    //001Ŀ���̽� : �� ���̺�����Ʈ�� ��ǥ ���� ��, 1234 Ű �������� ��Ȯ�� ��ġ�� �̵������ʰ� �� ��ġ�� �ӹ����� ����
    //�ذ�_ update���� �� ��ġ�� ���ư��� �״�� ���� ���� >> �� GetKey if���� ��ġ�Ҵ��ϵ��� ��
    //MoveTowards�� �ƴ� SmoothDamp�� ��������

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

        
        //wasd �̵�


        if (Input.GetKey(KeyCode.Alpha1)) //Ű���� ��� ����1~4 ������ ��
        {

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) //���� + shift ������ ��
            {
                //Ű ���� ������ x,z ��ǥ�� �迭�� ����, ���̺�����Ʈ ��ǥ ���
                spawnPoint[0] = this.transform.position;
                Debug.Log("���̺�����Ʈ 01 : "+spawnPoint[0]);

            }

            //Movetowards ����Ͽ� �ش� �ε����� ��� spawnPoint�� �̵�
            transform.position = Vector3.SmoothDamp(transform.position, spawnPoint[0], ref velo, 0.5f);
            
        }

        if (Input.GetKey(KeyCode.Alpha2))
        { 

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
            {
                spawnPoint[1] = this.transform.position;
                Debug.Log("���̺�����Ʈ 02 : " + spawnPoint[1]);
            }

            transform.position = Vector3.SmoothDamp(transform.position, spawnPoint[1],ref velo, 0.5f);
            

        }

        if (Input.GetKey(KeyCode.Alpha3)) 
        {

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
            {
                spawnPoint[2] = this.transform.position;
                Debug.Log("���̺�����Ʈ 03 : " + spawnPoint[2]);
            }
            transform.position = Vector3.SmoothDamp(transform.position, spawnPoint[2], ref velo,0.5f);
            
        }

        if (Input.GetKey(KeyCode.Alpha4)) 
        {

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
            {
                spawnPoint[3] = this.transform.position;
                Debug.Log("���̺�����Ʈ 04 : " + spawnPoint[3]);
            }

            transform.position = Vector3.SmoothDamp(transform.position, spawnPoint[3],ref velo, 0.5f);
            
        }



    }
}
