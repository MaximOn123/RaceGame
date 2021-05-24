using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject car;
    public Vector3 position;
    public Vector3 rotation;

    public void Spawn()
    {
        car.transform.position = position;
        car.transform.eulerAngles = rotation;
    }
}