using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;
using UnityEngine.UIElements;

public class asy : MonoBehaviour
{
    //space바를 눌렀을 때 스틱이 일정거리 뒤로 갔다가
    //space바를 안 누르면 스틱이 원래 위치보다 더 앞으로 나가야됨
    float X, Y, Z;
    Vector3[] Point = new Vector3[1];


    private void Start()
    {
        
    }

    void Awake()
    {
        X = this.transform.position.x;
        Z = this.transform.position.z;
        Y = this.transform.position.y;

        Point[0] = this.transform.position;
    }
    private void Update()
    {   
       
        Vector3 move1 = new Vector3(Point[0].x + 1, Point[0].y, Point[0].z);
        Vector3 move2 = new Vector3(Point[0].x - 1, Point[0].y, Point[0].z);

        if (Input.GetKey(KeyCode.Z))
        {
            Debug.Log("Z");
            this.transform.position = Vector3.MoveTowards(transform.position, move1, 0.01f);
        }

        if (Input.GetKey(KeyCode.X))
        {
            Debug.Log("X");
            this.transform.position = Vector3.MoveTowards(transform.position, move2, 0.1f);
        }

        if (Input.GetKey(KeyCode.C))
        {
            Debug.Log("C");
            this.transform.position = Vector3.MoveTowards(transform.position, Point[0], 1f);
        }
    }
}
