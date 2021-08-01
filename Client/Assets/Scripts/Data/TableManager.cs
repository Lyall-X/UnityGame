namespace Common.Data
{
	public class TableManager : BaseObject
  {
		private static TableManager instance;
		public static TableManager Create()
		{
			if (instance == null)
			{
				instance = new TableManager();
			}
			return instance;
		}
		
		public override void Initialize()
		{
		}
    
		public override void OnUpdate(float deltaTime)
		{
		}

		public override void OnDispose()
		{
		}
  }
}