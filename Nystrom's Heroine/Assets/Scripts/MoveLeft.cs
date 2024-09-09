using UnityEngine;

namespace Chapter.State
{
    public class MoveLeft : MonoBehaviour, IBikeState
    {
        private PlayerController _playerController;

        public void Handle(PlayerController playerController)
        {
            if (!_playerController)
                _playerController = playerController;

            _playerController.CurrentSpeed =
                _playerController.maxSpeed;
        }

        void Update()
        {
            if (_playerController)
            {
                if (Input.GetKey("a"))
                {
                    transform.Translate(Vector3.left * _playerController.CurrentSpeed * Time.deltaTime);
                }
            }
        }
    }
}