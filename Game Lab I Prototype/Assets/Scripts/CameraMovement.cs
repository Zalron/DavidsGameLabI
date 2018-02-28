using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject MC;
    public float movementSpeed = 1;
    // floats that set the place area
    public float xMin = -5;
    public float xMax = 5;
    public float yMin = -5;
    public float yMax = 5;
    Transform t; // a Transform used for 
    void Awake () // Use this for initialization
    {
        t = transform;
	}
	void Update () // Update is called once per frame
    {
		if (Input.GetKey(KeyCode.UpArrow)) 
        {
            transform.position += (Vector3.up) * movementSpeed;
        }
		if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += (Vector3.left) * movementSpeed;
        }
		if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += (Vector3.right) * movementSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += (Vector3.down) * movementSpeed;
        }
    }
    void LateUpdate() // used to clamp the camera to the intended play area 
    {
        float x = Mathf.Clamp(MC.transform.position.x, xMin, xMax);
        float y = Mathf.Clamp(MC.transform.position.y, yMin, yMax);
        t.position = new Vector3(x, y, t.position.z);
    }
}
