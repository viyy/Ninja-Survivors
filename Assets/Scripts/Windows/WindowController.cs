using System.Collections;
using System.Collections.Generic;
using Enums;
using JetBrains.Annotations;
using UnityEngine;

public class WindowController
{
    private WindowController(){}
    [CanBeNull] private static WindowController _instance;

    public static WindowController Instance
    {
        get
        {
            if (_instance != null) return _instance;
            _instance = new WindowController();
            return _instance;
        }
    }

    // Start is called before the first frame update
    private readonly Dictionary<Windows, GameObject> _windows = new Dictionary<Windows, GameObject>();
    public IEnumerable LoadMainWindow(Transform root)
    {
        if (!_windows.ContainsKey(Windows.Main))
        {
            var prefab = Resources.Load("Prefabs/Windows/MainWindow") as GameObject;
            yield return null;
            var mainWindow = Object.Instantiate(prefab, root);
            yield return null;
            _windows.Add(Windows.Main, mainWindow);
        }
        else
        {
            _windows[Windows.Main].SetActive(true);
        }
    }

    public bool IsLoaded(Windows wtype) => _windows.ContainsKey(wtype) && _windows[wtype].activeSelf;
    public GameObject GetWindow(Windows type) => _windows.ContainsKey(type) ? _windows[type] : null;
}
