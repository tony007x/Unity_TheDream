using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
 
public class EndToLoad : MonoBehaviour
{
 
     VideoPlayer video;
     public GameObject ClassVideo;
     public GameObject ClasswithoutVideo;
 
    void Start()
    {
        video = GetComponent<VideoPlayer>();
        video.Play();
        StartCoroutine("WaitForMovieEnd");
    }
 
 
    public IEnumerator WaitForMovieEnd()
    {
        while (video.isPlaying)
        {
            yield return new WaitForEndOfFrame();
         
        }
        OnMovieEnded();
    }
 
     void OnMovieEnded()
    {
        if(ClassVideo.activeInHierarchy == true)
        {
            ClassVideo.SetActive(false);
            ClasswithoutVideo.SetActive(true);
        }
        
    }
}
 