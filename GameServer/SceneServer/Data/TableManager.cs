namespace Common.Data
{
	public class TableManager : BaseObject
	{
		private static TableManager instance;
///[APPEND_VAR]

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
			this.LoadTables();
		}
			
		public T LoadData<T>(string path) where T : class
		{
            var fullPath = base.DataPath + path;
            return SerializeUtil.Deserialize<T>(fullPath);
		}

		public void LoadTables() 
		{
///[APPEND_TABLE]
		}

		public override void OnUpdate(float deltaTime)
		{
		}

		public override void OnDispose()
		{
		}
	}
}
