using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
//using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace pcapdatacopy.My
{
	// Token: 0x02000002 RID: 2
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class MyApplication : WindowsFormsApplicationBase
	{
        // Token: 0x06000002 RID: 2 RVA: 0x00002334 File Offset: 0x00000734
        [STAThread]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DebuggerHidden]
        internal static void Main(string[] Args)
        {
            
                //Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
           
            
                //MyProject.Application.Run(Args);  // this is the old one
                ////MyProject session = new MyProject();
                //Form1 session = new Form1();
                //EventArgs err = new EventArgs();
                //session.selectfile_Click(session.selectfile_button, err);
                //Console.Write(session.file_selected_textbox.Text + "\n");
                ////session.selectfolder_button_Click(session.selectfolder_button, err);
                ////Console.Write(session.folder_selected_textbox.Text+"\n");
                ////session.create_raw_file_Click(session.analyse_file, err);
                //session.create_raw_file_Click(session.detect_rtp, err);
                //Console.Write(session.rtp_status.Text + "\n");
                //session.create_raw_file_Click(session.create_audio_rtp_files_button, err);
            
            
        }

        // Token: 0x06000003 RID: 3 RVA: 0x00002370 File Offset: 0x00000770
        [DebuggerStepThrough]
		public MyApplication() : base(AuthenticationMode.Windows)
		{
			List<WeakReference> _ENCList = MyApplication.__ENCList;
			lock (_ENCList)
			{
				MyApplication.__ENCList.Add(new WeakReference(this));
			}
			this.IsSingleInstance = false;
			this.EnableVisualStyles = true;
			this.SaveMySettingsOnExit = true;
			this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000023E4 File Offset: 0x000007E4
		[DebuggerStepThrough]
		protected override void OnCreateMainForm()
		{
			this.MainForm = MyProject.Forms.Form1;
		}

		// Token: 0x04000001 RID: 1
		private static List<WeakReference> __ENCList = new List<WeakReference>();
	}
}
