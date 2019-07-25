using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TrashCanBehaviour : MonoBehaviour
{
    public UnityEvent after_goal_response;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            other.GetComponent<ConstantForce>().enabled = false;
            after_goal_response.Invoke();
        }
    }
}
