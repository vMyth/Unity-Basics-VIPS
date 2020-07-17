using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newposition : MonoBehaviour
{
    private void Awake()
    {
        transform.position = transform.position + new Vector3(0, 0, 20);
    }
}
