using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAim : MonoBehaviour
{

    public GameObject gCannon;
    public GameObject gBulletP;
    public Transform tBulletSpawn;
    public float fBulletSpeed = 30;
    public float fBulletLifeTime = 3;



	void Start ()
    {
		


	}
	
	void Update ()
    {

        if (Input.GetKey(KeyCode.Space))
        {

            Fire();

        }

        RotateGun();
		
	}

    private void Fire()
    {

        GameObject gBullet = Instantiate(gBulletP);

        Physics.IgnoreCollision(gBullet.GetComponent<Collider>(),
            tBulletSpawn.parent.GetComponent<Collider>());

        gBullet.transform.position = tBulletSpawn.position;

        Vector3 vcRotation = gBullet.transform.rotation.eulerAngles;

        gBullet.transform.rotation = Quaternion.Euler(vcRotation.x, transform.eulerAngles.y, vcRotation.z);

        gBullet.GetComponent<Rigidbody>().AddForce(tBulletSpawn.forward * fBulletSpeed, ForceMode.Impulse);

        StartCoroutine(DestroyBulletAfterTime(gBullet, fBulletLifeTime));
            
    }

    void RotateGun()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {

            gCannon.gameObject.transform.Rotate(-3f, 0, 0);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            gCannon.gameObject.transform.Rotate(0, 0, 3f);

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {

            gCannon.gameObject.transform.Rotate(3f, 0, 0);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {

            gCannon.gameObject.transform.Rotate(0, 0, -3f);

        }

    }

    private IEnumerator DestroyBulletAfterTime(GameObject gBullet, float fDelay)
    {

        yield return new WaitForSeconds(fDelay);

        Destroy(gBullet);

    }

}
