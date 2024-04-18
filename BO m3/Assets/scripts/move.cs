using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class move : MonoBehaviour
{

    float rotation = 0;
    [SerializeField]float speed = 10;
    [SerializeField]float rotationspeed = 140;
    private HP hpScript;

    public GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        hpScript = FindObjectOfType<HP>();
        Time.timeScale = 1;
        
    }

    // Update is called once per frame
    
    void Update()
    {
        if (hpScript.getHp() == 0)
        {
            UI.SetActive(true);
            Debug.Log(UI);
            GameObject.Destroy(gameObject);
            Time.timeScale = 0;
            
        }

        transform.position +=
            Input.GetAxisRaw("Vertical") *
            transform.forward *
            speed *
            Time.deltaTime;
        rotation += 
        Input.GetAxisRaw("Horizontal") *
        rotationspeed *
        Time.deltaTime;
        transform.rotation =
            Quaternion.Euler(new Vector3(0, rotation, 0));
    }
}