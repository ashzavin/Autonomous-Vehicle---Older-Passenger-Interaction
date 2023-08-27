using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioAshaControlAgain : MonoBehaviour
{
    public GameObject audioAsh1;
    public GameObject audioAsh2;
    void Start()
    {
        audioAsh1.SetActive(false);
        audioAsh2.SetActive(false);
        Invoke("changeAudioValue1", 10);
        Invoke("changeAudioValue2", 18);
    }

    public void changeAudioValue1()
    {
        audioAsh1.SetActive(true);
    }

    public void changeAudioValue2()
    {
        audioAsh2.SetActive(true);
    }
}
