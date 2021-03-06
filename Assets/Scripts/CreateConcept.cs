﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreateConcept : MonoBehaviour
{
    public GameObject conceptContainer;
    private Vector3 mousePos;
    public Button addConceptButton;
    public TMP_InputField conceptInputField;

    void Start()
    {
        addConceptButton.onClick.AddListener(AddConcept);
    }

    void AddConcept()
    {
        mousePos = Input.mousePosition;
        mousePos.z = 10;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Instantiate(conceptContainer, mousePos, Quaternion.identity);
        conceptContainer.GetComponent<ControlConcept>().concept.title = conceptInputField.text;
    }
}
