using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    int count = 0;
    void OnCollisionEnter(Collision collision)
    { 

    
        if (collision.collider.CompareTag("coin"))
        {
            count++;
            Destroy(collision.gameObject);
            Debug.Log("Coins collected: " + count );
        }

    }

}

