using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ob;
    public GameObject SpParent;
    public int count;
    int i;
    private void Update()
    {
        if(i<count)
        {
            i++;
            Instantiate(ob, SpParent.transform.position+new Vector3(Random.value*10, 0, Random.value * 10), Quaternion.identity, SpParent.transform);
        }
    }
}
