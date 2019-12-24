using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    [SerializeField]
    private WeaponHandler[] weapons;
    public bool alpha1 = true;
    public bool alpha2 = true;
    public bool alpha3 = true;
    public bool alpha4 = true;

    private int current_Weapon_Index;

    // Use this for initialization
    void Start()
    {
        current_Weapon_Index = 0;
        weapons[current_Weapon_Index].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (alpha1)
                TurnOnSelectedWeapon(0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (alpha2)
                TurnOnSelectedWeapon(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {

            if (alpha3)
                TurnOnSelectedWeapon(2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {

            if (alpha4)
                TurnOnSelectedWeapon(3);
        }

   
    } // update

    void TurnOnSelectedWeapon(int weaponIndex)
    {

        if (current_Weapon_Index == weaponIndex)
            return;
        if (weaponIndex > 4) return;

        // turn of the current weapon
        weapons[current_Weapon_Index].gameObject.SetActive(false);

        // turn on the selected weapon
        weapons[weaponIndex].gameObject.SetActive(true);

        // store the current selected weapon index
        current_Weapon_Index = weaponIndex;

    }

    public WeaponHandler GetCurrentSelectedWeapon()
    {
        return weapons[current_Weapon_Index];
    }

}
