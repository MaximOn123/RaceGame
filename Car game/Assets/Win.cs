using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public GameObject WinMenuText;
    public GameObject Timer;
    public bool entered = false;
  //  private bool debug = true;
        void OnTriggerEnter() {
            if (!entered)
            {
                Debug.Log("EEEEEEE");
                Timer.SetActive(false);
                entered = true;
            Timer.SetActive(false);
                WinMenuText.GetComponent<Text>().text ="Поздравляем! Ваше время: " + Timer.GetComponent<Text>().text;
            WinMenuText.SetActive(true);
            }
        }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            WinMenuText.SetActive(false);
            entered = false;
        }
    }
}
