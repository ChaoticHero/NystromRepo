using UnityEngine;

namespace Chapter.State
{
    public class ClientState : MonoBehaviour
    {
        private PlayerController _playerController;

        void Start()
        {
            _playerController =
                (PlayerController)
                FindObjectOfType(typeof(PlayerController));
        }
       
        void OnGUI() 
        {

            if (GUILayout.Button("Stop Bike"))
                //_playerController.Standing();
                    
            if (Input.GetKeyDown("g"))
                _playerController.Dead();

            if (Input.GetKeyDown("a"))
                _playerController.Left();

            if (Input.GetKeyDown("d"))
                _playerController.Right();

            if (Input.GetKeyDown("space"))
                _playerController.Jump();

        }
    }
}