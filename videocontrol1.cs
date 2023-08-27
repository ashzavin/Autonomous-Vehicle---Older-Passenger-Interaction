using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class videocontrol1 : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;

    public GameObject way;
    // Start is called before the first frame update
    void awake()
    {
        //videoP = GetComponent<VideoPlayer>();
    }
    void Start()
    {
        c.SetActive(true);
        a.SetActive(false);
        b.SetActive(false);
        d.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (way.transform.position.z >= 40.0)
        {
            c.SetActive(false);
            a.SetActive(true);
            b.SetActive(true);
            d.SetActive(true);

        }
    }
}
