using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private TMP_Text scoreField;
    private int hammer = 0;
    // int score = 0;

    private Collective scoreScript;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreField = GetComponent<TMP_Text>();
        scoreField.text = "" + hammer;
    }
    public void AddScore(int add) {
        hammer += add;
        scoreField.text = "" + hammer;
        scoreScript = FindObjectOfType<Collective>();
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
