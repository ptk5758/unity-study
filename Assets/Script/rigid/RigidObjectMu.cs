using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidObjectMu : RigidObject
{
    Rigidbody rigid;

    private void Awake()
    {
        this.rigid = this.transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(delay(3f));            
        }
    }
    private IEnumerator delay(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        rigid.useGravity = true;
    }
}