using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class ImgController : MonoBehaviour
{
    // UI stuff
    public Image imgPlayer;
    public Text imgText, whoText;
    public InputField imgInput;
    public GameObject imgChoiseBox;
    //Scenes stuff
    public ImgClass currentScene;
    public ImgClass[] allScenes;

    private void Awake()
    {
        LoadScene(currentScene);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ProcessScene();
        }
    }

    public void ProcessScene()
    {
        switch (currentScene.type)
        {
            case ImgType.normal:
                NextScene(currentScene.idToLoad);
                break;
            case ImgType.input:
                if (imgInput.text != "" || imgInput.text != null)
                {
                    NextScene(currentScene.idToLoad);
                }
                break;
            case ImgType.choise:
                break;
        }
    }
    public void LoadScene(ImgClass scene)
    {
        currentScene = scene;
        switch (scene.type)
        {
            case ImgType.normal:
                imgPlayer.sprite = scene.img;
                imgText.text = scene.text;
                whoText.text = scene.who;
                imgInput.gameObject.SetActive(false);
                imgChoiseBox.SetActive(false);
                break;
        }
    }
    
    public void NextScene(int id)
    {
        GameFlow.currentId = id;
        foreach (var scene in allScenes)
        {
            if (scene.id == GameFlow.currentId)
            {
                LoadScene(scene);
                break;
            }
        }
    }
}
