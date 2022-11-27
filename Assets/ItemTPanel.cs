using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemTPanel : MonoBehaviour
{
    public static ItemTPanel instance;

    [SerializeField] private Image team1S;

    [SerializeField] private TextMeshProUGUI num1T;
    [SerializeField] private TextMeshProUGUI num2T;
    [SerializeField] private TextMeshProUGUI teamName1T;
    [SerializeField] private TextMeshProUGUI teamName1_5T;
    [SerializeField] private TextMeshProUGUI teamName2T;

    private void Awake()
    {
        instance = this;
    }

    public void GetRes(string num1, string num2, string teamName1, string teamName1_5, string teamName2, Sprite team1)
    {
        team1S.sprite = team1;

        num1T.text = num1;
        num2T.text = num2;

        teamName1T.text = teamName1;
        teamName1_5T.text = teamName1_5;
        teamName2T.text = teamName2;
    }
}
