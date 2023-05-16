using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{




	void Start ()
    {
		


	}
	
	void Update ()
    {
	
        

	}

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Hit " + other.name + "!");
        Destroy(gameObject);
        
    }

}
