using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HP : MonoBehaviour
{
    private TMP_Text scoreField;
    private int hp = 3;
    private Enemiesfollow scoreScript;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreField = GetComponent<TMP_Text>();
        scoreField.text = "" + hp;
    }

    public int getHp(){
        return hp;
    }
    public void AddScore(int add) {
        
        hp += add;
        scoreField.text = "" + hp;
        scoreScript = FindObjectOfType<Enemiesfollow>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
