using UnityEngine;

namespace Chapter.State
{
    
    public class DeadState : MonoBehaviour, IBikeState
    {   
        
        private PlayerController _playerController;

        public void Handle(PlayerController playerController)
        {
            if (!_playerController)
                _playerController = playerController;
            
            // Start is called before the first frame update
        }

        void Update()
        {
            if (_playerController)
            {
                if (Input.GetKeyDown("g"))
                    Debug.Log("It works");
            }
        }
    }
}
