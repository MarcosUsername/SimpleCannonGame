using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEnemy : MonoBehaviour
{

    public int iTankHealth;

    public GameObject gTank;

    SceneChange sSceneChange;
    [SerializeField] GameObject gObject;

    void Start ()
    {

        iTankHealth = 100;
        sSceneChange = gObject.GetComponent<SceneChange>();

    }
	
	void Update ()
    {

        if (iTankHealth <= 0)
        {

            gTank.gameObject.SetActive(false);

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Explosion"))
        {

            iTankHealth = iTankHealth - 100;
            sSceneChange.iEnemyKilled++;
            Debug.Log("An enemy has died, the amount killed is now " + sSceneChange.iEnemyKilled);


        }

    }


}
