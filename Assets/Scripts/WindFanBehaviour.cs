using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class WindFanBehaviour : MonoBehaviour
{
    public bool change_velocity = false;

    private void OnTriggerEnter(Collider other)
    {
        float lift_duration = 10;
        if (other.CompareTag("Ball"))
        {
            other.GetComponent<Rigidbody>();
            other.attachedRigidbody.AddForce(new Vector3(200,0,0), ForceMode.Acceleration);
            other.attachedRigidbody.velocity = new Vector3(8, 8, 8) * Time.deltaTime;
            //change_velocity = true;
        }
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Ball"))
    //    {
    //        other.GetComponent<Rigidbody>();
    //        other.attachedRigidbody.AddForce(new Vector3(-350, 0,0), ForceMode.Force);
    //    }
    //}
}
