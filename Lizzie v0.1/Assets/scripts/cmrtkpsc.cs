using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cmrtkpsc : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

   
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,target.position+offset,Time.deltaTime*2);
    }
}
