namespace Server.Interface
{
    public interface IWorld : IObject
    {
        void Initialize();
        void OnDispose();
    }
}