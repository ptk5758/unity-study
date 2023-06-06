using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muEv : MonoBehaviour
{
    float initX, initY, initZ;
    float speed = 10f;
    bool move = false;

    void Awake()
    {
        initX = transform.position.x;
        initY = transform.position.y;
        initZ = transform.position.z;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && !move)
        {
            speed = 8f;
            StartCoroutine(BallInitailize());
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && !move)
        {
            speed = 10f;
            StartCoroutine(ReturnToBase());
        }
    }

    IEnumerator BallInitailize()
    {
        move = true;

        Vector3 target1 = new Vector3(initX, initY, initZ - 2f);

        while (transform.position != target1)
        {
            transform.position = Vector3.MoveTowards(transform.position, target1, speed * Time.deltaTime);
            yield return null;
        }

        Vector3 target2 = new Vector3(initX, initY + 10f, initZ - 2f);

        while (transform.position != target2)
        {
            transform.position = Vector3.MoveTowards(transform.position, target2, speed * Time.deltaTime);
            yield return null;
        }

        Vector3 target3 = new Vector3(0, initY + 10f, 14);

        while (transform.position != target3)
        {
            transform.position = Vector3.MoveTowards(transform.position, target3, speed * Time.deltaTime);
            yield return null;
        }

        move = false;
    }

    IEnumerator ReturnToBase()
    {
        move = true;

        Vector3 target2 = new Vector3(initX, initY + 10f, initZ - 2f);

        while (transform.position != target2)
        {
            transform.position = Vector3.MoveTowards(transform.position, target2, speed * Time.deltaTime);
            yield return null;
        }
        Vector3 target1 = new Vector3(initX, initY, initZ - 2f);

        while (transform.position != target1)
        {
            transform.position = Vector3.MoveTowards(transform.position, target1, speed * Time.deltaTime);
            yield return null;
        }

        Vector3 target = new Vector3(initX, initY, initZ);

        while (transform.position != target)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            yield return null;
        }

        move = false;
    }
}