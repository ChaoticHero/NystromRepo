using UnityEngine;

namespace Chapter.State
{
    public class PlayerController : MonoBehaviour
    {

        public float maxSpeed = 15.0f;

        public float CurrentSpeed { get; set; }



        private IBikeState
           _deadstate, _left, _right, _jump;

        private BikeStateContext _bikeStateContext;

        private void Start()
        {
            _bikeStateContext =
                new BikeStateContext(this);
            _right = gameObject.AddComponent<MoveRight>();
            _left = gameObject.AddComponent<MoveLeft>();
            _jump = gameObject.AddComponent<JumpingState>();

            _deadstate = gameObject.AddComponent<DeadState>();

        }
        public void Left()
        {
            _bikeStateContext.Transition(_left);

        }
        public void Dead()
        {
            _bikeStateContext.Transition(_deadstate);
        }
        public void Right()
        {
            _bikeStateContext.Transition(_right);
        }
        public void Jump()
        {
            _bikeStateContext.Transition(_jump);
        }
    }
}