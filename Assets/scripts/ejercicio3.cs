using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ejercicio3 : MonoBehaviour
{
    List<string> items = new List<string>();

    [SerializeField] private TextMeshProUGUI coinsText;
    [SerializeField] private TextMeshProUGUI appleText;

    private int monedas = 0;
    private int manzanas = 0;

    private int inputAmount = 0;
    private string input;

    private void Update()
    {
        //if (input != null)
        //    inputAmount = int.Parse(input);
        UpdateUI();
    }

    public void AgregarObjeto(string item)
    {
        for (int i = 0; i < inputAmount; i++)
        {
            items.Add(item);
        }

        UpdateUI();
    }

    public void QuitarObjeto(string item)
    {
        for (int i = 0; i < inputAmount; i++)
        {
            items.Remove(item);
        }
        UpdateUI();
    }

    //public void ReadStringInput(string s)
    //{
    //    input = s;
    //}

    public void UpdateUI()
    {
        monedas = 0;
       
        manzanas = 0;

        foreach (string item in items)
        {
            if (item == "Coin")
                monedas++;
            else
                manzanas++;
        }

        coinsText.text = $"Coins: {monedas.ToString("D2")}";
        appleText.text = $"Apples: {manzanas.ToString("D2")}";
    }
}
