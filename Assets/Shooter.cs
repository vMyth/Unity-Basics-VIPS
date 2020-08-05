using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject prefab;
    GameObject projectile;
    private void FixedUpdate()
    {

        if (Input.GetMouseButtonDown(0))
        {
            projectile = Instantiate(prefab) as GameObject;
            projectile.transform.position = transform.position + new Vector3(1,1,0);
            projectile.GetComponent<Rigidbody>().velocity = Vector3.right * 20;
            //RaycastHit hit;
            //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit))
            //{
            //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * hit.distance, Color.red);
            //    Destroy(hit.collider.gameObject);
            //}
            //else
            //{
            //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * 1000, Color.black);
            //}
        }
        
    }
}
