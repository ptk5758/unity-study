using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerasy: MonoBehaviour
{
    //public Text nameUI; //Text를 가져오기 위해 준비
    //public Text goldUI;
    public Sprite changeImage; //이미지를 바꿀 수 있음
    public Image currentImage; //현재 이미지
    public Text Gold;
    public Text Level;
    int su, money, levelMoney;
    float time;
    public Text timerUI;
    public bool Stop;

    // Start is called before the first frame update
    void Start()
    {
        //nameUI.text = "이름 : 안소영";
        //currentImage.sprite = changeImage; //현재이미지를 지정해둔 다른 이미지로 변경
        su = 1;
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Stop)
        {
            return;
        }

        time += Time.deltaTime;
        timerUI.text = "시간 : " + Mathf.Round(time);

        if(time > 60)
        {
            Stop = true;
            Debug.Log("게임 종료");
        }
        
    }

    public void Money() //버튼이 눌러졌을 때
    {
        money = money + (su * 500);
        Gold.text = "돈 : " + money;
        Debug.Log("돈 버는 중");
    }

    public void LevelUp()
    {
        if(money >= su * 10000)
        {
            money = money - (su * 10000);
            Gold.text = "돈 : " + money;
            su++;
            Level.text = "레벨 : " + su; 
        }
        
        if(su == 5)
        {
            currentImage.sprite = changeImage;
        }
    }

    public void timer()
    { 
        if(time > 60)
        {
            Gold.enabled = false;
        }
    }
}
