using UnityEngine;
using System.Collections;

public class TargetScript : MonoBehaviour {

	

	//Used to check if the target has been hit
	public bool isHit = false;

	public int health;
	public int maxhealth;

    private void Start()
    {
		health = maxhealth; 
    }

    private void Update () {



		//If the target is hit
		if (isHit == true)
		{
			Helthdumeg(1);
			isHit = false; 

			
		
		}
	}

	public void Helthdumeg(int h)
    {
		health = health - h;

        if (health <= 0)
        {
            Destroy(gameObject);

        }

    }

	
}