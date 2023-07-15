using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLineGenerator : MonoBehaviour
{

    public Line linePrefab;
    public float positionDistance = 0.1f;
    public float moveX = -4.5f;
    public float minY = -4.5f;
    public float maxY = -3.5f;

    // Start is called before the first frame update
    void Start()
    {
        Line lineGO = Instantiate(linePrefab);
        Line line = lineGO.GetComponent<Line>();
        for(int i=0; i<100; i++) {
            Vector2 pos = new Vector2(moveX, Random.Range(minY, maxY));
            line.UpdateLine(pos);
            moveX += positionDistance;
        }
    }
}
