using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerPjw : MonoBehaviour
{

    public Text txtJin;
    public Sprite newJins;
    public Image currentJin;
    public int playerGold;
    public int playerLevel;
    public Text txtGold;
    public Text txtLevel;
    public Text txtPlayTime;
    float playtime;

    public GameObject btnMoney;

    private void Awake()
    {
        playerGold = 0;
        playerLevel = 1;
        playtime = 60;
        
    }

    void Start()
    {
        // txtJin.text = "진 부러운점 : 진라면광고함";
        //currentJin = GetComponent<Image>();
    }

    
    void Update()
    {
        
        playtime -= Time.deltaTime;
        //playtime = (int)playtime;
        txtPlayTime.text = playtime.ToString();

       

        if (playtime <=0)
        {
            GameOver();
            txtPlayTime.text = "00";

        }
        txtGold.text = playerGold.ToString();
        txtLevel.text = playerLevel.ToString();

        
    }

    void ChangeIcon()
    {
        currentJin.sprite = newJins;
    }

    public void JinButtonUP()
    {
        Debug.Log("진 부러운점 : 진라면광고함 ");
        //currentJin.sprite = newJins;
        playerGold += playerLevel * 500;
        
    }

    public void GameOver()
    {
        //게임오브젝트=셋false
        gameObject.SetActive(false);
    }

    public void PlayerLevelUp()
    {
        if (playerGold < playerLevel * 10000)
        {
            Debug.Log("당신은 레벨업도 못하는 거지입니다...");
        }

        if(playerGold>playerLevel*10000)
        {
            playerGold -= playerLevel * 10000;
            playerLevel++;

            if (playerLevel >= 5)
            {
                //이미지 변경
                //currentJin.sprite = newJins;
                ChangeIcon();
            }
        }


       
    }
}
