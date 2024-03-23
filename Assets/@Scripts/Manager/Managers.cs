using Scripts.Manager.Contents;
using Scripts.Manager.Core;
using UnityEngine;

namespace Scripts.Manager
{
	public class Managers : MonoBehaviour
	{
		private static Managers s_instance;
		private static Managers Instance { get { Init(); return s_instance; } }

		#region Contents
		readonly GameManager _game = new GameManager();
		readonly ObjectManager _object = new ObjectManager();
		public static GameManager Game { get { return Instance?._game; } }
		public static ObjectManager Object { get { return Instance?._object; } }
		#endregion
			
		#region Core
		private readonly DataManager _data = new();
		private readonly PoolManager _pool = new();
		private readonly ResourceManager _resource = new();
		private readonly SceneManagerEx _scene = new();
		private readonly SoundManager _sound = new();
		private readonly UIManager _ui = new();

		public static DataManager Data { get { return Instance?._data; } }
		public static PoolManager Pool { get { return Instance?._pool; } }
		public static ResourceManager Resource { get { return Instance?._resource; } }
		public static SceneManagerEx Scene { get { return Instance?._scene; } }
		public static SoundManager Sound { get { return Instance?._sound; } }
		public static UIManager UI { get { return Instance?._ui; } }
		#endregion
		public static void Init()
		{
			if (s_instance == null)
			{
				GameObject go = GameObject.Find("@Managers");
				if (go == null)
				{
					go = new GameObject { name = "@Managers" };
					go.AddComponent<Managers>();
				}

				DontDestroyOnLoad(go);
				s_instance = go.GetComponent<Managers>();
			}		
		}

		public static void Clear()
		{
			// 매니저 초기화
		}
	}
}
