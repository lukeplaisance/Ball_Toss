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
        var fot = shoot_force * Time.deltaTime; //force over time
        rigidbody.AddForce(new Vector3(direction.x, direction.y, direction.z), ForceMode.Impulse);
    }

    void Update()
    {
        velocity = rigidbody.velocity;
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
