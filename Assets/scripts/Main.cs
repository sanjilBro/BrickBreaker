using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Main : MonoBehaviour
{
public int level;    
public int score = 0;

private int brickCount;

private void Awake()
{
    DontDestroyOnLoad(this.gameObject);   
}


    // Start is called before the first frame update
   private void Start()
    {
        Game();
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scneIndex, LoadSceneMode arg1)
    {
        if(scneIndex.buildIndex>0){
            brickCount = FindObjectsOfType<Brick>().Length;
            if(FindObjectOfType<Ball>() == null)return;
            FindObjectOfType<Ball>().OnBrickCollision += DecreaseBrickCount;
        }

    }

    private void DecreaseBrickCount()
    {
        brickCount--;
        if(brickCount<1){
            LoadLevel(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    // Update is called once per frame
    private void Game()
    {
        this.score=0;
        LoadLevel(1);
    }

    private void LoadLevel(int level)
    {
        this.level=level;
        SceneManager.LoadScene(this.level);
    }
}
