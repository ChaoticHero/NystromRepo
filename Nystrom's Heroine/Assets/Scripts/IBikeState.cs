
namespace Chapter.State
{
    public interface IBikeState
    {
        void Handle(PlayerController controller);
    }
}