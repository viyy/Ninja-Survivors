using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    [SerializeField]
    private GameObject stub;

    [SerializeField]
    private GameObject windowRoot;
    private void Awake()
    {
        LoadingScreen.Instance.StartGameLoad();
    }
}
