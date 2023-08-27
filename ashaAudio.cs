using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ashaAudio : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject audioAsh1;
    public GameObject audioAsh2;
    public GameObject audioAsh3;
    void Start()
    {
        audioAsh1.SetActive(false);
        audioAsh3.SetActive(false);
        audioAsh2.SetActive(false);
        Invoke("changeAudioValue1", 10);
        Invoke("changeAudioValue2", 20);
        Invoke("changeAudioValue3", 27);
    }

    public void changeAudioValue1()
    {
        audioAsh1.SetActive(true);
    }

    public void changeAudioValue3()
    {
        audioAsh3.SetActive(true);
    }

    public void changeAudioValue2()
    {
        audioAsh2.SetActive(true);
    }
}
