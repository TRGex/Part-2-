using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseDetector : MonoBehaviour
{

    private void Start()
    {
      
    }

    private void Update()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
        if (EventSystem.current.IsPointerOverGameObject())
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
   }
}

