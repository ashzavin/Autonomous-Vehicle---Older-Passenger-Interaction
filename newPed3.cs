using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using OculusSampleFramework;
using UnityEngine.SceneManagement;

public class newPed3 : MonoBehaviour
{
    public GameObject ash;
    public GameObject ashv;
    public GameObject ashPed;
    public GameObject way;
    public string Loadlevel1;

    // Start is called before the first frame update
    void awake()
    {
        //videoP = GetComponent<VideoPlayer>();
    }
    void Start()
    {

        ash.SetActive(false);
        ashPed.SetActive(false);
        ashv.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        if (way.transform.position.z >= 122.0)
        {
            ashv.SetActive(false);
            ash.SetActive(true);
            ashPed.SetActive(true);
            Invoke("sceneStart3", 10);

        }
    }

    public void sceneStart3()
    {
        SceneManager.LoadScene(Loadlevel1);
    }

}
