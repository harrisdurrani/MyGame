using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : weapon
{   [SerializeField]
    private float thisFireRate = 0f;
    [SerializeField]
    private GameObject setBullet;
    private void Awake()
    {
        base.fireRate = thisFireRate;
        bullet = setBullet;
        firePoint = transform.Find("FirePoint");
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
    }
}

