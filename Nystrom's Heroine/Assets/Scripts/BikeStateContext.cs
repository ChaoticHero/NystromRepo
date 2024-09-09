namespace Chapter.State
{
    public class BikeStateContext
    {
        public IBikeState CurrentState
        {
            get; set;
        }
        
        private readonly PlayerController _playerController;

        public BikeStateContext(PlayerController playerController)
        {
            _playerController = playerController;
        }

        public void Transition()
        {
            CurrentState.Handle(_playerController);
        }
        
        public void Transition(IBikeState state)
        {
            CurrentState = state;
            CurrentState.Handle(_playerController);
        }
    }
}