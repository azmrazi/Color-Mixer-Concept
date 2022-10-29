using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    private Animator anim;
    public int LevelToLoad;
    public int LevelToRestart;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void FadeToLevel()
    {
        anim.SetTrigger("Fade");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
   
}
