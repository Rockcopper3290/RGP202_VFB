using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1.0f;
    private float timer = 0.0f;
    public GameObject pipe;
    public float pipeHozShift = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(Random.Range(-pipeHozShift, pipeHozShift), 0, 0);

            Destroy(newPipe, 15);

            timer = 0;

        }
        timer += Time.deltaTime;
    }
}
