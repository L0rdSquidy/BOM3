using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemiesfollow : MonoBehaviour
{
    [SerializeField] Vector3 differencefactor;
    [SerializeField] Transform A;
    [SerializeField] Transform B;

    [SerializeField] float distance;
    Vector3 diraction;
    [SerializeField] float  speed = 1;
    bool AtoB = true;
    private ParticleSystem ps;

    public string targetTag;
    private HP hpScript;
    // Start is called before the first frame update
    void Start()
    {
        // B = GameObject.FindGameObjectWithTag("Playertarget").transform;
        transform.position = A.position;
        hpScript = FindObjectOfType<HP>();
        ps = GetComponent<ParticleSystem>();
        ps.Stop();
    }



    // Update is called once per frame
    void Update()
    {
        if (AtoB)
        {
            differencefactor = B.transform.position - transform.position;
            transform.LookAt(B.position);
        } //else {
        //     differencefactor = A.transform.position - transform.position;
        //     transform.LookAt(A.position);
        // }
         
        distance = differencefactor.magnitude;
        diraction = differencefactor.normalized;

        transform.position += diraction * speed * Time.deltaTime;
        
        
    }
    private void OnTriggerEnter(Collider other){
        if (other.tag == "Hammer")
        {
            
            ps.Play();
        }

        
    }

    private void OnCollisionEnter(Collision coll)
{
        if (coll.gameObject.tag == "Player"){
            
            hpScript.AddScore(-1);
    }
}

    
}
