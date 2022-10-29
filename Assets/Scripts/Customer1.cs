using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer1 : MonoBehaviour
{
    public int MaxPercents = 95;
    private float TimeStart = 4;
    public int RandNum;
    public StartMixing StartMix;
    public int CurrentPercents;
    public ProgressBar progressBar;
    public ChangedColor Color;
    public LevelChanger Level;

    void Start()
    {
        CurrentPercents = 0;
        progressBar.SetPercent(CurrentPercents);
        RandNum = Random.Range(10, 75);
    }

    // Update is called once per frame
    void Update()
    {
        if(Color.TargetColor == Color.m_second)
        {
            progressBar.SetPercent(MaxPercents);
            TimeStart -= Time.deltaTime;
            Level.LevelToLoad = 2;
            Level.FadeToLevel();
        }
        else if (StartMix.Loops == 1)
        {
            progressBar.SetPercent(RandNum);
            TimeStart -= Time.deltaTime;
            Level.LevelToLoad = 1;
            Level.FadeToLevel();
            
        }
    }
}
