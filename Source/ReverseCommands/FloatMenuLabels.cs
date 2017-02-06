﻿using System;
using System.Collections.Generic;
using Harmony;
using UnityEngine;
using Verse;

namespace ReverseCommands
{
	public class FloatMenuLabels : FloatMenu
	{
		public FloatMenuLabels(List<FloatMenuOption> options) : base(options, null, false)
		{
			givesColonistOrders = false;
			vanishIfMouseDistant = true;
			closeOnClickedOutside = false;
		}
	}

	public class FloatMenuOptionNoClose : FloatMenuOption
	{
		public FloatMenuOptionNoClose(string label, Action action)
			: base(label, action, MenuOptionPriority.Default, null, null, 0, null, null) { }

		public override bool DoGUI(Rect rect, bool colonistOrdering)
		{
			base.DoGUI(rect, colonistOrdering);
			return false; // don't close after an item is selected
		}
	}
}