using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    private long pastFrame;
    
    // Start is called before the first frame update
    void Start()
    {
        pastFrame = Time.frameCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount - pastFrame > 50)
        {
            Instantiate(obstacle);
        }
        
    }
}
