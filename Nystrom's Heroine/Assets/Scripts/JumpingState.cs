using UnityEngine;

namespace Chapter.State
{
    public class JumpingState : MonoBehaviour, IBikeState
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
                if (Input.GetKeyDown("space"))
                {
                    transform.Translate(Vector3.up * 500 * Time.deltaTime);

                }
            }
        }
    }
}
