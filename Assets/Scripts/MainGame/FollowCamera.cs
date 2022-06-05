using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
   
   public GameObject FollowTarget;
   
   
   public Vector3 OffSet;

   private void LateUpdate()
   {
       transform.position = FollowTarget.transform.position + OffSet;
       transform.LookAt(FollowTarget.transform);
   }
}
