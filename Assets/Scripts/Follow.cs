using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    //[SerializeField]
    public GameObject Player;

    private void Update()
    {
        this.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + 0.5f, Player.transform.position.z - 3f);
        
    }
}
