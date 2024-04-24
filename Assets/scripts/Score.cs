using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreTEXT;
    public float contadorScore = 0f;
    
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        contadorScore += Time.deltaTime;
        scoreTEXT.text = "Score: " + (contadorScore * 10).ToString("00000");

        
    }

    
}
