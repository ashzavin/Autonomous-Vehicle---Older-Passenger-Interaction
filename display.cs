using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class display : MonoBehaviour
{

    public GameObject p;
    public void Update()
    {

        GameObject surface = GameObject.Find("carsurface");
        var videoPlayer = surface.AddComponent<UnityEngine.Video.VideoPlayer>();
        videoPlayer.playOnAwake = false;
        videoPlayer.url = "C:/Users/uCalgayPC/Desktop/old/Assets/videos/try.mp4";
        videoPlayer.isLooping = true;
        //Invoke("videoplay", 5f);

        //Debug.Log(p.transform.position.z);

        if (p.transform.position.z>=45.0)
        {
            //Debug.Log(p.transform.position.z);
            videoPlayer.Play();
        }
        
    }
   
}
