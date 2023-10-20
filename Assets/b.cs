using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public GameObject bulletPrefab;
    public Transform cannonTransform;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        if (Input.GetButtonDown("Fire1"))
        {
            FireBullet();
        }

       void FireBullet(){
            if (bulletPrefab != null && cannonTransform !=null)
            {
                GameObject bullet = Instantiate(bulletPrefab, cannonTransform.position, cannonTransform.rotation);
                
                
            }
        }
    }
}
