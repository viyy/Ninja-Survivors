using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainWindow : MonoBehaviour
{
   public Button exitBtn;
   public Button startBtn;
   private void Awake()
   {
      exitBtn.onClick.AddListener(Application.Quit);
   }

   private void OnDestroy()
   {
      exitBtn.onClick.RemoveAllListeners();
   }
}
