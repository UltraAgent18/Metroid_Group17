using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    public PlayerController player;

    public TMP_Text textbox;
    public Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<TMP_Text>();
        textbox.text = "Health: " + healthText.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Health: " +  player.health;
    }
}
