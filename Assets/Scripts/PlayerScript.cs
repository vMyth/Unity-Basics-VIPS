using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody rb;
    float hMov, vMov;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        hMov = Input.GetAxis("Horizontal");
        vMov = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(new Vector3(hMov, 0, vMov) *  10);

            rb.AddForce(Vector3.forward * 10);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("FOOD"))
        {
            Destroy(collision.gameObject);
        }
    }
}
