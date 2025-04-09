using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField] private float _respawnDelta = 1;
    [SerializeField] private float _respawnTime = 2;
    [SerializeField] private GameObject _spawnedObject;
    private float _spawnTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RestartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        _spawnTime -= Time.deltaTime;
        if( _spawnTime < 0)
        {
            RestartTimer();
            Instantiate(_spawnedObject, this.transform.position, this.transform.rotation);
        }
    }

    void RestartTimer()
    {
        _spawnTime = _respawnTime + Random.value * _respawnDelta;
    }
}
