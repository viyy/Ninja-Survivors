using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowController : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject _mainWindow;
    public void LoadMainWindow()
    {
        var prefab = Resources.Load("Prefabs/Windows/MainWindow") as GameObject;
        _mainWindow = Instantiate(prefab);
    }
}
