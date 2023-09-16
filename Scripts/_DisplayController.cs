using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class _DisplayController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI chargeUI = default;

    GameController _GameController = default;

    void Start()
    {
        _GameController = FindObjectOfType<GameController>();
    }

    void Update()
    {
        DisplayChargePoint();
    }

    private void DisplayChargePoint()
    {
        chargeUI.text = _GameController.GetChargePoint().ToString();
    }
}
