using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioSource source;
    public float newClip;
    public float timer;
  //  private bool exited = false;
    void Start() {
       source =  gameObject.AddComponent<AudioSource>();
        source.volume = 0.1f;
    }
    void Awake() {
        newCLIP();
        timer = 0;
    }
    void Update() {
        timer += Time.deltaTime;
        if (timer >= newClip + 1) {
            newCLIP();
            timer = 0;
        }
    }
    public void newCLIP() {
        int clipNum = Random.Range(0, clips.Length);
        if (!source.isPlaying) {
            source.loop = true;
            source.PlayOneShot(clips[clipNum]);
        }
        newClip = clips[clipNum].length;
    }
}
