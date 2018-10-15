using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace pcapdatacopy.My
{
	// Token: 0x0200000B RID: 11
	[HideModuleName]
	[StandardModule]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	internal sealed class MySettingsProperty
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000230C File Offset: 0x0000070C
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
