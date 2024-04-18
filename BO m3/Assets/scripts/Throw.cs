using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public float cooldowntime = 1f;
    private bool isCooldown = false;

    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private IEnumerator Cooldown()
    {
        isCooldown = true;
        yield return new WaitForSeconds(cooldowntime);
        isCooldown = false;
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Mouse0) && !isCooldown) {
            StartCoroutine(Cooldown());
            GameObject ob = Instantiate(prefab);
            ob.transform.position = transform.position;
            ob.transform.rotation = transform.rotation;
            Destroy(ob,3f);
 }
    }
}
