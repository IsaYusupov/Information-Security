using UnityEngine;
public class Hero : MonoBehaviour
{
    [SerializeField] public float _speed;
    private float _directionX;
    private float _directionY;
    private Animator _animator;
    private SpriteRenderer _sprite;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _sprite = GetComponent<SpriteRenderer>();
    } 
    public void SetDirectionX(float direction)
     {
        _directionX = direction; 
     } 
    public void SetDirectionY(float direction)
    { 
        _directionY = direction;
    }
    private void Update()
    {
        if (_directionX != 0)
        {
            var delta = _directionX * _speed * Time.deltaTime;
            var newXPosition = transform.position.x + delta;
            transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);
        }
        if (_directionY != 0)
        {
            var delta = _directionY * _speed * Time.deltaTime;
            var newYPOsition = transform.position.y + delta;
            transform.position = new Vector3(transform.position.x, newYPOsition, transform.position.z);
        }
        UpdateSpriteDirection(); 
    } 
    private void FixedUpdate()
    {
        _animator.SetBool("is-running",_directionX !=0);
    } 
    private void UpdateSpriteDirection()
    {
        if (_directionX > 0)
        {
            _sprite.flipX = false;
        }
        else if (_directionX < 0)
        {
            _sprite.flipX = true;
        }
    }
}