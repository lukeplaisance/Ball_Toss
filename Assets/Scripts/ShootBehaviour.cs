using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class ShootBehaviour : MonoBehaviour
{
    public Rigidbody rigidbody;
    public Vector3 direction;
    public float shoot_force;
    [SerializeField] private Vector3 velocity;


	// Use this for initialization
	void Start ()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void Shoot()
    {


        if (Input.touchCount > 0)
        {
            //gets first touch since count is greater than 0
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                Vector3 touch_pos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 0));

                rigidbody.AddForce(new Vector3(touch_pos.x, touch_pos.y, 8), ForceMode.Impulse);
            }
        }
    }

    void Update()
    {
        velocity = rigidbody.velocity;
        Shoot();
    }
}

#if UNITY_EDITOR

[CustomEditor(typeof(ShootBehaviour))]
public class ShootBehaviourEditor : Editor
{
    private ShootBehaviour sb;

    private void OnEnable()
    {
        sb = target as ShootBehaviour;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Shoot"))
        {
            sb.Shoot();
        }
    }
#endif
}
