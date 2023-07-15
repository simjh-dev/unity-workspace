using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{

    public GameObject pipe;
    float timer = 0;
    public float timeDiff;

    private const float pipeX = 5;
    private const float pipeYMin = -1.5f;
    private const float pipeYMax = 3.0f;


    private const float pipeZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = new Vector3(pipeX, Random.Range(pipeYMin, pipeYMax), pipeZ);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > timeDiff)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(pipeX, Random.Range(pipeYMin, pipeYMax), pipeZ);
            timer = 0;

            Destroy(newPipe, 10.0f);
        }
    }
}
