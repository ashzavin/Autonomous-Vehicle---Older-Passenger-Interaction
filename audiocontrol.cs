using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiocontrol : MonoBehaviour
{
    public GameObject ab;

    public GameObject way1;
    // Start is called before the first frame update
    void awake()
    {
        //videoP = GetComponent<VideoPlayer>();
    }
    void Start()
    {
        ab.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (way1.transform.position.z >= 20.0)
        {

            ab.SetActive(true);


        }
    }
}
