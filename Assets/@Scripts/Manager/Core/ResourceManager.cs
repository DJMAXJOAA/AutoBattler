using UnityEngine;

namespace Scripts.Manager.Core
{
	public class ResourceManager
	{
		public void Destroy(GameObject go)
		{
			if (go == null)
				return;

			if (Manager.Managers.Pool.Push(go))
				return;

			Object.Destroy(go);
		}
	}
}
