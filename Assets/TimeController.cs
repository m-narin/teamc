using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
  public float time = 0;
  GameObject timeText;

  void Start()
  {
    this.timeText = GameObject.Find("Time");
    time = 0;
  }

  // Update is called once per frame
  void Update()
  {
    time += Time.deltaTime;
    timeText.GetComponent<Text>().text = "Time:" + time.ToString();
  }
}
