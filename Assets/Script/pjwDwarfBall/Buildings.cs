using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildings : DwarfMoney
{
    SpriteRenderer sr;
    public GameObject building;

    private void Awake()
    {
        //sr = building.GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            
            DwarfMoney.asset -= 100;
            Debug.Log(asset);
            //sr.material.color = Color.red;
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

}
