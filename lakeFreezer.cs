using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//fills an area with similar game objects
public class lakeFreezer : MonoBehaviour {
    public Transform start;
    public int amount_x;
    public int amount_z;
    public GameObject filler;
    public int x_offset;
    public int z_offset;
    

	void Start () {
		for (int i = 0; i <= amount_x; i++)
        {
            for (int j = 0; j<= amount_z; j++)
            {
                Instantiate(filler, start.position + new Vector3(i*x_offset, 0, j*z_offset+(i%2)*z_offset/2), filler.transform.rotation);
            }
        }
	}
	

}
