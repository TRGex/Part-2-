using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{

    public List<Vector2> points;
    Vector2 lastPosition;
    Vector2 currentPosition;
    public float pointThreshold = 0.2f;
    LineRenderer lineRenderer;

    void OnMouseDown()
    {
        points = new List<Vector2>();
        lineRenderer.positionCount = 1;
        lineRenderer.SetPosition(0, transform.position);
    }

    void OnMouseDrag()
    {
        Vector2 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Vector2.Distance(currentPosition, lastPosition) > pointThreshold)
        {
            points.Add(currentPosition);
            lineRenderer.positionCount++;
            lineRenderer.SetPosition(lineRenderer.positionCount - 1, currentPosition);
            lastPosition = currentPosition;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 1;
        lineRenderer.SetPosition(0, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
   
    }
}
