using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10f;
    public float maxDistance = 10f;
    private Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(Vector3.Distance(initialPosition, transform.position)> maxDistance)
        {
            Destroy(gameObject);
        }
    }
}
