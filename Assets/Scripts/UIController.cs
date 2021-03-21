using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour
{

  int score = 0;
  GameObject scoreText;
  GameObject emergencyText;

  public void Emergency()
  {
    this.emergencyText.GetComponent<Text>().text = "緊急事態宣言";
  }

  public void AddScore()
  {
    this.score += 10;
  }

  void Start()
  {
    this.scoreText = GameObject.Find("Score");
    this.emergencyText = GameObject.Find("Emergency");
  }

  void Update()
  {
    scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
  }
}