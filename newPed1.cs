using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using OculusSampleFramework;
using UnityEngine.SceneManagement;

public class newPed1 : MonoBehaviour
{
    public GameObject ashv;
    public GameObject ashPed;
    public GameObject ashPedA;
    public GameObject playga;
    public GameObject way;
    public GameObject turna1;
    public GameObject turna2;
    public GameObject turnwarn;
    public GameObject iconwarn;
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
        playga.SetActive(false);
        ashv.SetActive(true);

        turna1.SetActive(false);
        turna2.SetActive(false);
        turnwarn.SetActive(false);
        iconwarn.SetActive(false);
        savier.SetActive(false);
        flag = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (way.transform.position.z >= -50.0)
        {
            playga.SetActive(true);

        }

        if (way.transform.position.z >= -35.0 & flag == 0)
        {
            turna1.SetActive(true);
            turna2.SetActive(true);
            Invoke("turnWarnNow", 2);

        }

        if (way.transform.position.z >= 30.0)
        {
            iconwarn.SetActive(false);
            flag = 1;
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

    public void turnWarnNow()
    {
        turnwarn.SetActive(true);
        iconwarn.SetActive(true);

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
