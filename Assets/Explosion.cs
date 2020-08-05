using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
     public GameObject explosionEffect;

    private void OnCollisionEnter(Collision collision)
    {
        explosionEffect.SetActive(true);
    }
}
