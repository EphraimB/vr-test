using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public GameObject extinguisherStream;
    public Transform bottle;
    public Transform hose;

    private bool isPouring = false;
    private bool pourCheck;
    
    public float bottleTopHeight;
    public float bottleMidHeight;

    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        bottleMidHeight = bottle.position.y;
        bottleTopHeight = hose.position.y;

        pourCheck = (bottleTopHeight-bottleMidHeight) > 0;


        if(isPouring != pourCheck)
        {
              isPouring = pourCheck;
              extinguisherStream.SetActive(isPouring);
        }
    }
}
