using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int Player1Score;
    public int Player2Score;
    public Text scoreText1;
    public Text scoreText2;
    public GameObject gameOverScreen;
    

    [Header("Scene Atributtes")]
    public GameObject ball;
    public Text scoreText;

    private ParticleSystem.EmissionModule ballParticleEmission;

    [Header("Control Vars")]
    private int goalLimit; 
    private int timeLimit;
    
    

    public void AddScore1(int ScoreToAdd)
    {
        Player1Score += ScoreToAdd;
        scoreText1.text = Player1Score.ToString();
    }

    public void AddScore2(int ScoreToAdd)
    {
        Player2Score += ScoreToAdd;
        scoreText2.text = Player2Score.ToString();
    }
}
    

