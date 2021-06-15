using UnityEngine;


namespace BunnyFlappy
{
    public class BunnyController : MonoBehaviour
    {
        #region Fields

        [SerializeField] private float _speed = 5.0f;
        private Animator _animator;

        #endregion


        #region UnityMethods

        private void Start()
        {
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            MoveTheBunny();
        }

        #endregion


        #region Methods

        private void MoveTheBunny()
        {
            float horizontalInput = Input.GetAxis(Constants.HorizontalInput);
            _animator.SetFloat(Constants.FloatParameterForAnimator, Mathf.Abs(horizontalInput));
            
            Vector2 positionOfTheBunny = transform.position;
            positionOfTheBunny.x += horizontalInput * _speed * Time.deltaTime;
            transform.position = positionOfTheBunny;
        }

        #endregion
    }
}