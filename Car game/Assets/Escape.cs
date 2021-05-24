using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Escape : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject MainMenuCamera;
    public GameObject StartGameCamera;
    public GameObject StartGame;
    public GameObject Timer;
    public GameObject Car;
    public bool game;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            game = false;
            Timer.SetActive(false);
            Car.SetActive(false);
        }
        if (!game) {
            MainMenu.SetActive(true);
            MainMenuCamera.SetActive(true);
            StartGameCamera.SetActive(false);
            StartGame.SetActive(true);
            game = true;
        }
    }
}
