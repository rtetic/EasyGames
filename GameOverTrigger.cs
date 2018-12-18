using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//add on gameobject that kills the player on contact
//needs a collider with "is trigger" checked

public class GameOverTrigger : MonoBehaviour {
    
    private void OnTriggerEnter(Collider ausloeser)
    {
        if (ausloeser.tag == "Player" )
        {
            if (gameObject.tag == "Zombie")
            {
                gameObject.GetComponent<Animator>().SetTrigger("attacks");
            }
            FindObjectOfType<GameManager>().GameOver();
        }
        
    }
}
