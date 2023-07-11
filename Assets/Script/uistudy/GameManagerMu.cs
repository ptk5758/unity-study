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
    private int level; // 레벨
    private int earnGold; // 돈벌기
    private float timer; // 게임제한시간
    private bool onEarnGold = true; // 돈벌기 온 오프
    private int levelUpGold = 10000;
    void Start()
    {
        nameUI.text = "이름 : 장민욱";
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
    //파밍 버튼이 눌려졌을떄 호출
    public void OnFarmingButtonUP()
    {
        Debug.Log("파밍");
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
                levelUpUI.text = "레벨업비용" + levelUpGold.ToString();
            }
            else
            {
                Debug.Log("레벨업 비용이 부족합니다.");
            }
        }
    }
}