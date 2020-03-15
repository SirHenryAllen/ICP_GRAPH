﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowHeightValue : MonoBehaviour {
  public Slider sliderUI;
  private Text textSliderValue;

  void Start (){
    textSliderValue = GetComponent<Text>();
    ShowSliderValue();
  }

  public void ShowSliderValue () {
    string sliderMessage = "1m" + sliderUI.value;
    textSliderValue.text = sliderMessage;
  }
}