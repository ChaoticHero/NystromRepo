using UnityEngine;

namespace Chapter.State
{
    public class IdleState : MonoBehaviour, IBikeState
    {
        private PlayerController _playerController; 
        
        public void Handle(PlayerController playerController)
        {
            
        }
    }
}