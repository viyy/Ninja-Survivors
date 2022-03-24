using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    public WindowController windowController;
    public GameObject stub;
    private void Awake()
    {
        windowController.LoadMainWindow();
        stub.SetActive(false);
    }
}
