using System.Collections.Generic;
using Scripts.Manager;
using UnityEngine;

namespace Scripts.Utils
{
	public static class Extension
	{
		public static T GetOrAddComponent<T>(this GameObject go) where T : UnityEngine.Component
		{
			return Utility.GetOrAddComponent<T>(go);
		}

		public static bool IsValid(this GameObject go)
		{
			return go != null && go.activeSelf;
		}
		
		public static void DestroyChilds(this GameObject go)
		{
			var children = new Transform[go.transform.childCount];
			for (var i = 0; i < go.transform.childCount; i++)
			{
				children[i] = go.transform.GetChild(i);
			}

			// 모든 자식 오브젝트 삭제
			foreach (var child in children)
			{
				Managers.Resource.Destroy(child.gameObject);
			}
		}

		public static void Shuffle<T>(this IList<T> list)
		{
			var n = list.Count;
			while (n > 1)
			{
				n--;
				var k = UnityEngine.Random.Range(0, n + 1);
				(list[k], list[n]) = (list[n], list[k]);
			}
		}
	}
}
