using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : weapon
{   [SerializeField]
    private float thisFireRate = 0f;
    [SerializeField]
    private GameObject setBullet;
    private GameObject player;
    private Vector2 playerpos;
    private Vector2 mouseaim;
    private float xangle;
    private void Awake()
    {
        player = GameObject.Find("Player"); 
        base.fireRate = thisFireRate;
        bullet = setBullet;
        firePoint = transform.Find("FirePoint");
        playerpos = player.transform.position;
        if (firePoint == null)
        {
            Debug.LogError("Firepoint Does Not Exist");
        }
            
    }
    private void GetInput() {
        if (fireRate == 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                base.Shoot();
            }

            else
            {
                if(Input.GetButton("Fire1") && Time.time > timeToFire)
                {
                    timeToFire = Time.time + 1 / fireRate;
                    Shoot();

                }
            }
        }
        
            
    }
    private void Update()
    {
        GetInput();
        Vector2 mousePosition2 = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        xangle = Mathf.Atan((mousePosition2.y - playerpos.y)/(mousePosition2.x - playerpos.x));
        xangle = (xangle * Mathf.Rad2Deg);
        this.transform.rotation = Quaternion.Euler(0, 0, xangle);

    }
}

