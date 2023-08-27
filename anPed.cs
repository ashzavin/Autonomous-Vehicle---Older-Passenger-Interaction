using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using OculusSampleFramework;
using UnityEngine.SceneManagement;

public class anPed : MonoBehaviour
{
    public GameObject ashv;
    public GameObject ashPed;
    public GameObject ashPedA;
    public GameObject way;
    public GameObject turna1;
    public GameObject savier;
    public string Loadlevel;
    

    int flag;
    // Start is called before the first frame update
    void awake()
    {
        //videoP = GetComponent<VideoPlayer>();
    }
    void Start()
    {

        ashPed.SetActive(false);
        ashPedA.SetActive(false);
        ashv.SetActive(true);
        savier.SetActive(false);
        turna1.SetActive(false);
        flag = 0;
    }

    // Update is called once per frame
    void Update()
    {


        if (way.transform.position.z >= -35.0)
        {
            turna1.SetActive(true);
        }

        if (way.transform.position.z >= 122.0)
        {
            ashv.SetActive(false);
            ashPed.SetActive(true);
            ashPedA.SetActive(true);
            Invoke("savierStart", 10);
            Invoke("sceneStart", 20);

        }
    }

    public void sceneStart()
    {
        SceneManager.LoadScene(Loadlevel);
    }

    public void savierStart()
    {
        savier.SetActive(true);
    }
}
