using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Fungus.Script
{
	[CommandInfo("Scripting", 
	             "Call", 
	             "Execute another sequence.", 
	             255, 255, 255)]
	public class Call : FungusCommand
	{	
		public Sequence targetSequence;
	
		public override void OnEnter()
		{
			if (targetSequence != null)
			{
				ExecuteSequence(targetSequence);
			}
			else
			{		
				Continue();
			}
		}

		public override void GetConnectedSequences(ref List<Sequence> connectedSequences)
		{
			if (targetSequence != null)
			{
				connectedSequences.Add(targetSequence);
			}		
		}
		
		public override string GetSummary()
		{
			if (targetSequence == null)
			{
				return "<Continue>";
			}

			return targetSequence.name;
		}
	}

}