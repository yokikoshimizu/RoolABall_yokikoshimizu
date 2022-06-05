using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickupItemNumberView : MonoBehaviour
{
    // Start is called before the first frame update
    
    public PickUpItemSpawner PickUpItemSpawner;

    public TextMeshProUGUI PickupNumberNode;

    public List<TextMeshProUGUI>PickupNumberNodes = new List<TextMeshProUGUI>();
    
    private void Start()
    {
        PickupNumberNodes.Clear();

        PickupNumberNode.text = string.Empty;

        for(int i = 0; i < PickUpItemSpawner.SpawnCount; i++)
        {
            Debug.Log(i);
            PickupNumberNodes.Add(Instantiate(PickupNumberNode, this.transform));
            PickupNumberNodes[i].text = $"{i + 1}";
        }
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        for(int i = 0; i < PickUpItemSpawner.SpawnCount; i++)
        {
            if(!PickUpItemSpawner.PickupItems[i].gameObject.activeSelf)
            {
                if(!PickupNumberNodes[i].text.Equals(string.Empty))
                {
                    PickupNumberNodes[i].text = string.Empty;
                }
                continue;
            }
            PickupNumberNodes[i].rectTransform.position
            = Camera.main.WorldToScreenPoint(PickUpItemSpawner.PickupItems[i].transform.position);
    }
        }

        
}
