using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItemSpawner : MonoBehaviour
{
    public GameObject PickUpItem;
    public int SpawnCount = 8;
    public float SpawnCircleRadius = 3f;

    public List<PickUpItem>PickupItems = new List<PickUpItem>();
    void Start()
    {
        float radian = Mathf.PI * 2 / SpawnCount;
        for(int i = 0; i < SpawnCount; i++)
        {
            GameObject Pick = Instantiate(PickUpItem);
            Vector3 pos = Pick.transform.position;
            pos.z = Mathf.Sin(radian*(i + 1))*SpawnCircleRadius;
            pos.x = Mathf.Cos(radian*(i + 1))*SpawnCircleRadius;
            Pick.transform.position = pos;
            Pick.GetComponent<PickUpItem>().SetPickupNumber(i+1);
            PickupItems.Add(Pick.GetComponent<PickUpItem>());
        }
        
    }

}
