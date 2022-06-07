using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1.0f;
    private float timer = 0.0f;

    public GameObject pipe_easy;
    public GameObject pipe_mid;
    public GameObject pipe_hard;

    public float pipeHozShift = 1.0f;

    public FlyLittleBird player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Each function is to spawn in their respective pipes
    void spawnEasyPipe()
    {
        GameObject newPipe = Instantiate(pipe_easy);
        MovePipes(newPipe);
    }
    void spawnMidPipe()
    {
        GameObject newPipe = Instantiate(pipe_mid);
        MovePipes(newPipe);
    }
    void spawnHardPipe()
    {
        GameObject newPipe = Instantiate(pipe_hard);
        MovePipes(newPipe);
    }

    // Will tell the pipes/objects to move down the screen
    void MovePipes(GameObject newPipe)
    {
        newPipe.transform.position = transform.position + new Vector3(Random.Range(-pipeHozShift, pipeHozShift), 0, 0);

        Destroy(newPipe, 15);

        timer = 0;
    }

    // Will randomise the pipe spawning between the easy pipes and mid pipes
    void Randomise_Easy_Mid()
    {
        int randKey = Random.Range(1, 10);
        if (randKey <= 4)
        {
            spawnEasyPipe();
        }
        else
        {
            spawnMidPipe();
        }
    }

    // Will randomise the pipe spawning between the easy pipes and mid pipes
    void Randomise_AllPipes()
    {
        int randKey = Random.Range(1, 10);
        if (randKey <= 2)
        {
            spawnEasyPipe();
        }
        else if (randKey > 2 && randKey <=5)
        {
            spawnMidPipe();
        }
        else if (randKey > 5)
        {
            spawnHardPipe();
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            if (player.playerScore <= 30)
            {
                spawnEasyPipe();
            }
            else if (player.playerScore <= 60)
            {
                Randomise_Easy_Mid();
            }
            else
            {
                Randomise_AllPipes();
            }


        }
        timer += Time.deltaTime;
    }
}
