using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundBehaviour : MonoBehaviour
{
    public GameObject ball;
    public GameObject ball_spawn;

    public GameObject wind_fan;
    public GameObject wind_zone;
    public GameObject fan_left_pos;
    public GameObject fan_righ_pos;

    public void ResetBall()
    {
        ball.gameObject.SetActive(true);
        var ball_rb = ball.gameObject.GetComponent<Rigidbody>();
        ball_rb.velocity = new Vector3(0, -1, 0);
        ball_rb.freezeRotation = true;

        ball.transform.position = ball_spawn.transform.position;
    
        ball_rb.freezeRotation = false;
    }

    public void SwapFanPosition()
    {
        //swaps position of the fan
        if (wind_fan.transform.position == fan_left_pos.transform.position)
        {
            wind_fan.transform.position = fan_righ_pos.transform.position;
        }
        else
        {
            wind_fan.transform.position = fan_left_pos.transform.position;
        }

        //swaps the rotation of the fan
        wind_fan.transform.Rotate(new Vector3(45, -30, 0));

        //swaps direction of the wind zone
        wind_zone.GetComponent<WindFanBehaviour>();
        //wind_zone.
    }
}
