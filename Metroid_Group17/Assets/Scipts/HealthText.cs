using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthText : MonoBehaviour
{
    public PlayerController player;

    public TMP_Text textbox;

    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Health: " +  player.health;
    }
}
