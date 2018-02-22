using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject MC;
    public float movementSpeed = 1;
    void Start () // Use this for initialization
    {
		
	}
	void Update () // Update is called once per frame
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += (Vector3.up) * movementSpeed;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += (Vector3.left) * movementSpeed;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += (Vector3.down) * movementSpeed;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += (Vector3.right) * movementSpeed;
        }
    }
}
