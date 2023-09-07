using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuMiniGame : MonoBehaviour
{
    protected bool s1 = false;
    protected bool s2 = false;
    protected bool s3 = false;

    void Start()
    {
        Debug.Log("1, 2, 3 키를 눌러 스위치 켜고 끄기");
        Debug.Log("스위치 상태확인 키 : 4");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Presss1();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Presss2();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Presss3();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            CheckSwitchStatus();
        }
    }

    public void Presss1()
    {
        s1 = !s1;
        CheckSwitchStatus();
    }
    public void Presss2()
    {
        s2 = !s2;
        CheckSwitchStatus();
    }
    public void Presss3()
    {
        s3 = !s3;
        CheckSwitchStatus();
    }
    public void CheckSwitchStatus()
    {
        string switch1Status = s1 ? "on" : "off";
        string switch2Status = s2 ? "on" : "off";
        string switch3Status = s3 ? "on" : "off";

        Debug.Log($"스위치 1: {switch1Status}, 스위치 2: {switch2Status}, 스위치 3: {switch3Status}");
    }
}