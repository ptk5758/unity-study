using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorStudyPtk : VectorStudy
{
    public Vector3 targetPoint;
    public float speed;
    public List<Vector3> points;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1)) this.targetPoint = points[0];
        if (Input.GetKeyDown(KeyCode.Alpha2)) this.targetPoint = points[1];
        if (Input.GetKeyDown(KeyCode.Alpha3)) this.targetPoint = points[2];
        if (Input.GetKeyDown(KeyCode.Alpha4)) this.targetPoint = points[3];
        if (Input.GetKeyDown(KeyCode.Alpha5)) this.targetPoint = points[4];

        // Vector3.MoveTowards(현재백터, 목표백터, 스피드)
        if (Input.GetKey(KeyCode.Space)) {
            this.transform.position = Vector3.MoveTowards(this.transform.position, targetPoint, speed);
        }
        
    }
}
