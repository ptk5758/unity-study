using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : DwarfMoney
{


    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("goal");
            if(asset>=0)
            {
                SceneManager.LoadScene("win");
            }
            if(asset <0)
            {
                SceneManager.LoadScene("lose");
            }
            
        }
    }
}
