using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour {
    
    //create a cube (or other game object) with collider marked as trigger
    //warning will be displayed on entering the collider, rock falls on exit. Adjust size of the collider accordingly.
    //add gameobjects for rocks and warning
    //create spawn points for left and right warning, same for rocks (empty game objects)
    
   
    public GameObject rockPrefab;
    public GameObject warningPrefab;
    


    public Transform[] leftSpawn;
    public Transform leftWarning;
    public Transform[] rightSpawn;
    public Transform rightWarning;
    private bool istriggered = false;
    private int side;
    private void Start()
    {
        side = Random.Range(1, 3);//upper limit excluded
        
    }
    void OnTriggerEnter()
    {
        if (side == 1)//left
        {
            Instantiate(warningPrefab, leftWarning.position, leftWarning.rotation);
        }
        else//right
        {
            Instantiate(warningPrefab, rightWarning.position, rightWarning.rotation);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (side == 1)//left
        {
            for (int i = 0; i < leftSpawn.Length; i++)
                {
                    Transform sp = leftSpawn[i];
                    Instantiate(rockPrefab, sp.position, sp.rotation);
            }
        }
        else//right
        {
            for (int i = 0; i < rightSpawn.Length; i++)
                {
                    Transform sp = rightSpawn[i];
                    Instantiate(rockPrefab, sp.position, sp.rotation);
                }
        }
    }
}
