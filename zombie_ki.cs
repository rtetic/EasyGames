using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_ki : MonoBehaviour {
    public GameObject Player;
    public float ChaseDistance;
    Vector2 direction;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(gameObject.transform.position, Player.transform.position) < ChaseDistance)
        {
            gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.AICharacterControl>().target = Player.transform;
            //set target
        }
        else
        {
            //clear target or maybe not?
        }
        
    }
}
