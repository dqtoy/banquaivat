using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTanCong : MonoBehaviour
{
    private WeaponManager weapon_Manager;

    public float fireRate = 15f;
    private float nextTimeToFire;
    public float damage = 20f;

    private bool zoomed;

    private Camera mainCam;

    private GameObject crosshair;

    private bool is_Aiming;



    void Awake()
    {

        weapon_Manager = GetComponent<WeaponManager>();


        crosshair = GameObject.FindWithTag(Tags.CROSSHAIR);

        mainCam = Camera.main;

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        WeaponShoot();
        ZoomInAndOut();
    }

    void WeaponShoot()
    {

        // if we have assault riffle
        if (weapon_Manager.GetCurrentSelectedWeapon().fireType == WeaponFireType.MULTIPLE)
        {

            Debug.Log("weapon multiple");
            // if we press and hold left mouse click AND
            // if Time is greater than the nextTimeToFire
            if (Input.GetMouseButton(0) && Time.time > nextTimeToFire)
            {

                Debug.Log("weapon multiple click");
                nextTimeToFire = Time.time + 1f / fireRate;

                weapon_Manager.GetCurrentSelectedWeapon().ShootAnimation();

                BulletFired();

            }



        }
        // if we have a regular weapon that shoots once
        else
        {

            Debug.Log("weapon single");
            if (Input.GetMouseButtonDown(0))
            {

                // handle axe
                if (weapon_Manager.GetCurrentSelectedWeapon().tag == Tags.AXE_TAG)
                {
                    weapon_Manager.GetCurrentSelectedWeapon().ShootAnimation();

                    Debug.Log("weapon single axe click");
                }

                // handle shoot
                if (weapon_Manager.GetCurrentSelectedWeapon().bulletType == WeaponBulletType.BULLET)
                {

                    Debug.Log("weapon single click");
                    weapon_Manager.GetCurrentSelectedWeapon().ShootAnimation();

                    BulletFired();

                }

            } // if input get mouse button 0

        } // else

    } // weapon shoot

    void ZoomInAndOut()
    {


    } // zoom in and out

    void BulletFired()
    {

        RaycastHit hit;

        if (Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit))
        {
            print("hit: " + hit.transform.gameObject.name);
            if (hit.transform.tag == Tags.ENEMY_TAG)
            {
                //hit.transform.GetComponent<HealthScript>().ApplyDamage(damage);
            }

        }

    } // bullet fired

} // class
