using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//classとは…一つの変数を表せない（複数の情報を表したい）時に使う、オリジナルの型（オブジェクトを定義する）
//変数と関数を同時に持つことができる
public class PickUpItem : MonoBehaviour
{

    private bool isDestructible = false;

    private int pickupNumber = 0;

    public void SetPickupNumber(int pickupNumber)
    {
        this.pickupNumber = pickupNumber;
    }

    public int GetPickupNumber()
    {
        return pickupNumber;
    }

    public void SetIsDestructible(bool isDestructible)
    {
        this.isDestructible = isDestructible;
    }

    private void Update()
    {
        transform.Rotate(new Vector3(1,1,-1));
       float sin = Mathf.Sin(Time.time);
       transform.localPosition += new Vector3(sin/100,0,0);


    }

    private void OnCollisionEnter(Collision collision)
    {
        if(!isDestructible)
        {
            return;
        }
        if(collision.gameObject.tag.Equals("Player")){
           // Destroy(this.gameObject);
           this.gameObject.SetActive(false);
        }
    }
}
