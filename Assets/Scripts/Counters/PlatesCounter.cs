using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlatesCounter : BaseCounter
{
    public event EventHandler OnPlateSpawned;
    public event EventHandler OnPlateRemoved;

    [SerializeField] private KitchenObjectSO plateKitchenObjectSO;
    private float spawnPlateTimer;
    private float spawnPlateTimerMax =4f;
    private int platesSpawnedAmout;
    private int platesSpawnedAmoutMax = 4; 


    private void Update()
    {
        spawnPlateTimer += Time.deltaTime;
        if(spawnPlateTimer > spawnPlateTimerMax)
        {
            spawnPlateTimer = 0;

            if(KitchenGameManager.Instance.IsGamePlaying() && platesSpawnedAmout < platesSpawnedAmoutMax)
            {
                platesSpawnedAmout++; 
                OnPlateSpawned?.Invoke(this, EventArgs.Empty);
            }
          
        }    
    }


    public override void Interact(Player player)
    {
      if(!player.HasKitchenObject()) {
        //player is empty handed
        if(platesSpawnedAmout > 0)
            {
                //There's at least one plate here
                platesSpawnedAmout--;

                KitchenObject.SpawnKitchenObject(plateKitchenObjectSO, player);
                OnPlateRemoved?.Invoke(this, EventArgs.Empty);
            }
        }



    }

}
