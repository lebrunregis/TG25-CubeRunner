using UnityEngine;
using UnityEngine.InputSystem;

public class CarScript : MonoBehaviour
{
    private Transform myTransform;
    [SerializeField] private float _speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position += myTransform.forward * _speed * Time.deltaTime;
        if(myTransform.position.z < 0)
        {
            Object.Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
    }
}
