using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Players")
        {
            Destroy(gameObject);
        }
    }


















    // stackle


    //private void OnCollisionEnter(Collision other)
    //{

    /* if (other.collider.gameObject.tag.Equals("Collect"))
    {

    } */
    //if (other.gameObject.CompareTag("Collect"))
    //{
    // Debug.Log("dokundu");

    //other.gameObject.transform.position = transform.position + Vector3.forward;//topla fakat vector 3 ile sonrasýna ekle
    // Destroy(gameObject.GetComponent<collectManager>());
    // other.gameObject.AddComponent<collectManager>();
    // other.gameObject.GetComponent<BoxCollider>().isTrigger = false;
    //other.gameObject.AddComponent<TopluHareket>();
    // other.gameObject.GetComponent<TopluHareket>().connectedItem = transform;
    //other.gameObject.tag = "Collected";
    // }

    //  }
    // }
}
