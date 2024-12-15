using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float _speed = 1.0f;
    [SerializeField] Transform _player;
    Vector3 _playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        PositionOfPlayer();
    }

    void Update()
    {
        MoveTowards();
        DestroyWhenReached();
    }


    /// <summary>
    /// Funkcije!!
    /// </summary>
    void PositionOfPlayer()
    {
        _playerPosition = _player.transform.position;
    }

    void MoveTowards()
    {
        transform.position = Vector3.MoveTowards(transform.position, _playerPosition, Time.deltaTime * _speed);
    }

    void DestroyWhenReached()
    {
        if (transform.position == _playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
