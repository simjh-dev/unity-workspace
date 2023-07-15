using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineGenerator : MonoBehaviour
{
    public Line linePrefab;
    Line activeLine;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Line lineGO = Instantiate(linePrefab);
            activeLine = lineGO.GetComponent<Line>();
        }

        if(Input.GetMouseButtonUp(0))
        {
            activeLine = null;
        }

        if(activeLine != null) {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("x: " + mousePos.x + ", y:" + mousePos.y);
            activeLine.UpdateLine(mousePos);
        }
    }
}
