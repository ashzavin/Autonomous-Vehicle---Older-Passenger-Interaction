using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlsc : MonoBehaviour
{
    public GameObject p;
    public GameObject q;
    public GameObject way;
    // Start is called before the first frame update
    void awake()
    {
        //videoP = GetComponent<VideoPlayer>();
    }
    void Start()
    {
        p.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (way.transform.position.z >= 30.0)
        {
            p.SetActive(true);
            q.SetActive(false);

        }
    }
}
