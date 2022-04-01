using System.Collections;
using Enums;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class LoadingScreen
    {
        [SerializeField] private static Image _stub;
        [SerializeField] private static Transform _windowRoot;
        private bool _loading = false;
        public bool IsLoading => _loading;
        [CanBeNull] private static LoadingScreen _instance;
        
        private LoadingScreen(){}
        public static LoadingScreen Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new LoadingScreen();
                return _instance;
            }
        }

        public void StartGameLoad()
        {
            StartGame();
        }

        private IEnumerable StartGame()
        {
            LoadingQueue();
            yield return new WaitUntil(() => _loading == false);
        }

        private IEnumerable LoadingQueue()
        {
            Instance._loading = true;
            yield return WindowController.Instance.LoadMainWindow(_windowRoot);
            yield return new WaitUntil(() => WindowController.Instance.IsLoaded(Windows.Main));
            yield return null;
            _stub.gameObject.SetActive(false);
            yield return null;
            Instance._loading = false;
        }
    }
}