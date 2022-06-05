using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPickupItemManager : MonoBehaviour
{
    //PickUpItemが生まれる数を取得するためにPPickupImetSpawnerを参照する
    public PickUpItemSpawner PickUpItemSpawner;

    //プレイヤーが取得したアイテム数
    public int PickUpItemCount = 0;

    //生まれた数
    public int PickupItemSpawnCount = 0;

    //全て取得できたかのフラグ
    public bool GetAllPickupItems = false;

    public GameState GameState;
    private void Start()
    {
        PickupItemSpawnCount = PickUpItemSpawner.SpawnCount;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(GameState.GetGameProgressState() == GameState.GameProgressStates.GameResult)
        {
            return;
        }

    
        if(collision.gameObject.tag.Equals("PickupItem"))
        {
            PickUpItemCount++;

            var pickUpItem = collision.gameObject.GetComponent<PickUpItem>();
            if(pickUpItem.GetPickupNumber() != PickUpItemCount)
            {
                PickUpItemCount--;
                return;
            }

            pickUpItem.SetIsDestructible(true);

         
            if(PickUpItemCount == PickupItemSpawnCount)
            {
                GetAllPickupItems = true;
                
                GameState.SetGameProgressState(GameState.GameProgressStates.GameResult);
               
                GameResultParam.IsWinResult();

                SceneManager.LoadScene("Result");
            } 
        }
    }
}
