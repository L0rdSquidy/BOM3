using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KillonHit : MonoBehaviour
{
    public string targetTag;
    private ParticleSystem ps;

    private EnemieHP Enemiehp;
    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();

        Enemiehp = FindObjectOfType<EnemieHP>();
    }
    private void OnCollisionEnter(Collision coll)
{
        if (coll.gameObject.tag == targetTag){
            ps.Play();
            Destroy(coll.gameObject, 0.1f);
    }
}
    private void OnTriggerEnter(Collider coll)
{
    if (coll.gameObject.tag == targetTag){
        ps.Play();
        Enemiehp.AddScore(-1);
    }
}

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
