using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//add script on game object that is supposed to break on impact, including walking on it
//un-comment Debug.Log(velocity.magnitude) on line 28 to find out the force applied on the game object, then set the threshold variables accordingly.

public class breakOnImpact : MonoBehaviour {
    public float impact_threshold_soft; //object tolerates impacts of this force for 1s
    public float impact_threshold_hard; //object instantly breaks e.g. when player jumps
    //public AudioClip warning_sound; //warning that is played when soft threshold is reached; maybe remove and just play footsteps on ice
    private float contact_time; //total time of being over soft threshold
    

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 velocity = collision.relativeVelocity;
        contact_time = 0;
        if (impact_threshold_hard < velocity.magnitude)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        Vector3 velocity = collision.relativeVelocity;
        //Debug.Log(velocity.magnitude);
        
        if (impact_threshold_soft < velocity.magnitude)
        {
            contact_time += Time.deltaTime;
            if (contact_time > 1)
            {
                Destroy(gameObject);
            }
                        
        }
    }
}
