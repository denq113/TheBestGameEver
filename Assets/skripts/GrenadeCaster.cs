using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeCaster : MonoBehaviour
{
    public Rigidbody grenatePrefab;
    public Transform grenadeSourceTransform;

    public float force = 10;
    void Start()
    {
        
    }
    private void Update()
    {
       if(Input.GetMouseButtonDown(1))
        {
          var grenade =  Instantiate(grenatePrefab);
            grenade.transform.position = grenadeSourceTransform.position;
            grenade.GetComponent<Rigidbody>().AddForce(grenadeSourceTransform.forward * force); 
        }
    }
}
