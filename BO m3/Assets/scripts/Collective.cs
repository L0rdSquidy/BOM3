using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collective : MonoBehaviour
{
    private ParticleSystem ps;
    private Renderer r;
    
    private Inventory invScript;
    // Start is called before the first frame update
    void Start()
    {
    r = GetComponent<Renderer>();
    ps = GetComponent<ParticleSystem>();
    
    Debug.Log(invScript);
    }


    private void OnTriggerEnter(Collider other)
{
    invScript = FindObjectOfType<Inventory>();
    if (other.tag == "Player") {
        r.enabled = true;
        invScript.AddScore(1);
        ps.Play();
        GameObject.Destroy(gameObject, 0.5f);
        ps.Stop();
    }
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
