using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondCollision : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        //attached transform to player 
        if (other.transform.tag == "Player")
        {
            Debug.Log("collided");
            Destroy(gameObject);

        }
    }

}
