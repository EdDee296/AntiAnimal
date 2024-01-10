using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public static double lifeValue = 0;
    public GameManager gameManager;
    public Text life;

    void Start()
    {
        life = GetComponent<Text>();
    }
    void Update()
    {
        life.text = "Escape: " + lifeValue.ToString();
    }
    void LateUpdate()
    {
        if (lifeValue >= 10) {
                gameManager.GameOver();
            }
    }
}
