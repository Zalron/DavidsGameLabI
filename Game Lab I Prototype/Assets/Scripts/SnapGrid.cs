using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapGrid : MonoBehaviour
{
    public float grid = 0.5f;
    float x = 0f, y = 0f;
	void Start () // Use this for initialization
    {
		
	}
	void Update () // Update is called once per frame
    {
        if (grid > 0f)
        {
            float reciprocalGrid = 1f / grid;
            x = Mathf.Round(transform.position.x * reciprocalGrid) / reciprocalGrid;
            y = Mathf.Round(transform.position.y * reciprocalGrid) / reciprocalGrid;
            transform.position = new Vector3(x, y, transform.position.z);
        }
	}
}
