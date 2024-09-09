using UnityEngine;

namespace Chapter.State
{
    public class MoveRight : MonoBehaviour, IBikeState
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
                if (Input.GetKey("d"))
                {
                    transform.Translate(Vector3.right * _playerController.CurrentSpeed * Time.deltaTime);
                }
            }
        }
    }
}