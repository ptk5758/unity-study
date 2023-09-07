using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerasy: MonoBehaviour
{
    //public Text nameUI; //Text�� �������� ���� �غ�
    //public Text goldUI;
    public Sprite changeImage; //�̹����� �ٲ� �� ����
    public Image currentImage; //���� �̹���
    public Text Gold;
    public Text Level;
    int su, money, levelMoney;
    float time;
    public Text timerUI;
    public bool Stop;

    // Start is called before the first frame update
    void Start()
    {
        //nameUI.text = "�̸� : �ȼҿ�";
        //currentImage.sprite = changeImage; //�����̹����� �����ص� �ٸ� �̹����� ����
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
        timerUI.text = "�ð� : " + Mathf.Round(time);

        if(time > 60)
        {
            Stop = true;
            Debug.Log("���� ����");
        }
        
    }

    public void Money() //��ư�� �������� ��
    {
        money = money + (su * 500);
        Gold.text = "�� : " + money;
        Debug.Log("�� ���� ��");
    }

    public void LevelUp()
    {
        if(money >= su * 10000)
        {
            money = money - (su * 10000);
            Gold.text = "�� : " + money;
            su++;
            Level.text = "���� : " + su; 
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
