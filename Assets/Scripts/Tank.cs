using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D rBulletPrefab;

    [SerializeField]
    private Transform tCurrentCannon;

    public float fDriveSpeed = 5f;
    public float fMaxVelocity = 10f;
    public float fMisileForce = 5f;

    public int iTankID;

    private SpriteRenderer sSpriteRenderer;

    private Camera cMainCam;

    public bool bIsTurn { get { return TankManager.tmInstance.IsMyTurn(iTankID); } }

    private TankHealth tTankHealth;

    private Vector3 diff;

    void Start()
    {

        sSpriteRenderer = GetComponent<SpriteRenderer>();

        // get health script
        tTankHealth = GetComponent<TankHealth>();

        cMainCam = Camera.main;
        
    }

    void Update()
    {

        if (!bIsTurn)
            return;

        RotateGun();

        MovementAndShooting();

    }

    void RotateGun()
    {

        diff = cMainCam.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        diff.Normalize();

        float rot_Z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;

        tCurrentCannon.rotation = Quaternion.Euler(0, 0, rot_Z + 180f);

    }

    void MovementAndShooting()
    {

        float hor = Input.GetAxis("Horizontal");

        if (hor == 0)
        {

            tCurrentCannon.gameObject.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Space))
            {

                Rigidbody2D bullet = Instantiate(rBulletPrefab,
                    tCurrentCannon.position - tCurrentCannon.right,
                    tCurrentCannon.rotation);

                bullet.AddForce(-tCurrentCannon.right * fMisileForce, ForceMode2D.Impulse);

                if (bIsTurn)
                {

                    TankManager.tmInstance.NextTank();

                }

            }

        }

        else
        {

            tCurrentCannon.gameObject.SetActive(false);

            transform.position += Vector3.right * hor * Time.deltaTime * fDriveSpeed;

            sSpriteRenderer.flipX = Input.GetAxis("Horizontal") > 0f;

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Bullet"))
        {

            tTankHealth.ChangeHealth(-10);

            if (bIsTurn)
                TankManager.tmInstance.NextTank();

        }

    }

}
