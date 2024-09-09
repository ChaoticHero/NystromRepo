using UnityEngine;

namespace Chapter.State
{
    public class BikeTurnState : MonoBehaviour, IBikeState
    {
        private Vector3 _turnDirection;
        private PlayerController _playerController;
        
        public void Handle(PlayerController playerController)
        {
            if (!_playerController)
                _playerController = playerController;
            
            

            
        }
    }
}