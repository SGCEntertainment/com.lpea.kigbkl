using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemT : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Sprite sprite;

    [SerializeField] private string num1;
    [SerializeField] private string num2;
    [SerializeField] private string teamName2;



    private void Start()
    {
        image.sprite = sprite;

    }

    public void Click()
    {
        ItemTPanel.instance.GetRes(num1, num2, sprite.name, sprite.name, teamName2, sprite);
    }

}
