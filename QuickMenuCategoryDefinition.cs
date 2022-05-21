using System;
using System.Collections.Generic;
using UnityEngine;

namespace QuickMenu
{
	[CreateAssetMenu]
	public class QuickMenuCategoryDefinition : ScriptableObject
	{
		[Serializable]
		public struct Category
        {
			public string name;

			[ColorUsage(false)] public Color color;
        }

		public List<Category> categories;
	}
}