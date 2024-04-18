using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieHP : MonoBehaviour
{

    [SerializeField] private int enemieHP = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // private void OnTriggerEnter(Collider other){
    //     if (other.tag == "Hammer")
    //     {
            
            
    //     }

        
    // }

    public int getHp(){
        return enemieHP;
    }


    public void AddScore(int add) {
        
        enemieHP += add;
        
    }
    // Update is called once per frame
    void Update()
    {
        if (enemieHP == 0)
        {
            GameObject.Destroy(gameObject);       
        }
    }
}
