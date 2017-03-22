using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using SimpleNetwork;

using UnityEngine;


public class MyLearningroomBehaviorScript : BehaviourScript {

	// Spawn point enumeration
	public enum level 
	{
		level1 = 1,
		level2 = 2,
		level3 = 3,
		custom = 4
	};

	// Selected spawn point
	public level select = level.level1;


	GameObject agent;

	// Initalization
	protected override void AgentInitalization()
	{		
		// find all agent OBJECTS  in the scene containing a specific script
		getAllAgentObjects<MyLearningroomAgentScript>();
		
		// find and init all agent SCRIPTS  in the scene containing a specific script
		getAndInitAllAgentScripts<MyLearningroomAgentScript>();

		// set default position to selected spawn point
		switch((int)select){
			case 1:
				agentScripts[0].DefaultAgentPosition = new Vector3(87f,19f,30f); 
				break;
			case 2:
				agentScripts[0].DefaultAgentPosition = new Vector3(28f,21f,32f);
				break;
			case 3:
				agentScripts[0].DefaultAgentPosition = new Vector3(28f,21f,45f); 
				break;
			case 4:
				agentScripts[0].DefaultAgentPosition = new Vector3(82f,19f,16.5f);
				break;
		}

		agentScripts[0].DefaultRotation = 0;

		Reset();
		
	}

	// Reset environment
	protected override void ProcessMsgEnvironmentReset( MsgEnvironmentReset msg )
	{			
 		
		Reset();
	}
	
}
