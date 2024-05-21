using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Script : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreUI;
    Game_Manager_Script myGM;
    [SerializeField] private GameObject startMenuUI;
    [SerializeField] private GameObject gameOverUI;
    void Start()
    {
        myGM = Game_Manager_Script.Instance;
        myGM.onGameOver.AddListener(ActivateGameOverUI);
    }
    public void PlayButtonHandler()
    {
        myGM.StartGame();
    }
    public void ActivateGameOverUI()
    {
        gameOverUI.SetActive(true);
    }
    void Update()
    {
        scoreUI.text = "SCORE: " + myGM.currentScore.ToString("F");
    }
}
