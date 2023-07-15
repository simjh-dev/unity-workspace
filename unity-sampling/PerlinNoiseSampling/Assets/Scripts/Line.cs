using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public EdgeCollider2D edgeCol;
    public float pointDistance = .1f;
    List<Vector2> points;

    public void UpdateLine(Vector2 point) 
    {
        if(points == null)
        {
            points = new List<Vector2>();
            SetPoint(point);
            return;
        }

        // Check if the mouse has moved enough for us to insert new point
        // If it has: Insert point at mouse position
        if (Vector2.Distance(points[points.Count - 1], point) > pointDistance)
            SetPoint(point);
    
    }

    void SetPoint(Vector2 point)
    {
        points.Add(point);

        lineRenderer.positionCount = points.Count;
        lineRenderer.SetPosition(points.Count - 1, point);
        
        if(points.Count > 1)
            edgeCol.points = points.ToArray();
    }
}
