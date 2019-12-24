using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TanCongScript : MonoBehaviour
{
    public float damage = 2f;
    public float radius = 1f;
    public LayerMask layerMask;

    void Update()
    {

        Collider[] hits = Physics.OverlapSphere(transform.position, radius, layerMask);

        if (hits.Length > 0)
        {
            print("We touch: "+ hits[0].gameObject.tag);
            hits[0].gameObject.GetComponent<MauScript>().ApplyDamage(damage);
            gameObject.SetActive(false);

        }

    }

} // class




























