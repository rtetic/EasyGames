using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Invector.CharacterController;

public class GameManager : MonoBehaviour {
    public GameObject showBlood;
    vThirdPersonController Player;
    vThirdPersonCamera Camera;
    public bool isDead;
    public void Start()
    {
        Player = FindObjectOfType<vThirdPersonController>();
        Camera = FindObjectOfType<vThirdPersonCamera>();
        isDead = false;
    }
    public void LevelComplete()
    {
        Debug.Log("Level beendet");
        //menü oder nächstes level laden
    }

    public void GameOver()
    {
        
        showBlood.SetActive(true);//turns screen red
        Player.animator.SetTrigger("IsDead");
        
        
        //Player.speed = 0;
        //Camera.lockCamera = true; //brute force to stop from rotating when dead, find better solution 
        //Player.GetComponent<Rigidbody>().drag = 1000; //brute force to stop from sliding when dead, find better solution lines below are better but still not optimal
        //Player.targetDirection = new Vector3(0, 0, 0);
        Player.freeWalkSpeed = 0;
        Player.freeSprintSpeed = 0;
        Player.freeRunningSpeed = 0;
        Player.freeRotationSpeed = 0;//prevents from running, walking, sprinting or rotating when dead, better than raising drag
        Player.lockMovement = true; //only locks movement to its current, doesnt stop it; prevents from jumping when dead
        isDead = true;
        //Debug.Log("gestorben");
        Invoke("Restart", 3f); //wait 3s for the death animation 
    }
    
    public void Restart()
    {
        SceneManager.LoadScene("Level1_variante");
    }

    void zoomOut()
    {
        if (Camera.yMinLimit < 80)
            {
                Camera.yMinLimit += 4;
            }
            if (Camera.height < 6)
            {
                Camera.height += 0.1f;
            }
    }
    public void Update()
    {
        if (isDead)
        {
            zoomOut();
        }
    }
    
}
