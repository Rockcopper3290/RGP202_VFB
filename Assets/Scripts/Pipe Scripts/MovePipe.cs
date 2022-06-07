using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float Pipe_moveSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Will move pipes down every frame
        transform.position += Vector3.down * Pipe_moveSpeed * Time.deltaTime;
    }
}
