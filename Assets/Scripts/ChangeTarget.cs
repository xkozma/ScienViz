using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTarget : MonoBehaviour
{
    public Transform Target;
    public float Speed = 1f;

    private Quaternion newRot;
    private Vector3 relPos;
    
    
    private void Update()
    {
        if (transform.rotation != newRot)
        {
            relPos = Target.position - transform.position;
            newRot = Quaternion.LookRotation(relPos);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, newRot, Time.deltaTime * Speed);
        }

        if (transform.position != Target.position - new Vector3(0, 0, 5))
        {
            transform.position = Vector3.MoveTowards(transform.position, Target.position- new Vector3(0, 0, 5), Time.deltaTime * Speed);
        }
    }
}
