using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour 
{
	[SerializeField] private GameObject placeableObjectPrefab;
	[SerializeField] private KeyCode newObjectHotKey = KeyCode.A;
	private GameObject currentPlaceableObject;
	private float mouseWheelRotation;
	void Update () // Update is called once per frame
	{
		HandleNewObjectHotkey ();
	}
	private void HandleNewObjectHotkey()
	{
		if(Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hitInfo;
			if(Physics.Raycast(ray, out hitInfo))
			{
				currentPlaceableObject.transform.position = hitInfo.point;
				Instantiate (placeableObjectPrefab);
			}

		}
	}
}
