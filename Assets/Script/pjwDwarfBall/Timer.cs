using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    float playtime;
    public Text txtPlayTime;
    private void Awake()
    {
       
        playtime = 60;

    }
    private void Update()
    {
        playtime -= Time.deltaTime;
        txtPlayTime.text = playtime.ToString();
        if(playtime <0)
        {
            SceneManager.LoadScene("gameOver");
        }
    }
}
