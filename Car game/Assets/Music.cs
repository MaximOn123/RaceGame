using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioSource source;
    public float newClip;
    public float timer;
    private bool exited = false;

    void Start()
    {
        source = gameObject.AddComponent<AudioSource>();
        source.volume = 0.3f;
    }

    void Update()
    {
        if (exited)
        {
            newCLIP();
            timer = 0;
            exited = false;
        }
        timer += Time.deltaTime;
        if (timer >= newClip + 0.5)
        {
            newCLIP();
            timer = 0;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exited = true;
            source.Stop();
        }

    }
    void newCLIP()
    {
        int clipNum = Random.Range(0, clips.Length);
        if (!source.isPlaying)
        {
            source.loop = true;
            source.PlayOneShot(clips[clipNum]);
        }
        newClip = clips[clipNum].length;
    }
}
