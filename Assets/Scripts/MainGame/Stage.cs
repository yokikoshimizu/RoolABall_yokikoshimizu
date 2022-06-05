using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    public enum StageTypes
    {
        NomalType,
        IceType
    }

    public StageTypes StageType = StageTypes.NomalType;
    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag.Equals("Player"))
        {
            switch (StageType)
            {
                case StageTypes.NomalType:
                    collision.gameObject.GetComponent<Rigidbody>().angularDrag = 10f;
                    break;

                case StageTypes.IceType:
                    collision.gameObject.GetComponent<Rigidbody>().angularDrag = 0f;
                    break;
            }
        }
    }
}
