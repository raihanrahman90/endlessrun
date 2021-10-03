using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    // Start is called before the first frame update
    private int currentScore;
    [Header("Score Highlight")]
    public int scoreHighlightRange;
    public CharacterSoundController sound;

    private int lastScoreHighlight = 0;
    void Start()
    {
        currentScore = 0;
        lastScoreHighlight = 0;
    }
    public float GetCurrentScore()
    {
        return currentScore;
    }
    public void IncreaseCurrentScore(int increment)
    {
        currentScore += increment; 
        if (currentScore - lastScoreHighlight > scoreHighlightRange)
        {
            sound.PlayScoreHighlight();
            lastScoreHighlight += scoreHighlightRange;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void FinishScoring()
    {
        if(currentScore > ScoreData.highScore)
        {
            ScoreData.highScore = currentScore;
        }
    }
}
