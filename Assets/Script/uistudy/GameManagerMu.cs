using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerMu : MonoBehaviour
{
    public Text nameUI;
    public Text goldUI;
    public Text levelUI;
    public Text levelUpUI;
    public Text timerUI;
    public Sprite changeIMG;
    public Image currentIMG;
    private int level; // ����
    private int earnGold; // ������
    private float timer; // �������ѽð�
    private bool onEarnGold = true; // ������ �� ����
    private int levelUpGold = 10000;
    void Start()
    {
        nameUI.text = "�̸� : ��ο�";
        level = 1;
        earnGold = level * 500;
        timer = 10f;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        timerUI.text = timer.ToString();
        if(timer <= 0)
        {
            timer = 0;
            onEarnGold = false;
        }
        if(level >= 5)
        {
            currentIMG.sprite = changeIMG;
        }
    }
    private void CurrentGold(int eGold)
    {
        earnGold += eGold;
        goldUI.text = "Gold : " + earnGold.ToString();
    }
    private void LevelUp()
    {
        level++;
        earnGold -= levelUpGold;
        goldUI.text = "Gold : " + earnGold.ToString();
        levelUI.text = "Level : " + level.ToString();
        levelUpGold += 10000;
    }
    //�Ĺ� ��ư�� ���������� ȣ��
    public void OnFarmingButtonUP()
    {
        Debug.Log("�Ĺ�");
        Debug.Log(timer);
        if (onEarnGold == true)
        {
            int earnedGold = level * 500;
            CurrentGold(earnedGold);
        }
    }
    public void OnLevelUPButtonUp()
    {
        if (onEarnGold == true)
        {
            if(earnGold >= levelUpGold)
            {
                LevelUp();
                levelUpUI.text = "���������" + levelUpGold.ToString();
            }
            else
            {
                Debug.Log("������ ����� �����մϴ�.");
            }
        }
    }
}