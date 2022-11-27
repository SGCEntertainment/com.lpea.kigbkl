using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemRes : MonoBehaviour
{
    [SerializeField] private string num1;
    [SerializeField] private string num2;
    [SerializeField] private string teamName1;
    [SerializeField] private string teamName2;

    [SerializeField] private Sprite team1;
    [SerializeField] private Sprite team2;

    [SerializeField] private Image team1S;
    [SerializeField] private Image team2S;

    [SerializeField] private TextMeshProUGUI num1T;
    [SerializeField] private TextMeshProUGUI num2T;
    [SerializeField] private TextMeshProUGUI teamName1T;
    [SerializeField] private TextMeshProUGUI teamName2T;

    private void Start()
    {
        team1S.sprite = team1;
        team2S.sprite = team2;

        num1T.text = num1;
        num2T.text = num2;

        teamName1T.text = teamName1;
        teamName2T.text = teamName2;
    }
}
