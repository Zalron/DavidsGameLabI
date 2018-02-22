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
		if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += (Vector3.up) * movementSpeed;
        }
		if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += (Vector3.left) * movementSpeed;
        }
		if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += (Vector3.down) * movementSpeed;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += (Vector3.right) * movementSpeed;
        }
    }
}
