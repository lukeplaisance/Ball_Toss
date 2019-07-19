using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBallBehaviour : MonoBehaviour
{
    public GameObject ball;
    public GameObject ball_spawn;

    public void ResetBall()
    {
        ball.gameObject.SetActive(true);
        var ball_rb = ball.gameObject.GetComponent<Rigidbody>();
        ball_rb.velocity = new Vector3(0, -1, 0);
        ball_rb.freezeRotation = true;

        ball.transform.position = ball_spawn.transform.position;
    
        ball_rb.freezeRotation = false;
    }
}
