using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MyFirstScript : MonoBehaviour
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
        myTransform.position += myTransform.forward *_speed * Time.deltaTime ;
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            myTransform.position += -myTransform.right * _speed * 2 * Time.deltaTime;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            myTransform.position += myTransform.right * _speed * 2 * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Car"))
        {   
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
