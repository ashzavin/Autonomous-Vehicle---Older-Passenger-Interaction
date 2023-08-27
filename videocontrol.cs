using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videocontrol : MonoBehaviour
{
    public GameObject s1;
    public GameObject s2;
    public GameObject way;
    // Start is called before the first frame update
    void awake()
    {
        //videoP = GetComponent<VideoPlayer>();
    }
    void Start()
    {
        s1.SetActive(false);
        s2.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (way.transform.position.z >= 45.0)
        {
            s1.SetActive(true);
            s2.SetActive(true);
        }
    }
}
