﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Update_Label : MonoBehaviour {
    public GameObject slider;
    public string text_format;

    private Text text;
    private Slider slider_component;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
        slider_component = slider.GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = String.Format(text_format, slider_component.value);
	}
}
