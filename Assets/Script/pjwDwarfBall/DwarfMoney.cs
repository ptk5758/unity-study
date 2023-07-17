using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DwarfMoney : MonoBehaviour
{
    public static int asset;
    public Text txtMoney;
    //public int damage;
    //public void AddMoney()
    //{
    //    asset++;
    //}

    private void Update()
    {
        txtMoney.text = asset.ToString();
    }


}
