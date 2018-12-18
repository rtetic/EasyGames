using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//add on "finish line"

public class TriggerFinish : MonoBehaviour {
    public GameManager gameManager;

    void OnTriggerEnter(Collider ausloeser)
    {
        if (ausloeser.tag == "Player")
        {
            gameManager.LevelComplete();
        }
        
    }

}

