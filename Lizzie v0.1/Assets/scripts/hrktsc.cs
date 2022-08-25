using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hrktsc : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float ilerimovementSpeed;
    //[SerializeField] float horSpeed;
    //float hor;
    Vector3 firstPos, endPos;
    public float farkX;



    void Update()
    {
        //kaydýrma ile hareket
        if (Input.GetMouseButtonDown(0))//ilk týklama
        {
            firstPos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            endPos = Input.mousePosition;
             farkX = endPos.x - firstPos.x;

        }

        if(Input.GetMouseButtonUp(0))
        {
            firstPos = Vector3.zero;
            endPos = Vector3.zero;
        }
        

        //a d ile hareket
        //hor = Input.GetAxis("Horizontal");

        //tam gaz ileri
        transform.Translate(new Vector3(ilerimovementSpeed * Time.deltaTime, -farkX*Time.deltaTime*movementSpeed/*-hor * horSpeed * Time.deltaTime*/,  0));
    }
}
