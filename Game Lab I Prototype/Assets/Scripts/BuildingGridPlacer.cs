using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingGridPlacer : MonoBehaviour
{
    Grid grid;
    public float size = 1f;
    void Awake()
    {
        grid = FindObjectOfType<Grid>();    
    }
	void Update () // Update is called once per frame
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo))
            {
                PlaceBuildingNear(hitInfo.point);
            }
        }
	}
    public Vector3 GetNearestPointOnGrid(Vector3 position)
    {
        position -= transform.position;
        int xCount = Mathf.RoundToInt(position.x / size);
        int yCount = Mathf.RoundToInt(position.y / size);
        Vector3 result = new Vector3((float)xCount * size, (float)yCount * size);
        result += transform.position;
        return result;
    }
    public void PlaceBuildingNear(Vector3 clickPoint)
    {
        var finalPosition = GetNearestPointOnGrid(clickPoint);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = finalPosition;
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        for (float x = 0; x < 5; x += size)
        {
            for (float y = 0; y < 5; y += size)
            {
                var ppoint = GetNearestPointOnGrid(new Vector3(x, y, 0f));
                var mpoint = GetNearestPointOnGrid(new Vector3(-x, -y, 0f));
                var mppoint = GetNearestPointOnGrid(new Vector3(-x, y, 0f));
                var pmpoint = GetNearestPointOnGrid(new Vector3(x, -y, 0f));
                Gizmos.DrawSphere(ppoint, 0.1f);
                Gizmos.DrawSphere(mpoint, 0.1f);
                Gizmos.DrawSphere(mppoint, 0.1f);
                Gizmos.DrawSphere(pmpoint, 0.1f);
            }
        }
    }
    
}
