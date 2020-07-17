using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundspawner : MonoBehaviour
{
    public GameObject ground;
    private void GroundSpawn()
    {
        Instantiate(ground);
    }

    private void OnTriggerEnter(Collider other)
    {
        GroundSpawn();
    }
}
