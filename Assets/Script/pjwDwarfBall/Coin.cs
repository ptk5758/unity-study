using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : DwarfMoney
{
    // ���ΰ� �浹 �� ���� ��Ȱ��ȭ+ �ڻ� ����

    //private void Awake()
    //{
    //    asset = 0;
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name == "Ball")
    //    {
    //        money.SetActive(false);
    //        Debug.Log("dd");
    //    }

    //}

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="Player")
        {
            //AddMoney();
            DwarfMoney.asset += 100;
            Debug.Log(asset);
            Destroy(gameObject);
        }
    }

    
  
}
