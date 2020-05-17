using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public Animator transitionTop;
    public Animator transitionMiddle1;
    public Animator transitionMiddle2;
    public Animator transitionBottom;

    public float seconds = 1f;
    public int currentScene;


    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            StartCoroutine(LoadLevel(currentScene + 1, transitionTop));
            StartCoroutine(LoadLevel(currentScene + 1, transitionMiddle1));
            StartCoroutine(LoadLevel(currentScene + 1, transitionMiddle2));
            StartCoroutine(LoadLevel(currentScene + 1, transitionBottom));
        }
    }


    IEnumerator LoadLevel(int levelIndex, Animator transition)
    {
        transition.SetTrigger("Start");
        
        yield return new WaitForSeconds(seconds);

        SceneManager.LoadScene(levelIndex);
    }
}
