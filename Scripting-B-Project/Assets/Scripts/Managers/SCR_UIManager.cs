using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text healthText;
    public Text maxHealthText;

    public GameObject levelUp;

    // Start is called before the first frame update
    void Start()
    {
        SCR_GameManager.HealthChange += UpdateHealth;
        SCR_GameManager.HealthMaxChange += UpdateHealthMax;
        SCR_GameManager.ScoreChange += IncreaseScore;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) ShowLevelUp();
    }

    public void UpdateHealth(int newHealth)
    {
        healthText.text = "Health : " + newHealth;
    }
    public void UpdateHealthMax(int newHealthMax)
    {
        maxHealthText.text = " / " + newHealthMax;
    }
    public void IncreaseScore(int score)
    {
        scoreText.text = "Score : " + score;
    }

    public void ShowLevelUp()
    {
        levelUp.SetActive(!levelUp.active);
    }
}
