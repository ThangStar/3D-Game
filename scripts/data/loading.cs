using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System.Threading.Tasks;
using Unity.VisualScripting;
using System;

public class MyLoading : MonoBehaviour
{
    [Header("Menu Screen")]
    [SerializeField] private GameObject loadingCanvas;
    [Header("Slider")]
    [SerializeField] private Slider loadingSlider;
    [Header("Name level load")]
    [SerializeField] private string levelToLoad;
    private bool isCanNext = false;
    public static MyLoading instance;
    private int counterNext = 0;
    [Header("Scene num")]
    [SerializeField] private int sceneNum;
    SubTitle[] subTitles;
    void Start()
    {
        print("HELLO TÔI Ở SCENE: "+sceneNum);
        switch (sceneNum)
        {
            case 1:
                subTitles = MySubTitle.getScene1();
                break;
            case 2:
                subTitles = MySubTitle.getScene2();
                break;
        }
    }
    void Awake()
    {
        // if (instance == null)
        // {
        //     instance = this;
        //     // DontDestroyOnLoad(gameObject);
        // }
        // else
        // {
        //     Destroy(gameObject);
        // }
    }
    public void LoadNewScene()
    {
        counterNext++;
        if (counterNext >= subTitles.Length)
        {
            if (sceneNum == 2)
            {
                loadingCanvas.SetActive(true);
                StartCoroutine(LoadSceneAsync());
            }else{
                StopAllCoroutines();
                SceneManager.LoadScene(levelToLoad);
            }
        }
        // Show the loading screen (enable the Canvas with the loading screen UI elements)


        // Load the new scene asynchronously
    }

    IEnumerator LoadSceneAsync()
    {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(levelToLoad);

        // Don't show the loading screen until the scene is fully loaded
        loadOperation.allowSceneActivation = false;

        while (!loadOperation.isDone)
        {
            // Update a loading bar or progress text on your loading screen
            float progressValue = Mathf.Clamp01(loadOperation.progress / 0.9f);
            // Update the loading screen with progress information
            print(loadOperation.progress);
            loadingSlider.value = progressValue;
            if (progressValue >= 1.0f)
            {
                // When the loading is complete, enable the Canvas for the new scene
                loadOperation.allowSceneActivation = true;
            }
            yield return null;
        }
    }

}